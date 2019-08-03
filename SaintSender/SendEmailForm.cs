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
    public partial class SendEmailForm : MetroFramework.Forms.MetroForm
    {
        MessageLoader messageLoader;
        string email;
        string pass;
        public SendEmailForm(String email, String pass)
        {
            InitializeComponent();
            this.email = email;
            this.pass = pass;
        }

        private void SendEmailForm_Load(object sender, EventArgs e)
        {
            messageLoader = new MessageLoader(email, pass);
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            string from = fromTextBox.Text;
            string to = toTextBox.Text;
            string subject = subjectTextBox.Text;
            string message = messageTextBox.Text;
            messageLoader.sendMessage(from, to, subject, message);
            MessageBox.Show("Email sent.");
            this.Close();
        }
    }
}
