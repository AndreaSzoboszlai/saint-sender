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

        public MessageWindow(String email, String pass)
        {
            InitializeComponent();
            this.email = email;
            this.pass = pass;
        }

        private async void MessageWindow_Load(object sender, EventArgs e)
        {
            messageLoader = new MessageLoader("imap.gmail.com", 993, true, email, pass);
            messageLoader.emailCount = 100;
           // var allEmails = messageLoader.GetAllMails();
           // progressBar1.Value = 0;
            var progress = new Progress<MimeMessage>(email => GetEmailDetails(email));
            await Task.Factory.StartNew(() => messageLoader.GetAllMails(progress), TaskCreationOptions.LongRunning);

        }

        private void GetEmailDetails(MimeMessage email)
        {
            progressBar1.Maximum = messageLoader.emailCount;
            string[] row = new string[] { email.From.ToString(), email.Subject, email.Date.ToString() };
            emailList.Items.Add(new ListViewItem(row));
            progressBar1.Increment(1);
        }

        private void OnFormClose(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


    }
}
