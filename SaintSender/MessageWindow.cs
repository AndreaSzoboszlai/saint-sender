using MailKit;
using MimeKit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaintSender
{
    public partial class MessageWindow : MetroFramework.Forms.MetroForm
    {
        Timer t;
        MessageLoader messageLoader;
        String email;
        String pass;
        List<String> folders = new List<string>();
        string selectedFolder = "INBOX";
        int count = 0;

        public MessageWindow(String email, String pass)
        {
            InitializeComponent();
            this.email = email;
            this.pass = pass;
        }

        private void MessageWindow_Load(object sender, EventArgs e)
        {
            LoadMessages();
        }

        private async void LoadMessages()
        {
            messageLoader = new MessageLoader("imap.gmail.com", 993, true, email, pass);
            messageLoader.emailCount = 100;
            // var allEmails = messageLoader.GetAllMails();
            // progressBar1.Value = 0;
            var progress = new Progress<MimeMessage>(email => GetEmailDetails(email));
            List<string> folderList = messageLoader.getFolders();
            folderList.Insert(0, "");
            folderDropDown.DataSource = folderList;
            await Task.Factory.StartNew(() => messageLoader.GetAllMails(progress), TaskCreationOptions.LongRunning);
        }

        private void GetEmailDetails(MimeMessage email)
        {
            loadProgressBar.Maximum = messageLoader.emailCount;
            string[] row = new string[] { email.From.ToString(), email.Subject, email.Date.ToString() };
            ListViewItem rowItem = new ListViewItem(row);
            rowItem.Tag = email.MessageId;
            Console.WriteLine(": " + rowItem.Tag.ToString());
            emailList.Items.Add(rowItem);
            loadProgressBar.Increment(1);
        }

        private void OnFormClose(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void onEmailSelected(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            try
            {
               // MessageBox.Show(emailList.SelectedItems[0].ToString());
               emailContentBox.DocumentText = messageLoader.getEmailById(emailList.SelectedItems[0].Tag.ToString(), selectedFolder).HtmlBody;
            }
            catch
            {

            }

        }

        private async void onSelected(object sender, EventArgs e)
        {
            if (count != 0)
            {
                onSelectedIndexChanged();
            }

            count++;
        }

        private async void MessageWindowReLoad(object sender, EventArgs e)
        {
            messageLoader = new MessageLoader("imap.gmail.com", 993, true, email, pass);
            messageLoader.emailCount = 100;
            // var allEmails = messageLoader.GetAllMails();
            // progressBar1.Value = 0;
            var progress = new Progress<MimeMessage>(email => GetEmailDetails(email));
            await Task.Factory.StartNew(() => messageLoader.GetAllMails(progress), TaskCreationOptions.LongRunning);
        }

        private async void onSelectedIndexChanged()
        {
            loadProgressBar.Value = 0;
            emailList.Items.Clear();
            char[] charsToTrim = { '(', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', ' ', ')' };
            selectedFolder = folderDropDown.SelectedItem.ToString().Trim(charsToTrim);

            var progress = new Progress<MimeMessage>(email => GetEmailDetails(email));
            await Task.Factory.StartNew(() => messageLoader.GetAllMailsByFolder(progress, selectedFolder), TaskCreationOptions.LongRunning);
        }

        private void RefreshIcon_Click(object sender, EventArgs e)
        {
            onSelectedIndexChanged();
        }
    }
}
