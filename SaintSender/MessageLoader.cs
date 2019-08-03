using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailKit;
using MailKit.Net.Imap;
using MailKit.Net.Smtp;
using MailKit.Search;
using MailKit.Security;
using MimeKit;

namespace SaintSender
{
    class MessageLoader
    {
        Timer t;
        private readonly string mailServer, login, password;
        private readonly int port;
        private readonly bool ssl;
        public int emailCount { get; set; }
        public List<IMailFolder> emailFolders { get; set; }

        public MessageLoader(string mailServer, int port, bool ssl, string login, string password)
        {
            this.mailServer = mailServer;
            this.port = port;
            this.ssl = ssl;
            this.login = login;
            this.password = password;
            MessageBox.Show(login);
        }

        public MessageLoader(string email, string pass)
        {
            this.login = email;
            this.password = pass;
            MessageBox.Show(login);
        }

        public IEnumerable<string> GetUnreadMails()
        {
            var messages = new List<string>();

            using (var client = new ImapClient())
            {
                client.Connect(mailServer, port, ssl);
                client.AuthenticationMechanisms.Remove("XOAUTH2");

                client.Authenticate(login, password);

                var inbox = client.Inbox;
                inbox.Open(FolderAccess.ReadOnly);
                var results = inbox.Search(SearchOptions.All, SearchQuery.Not(SearchQuery.Seen));

                foreach (var uniqueId in results.UniqueIds)
                {
                    var message = inbox.GetMessage(uniqueId);

                    messages.Add(message.HtmlBody);
                    //Mark message as read
                    inbox.AddFlags(uniqueId, MessageFlags.Seen, true);
                }

                client.Disconnect(true);
            }

            return messages;
        }

        public void GetAllMails(IProgress<MimeMessage> progress)
        {
            var messages = new List<MimeMessage>();

            using (var client = new ImapClient())
            {
                try
                {
                    client.Connect(mailServer, port, ssl);
                    client.AuthenticationMechanisms.Remove("XOAUTH2");
                    client.Authenticate(login, password);

                    var mainEmailFolder = client.GetFolder(client.PersonalNamespaces[0]);
                    emailFolders = mainEmailFolder.GetSubfolders().ToList();

                    var inbox = client.Inbox;
                    inbox.Open(FolderAccess.ReadOnly);
                    var results = inbox.Search(SearchOptions.All, SearchQuery.DeliveredAfter(new DateTime(2019, 08, 01)));
                    int emailCounter = results.UniqueIds.Count;
                    if (emailCounter > 50)
                    {
                        emailCount = 50;
                    }
                    else
                    {
                        emailCount = results.UniqueIds.Count;
                    }

                    for (int i = emailCounter - 1; i >= emailCounter - emailCount; i--)
                    {
                        var message = inbox.GetMessage(results.UniqueIds[i]);
                        progress.Report(message);
                        messages.Add(message);
                    }

                    client.Disconnect(true);
                }
                catch (AuthenticationException)
                {
                    MessageBox.Show("Wrong username or password.");
                }
            }
            //return messages;
        }

        public List<String> getFolders()
        {
            List<String> folders = new List<string>();
            using (var client = new ImapClient())
            {
                try
                {
                    client.Connect(mailServer, port, ssl);
                    client.AuthenticationMechanisms.Remove("XOAUTH2");
                    client.Authenticate(login, password);

                    var mainEmailFolder = client.GetFolder(client.PersonalNamespaces[0]);
                    emailFolders = mainEmailFolder.GetSubfolders().ToList();

                    foreach (var folder in emailFolders)
                    {
                        int count = 0;
                        try
                        {
                            folder.Open(FolderAccess.ReadOnly);

                            var uids = folder.Search( SearchQuery.All);
                            foreach (var uid in uids)
                            {
                                count++;
                            }
                            //var results = folder.Search(SearchOptions.Count, SearchQuery.All);
                            //var c = results.UniqueIds.Count;
                            folders.Add(folder.FullName + " (" + count + ")");
                            folder.Close();
                        }
                        catch
                        {
                            MessageBox.Show("");
                        }
                    }
                }
                catch (AuthenticationException)
                {
                    MessageBox.Show("Wrong username or password.");
                }

                return folders;
            }

        }

        public MimeMessage getEmailById(String id, String selectedFolder)
        {
            using (var client = new ImapClient())
            {
                try
                {
                    client.Connect(mailServer, port, ssl);
                    client.AuthenticationMechanisms.Remove("XOAUTH2");
                    client.Authenticate(login, password);
                    var mainEmailFolder = client.GetFolder(client.PersonalNamespaces[0]);
                    emailFolders = mainEmailFolder.GetSubfolders().ToList();
                    foreach (var folder in emailFolders)
                    {
                        if (folder.FullName == selectedFolder)
                        {
                            folder.Open(FolderAccess.ReadOnly);
                            var results = folder.Search(SearchQuery.HeaderContains("Message-ID", id));
                            foreach (var result in results)
                            {
                                MimeMessage message = folder.GetMessage(result); ;
                                if (message.MessageId == id)
                                {
                                    return message;
                                }
                            }
                            folder.Close();
                        }
                    }
                    client.Disconnect(true);
                }
                catch (UnauthorizedAccessException)
                {
                    MessageBox.Show("Wrong username or password.");
                }
            }
            return null;
        }

        public void GetAllMailsByFolder(IProgress<MimeMessage> progress, String selectedFolder)
        {
            var messages = new List<MimeMessage>();

            using (var client = new ImapClient())
            {
                try
                {
                    client.Connect(mailServer, port, ssl);
                    client.AuthenticationMechanisms.Remove("XOAUTH2");
                    client.Authenticate(login, password);

                    var mainEmailFolder = client.GetFolder(client.PersonalNamespaces[0]);
                    emailFolders = mainEmailFolder.GetSubfolders().ToList();
                    IMailFolder inbox = null;
                  
                    foreach (var folder in emailFolders)
                    {
                        if (folder.FullName == selectedFolder)
                        {
                            inbox = folder;
                        }
                    }
                    inbox.Open(FolderAccess.ReadOnly);
                    var results = inbox.Search(SearchOptions.All, SearchQuery.All);
                    int emailCounter = results.UniqueIds.Count;
                    if (emailCounter > 50) {
                        emailCount = 50;
                    } else
                    {
                        emailCount = results.UniqueIds.Count;
                    }

                    for (int i = emailCounter - 1; i >= emailCounter - emailCount; i--)
                    {
                        var message = inbox.GetMessage(results.UniqueIds[i]);
                        progress.Report(message);
                        messages.Add(message);
                    }

                    client.Disconnect(true);
                }
                catch (AuthenticationException)
                {
                    MessageBox.Show("Wrong username or password.");
                }
            }
        }

        public void sendMessage(string from, string to, string subject, string messageBody)
        {
            MessageBox.Show(from);
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress(from));
            message.To.Add(new MailboxAddress(to));
            message.Subject = subject;

            message.Body = new TextPart("plain")
            {
                Text = messageBody
            };

            using (var client = new SmtpClient())
            {
                client.Connect("smtp.gmail.com", 587);

                client.AuthenticationMechanisms.Remove("XOAUTH2");

                // Note: only needed if the SMTP server requires authentication
                client.Authenticate(login, password);

                client.Send(message);
                client.Disconnect(true);
            }
        }
    }
}
