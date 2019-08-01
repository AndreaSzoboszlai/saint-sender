using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailKit;
using MailKit.Net.Imap;
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
                    var results = inbox.Search(SearchOptions.All, SearchQuery.DeliveredAfter(new DateTime(2019, 07, 30)));
                    emailCount = results.UniqueIds.Count;
                    foreach (var uniqueId in results.UniqueIds)
                    {
                        var message = inbox.GetMessage(uniqueId);
                        progress.Report(message);
                        messages.Add(message);

                        //Mark message as read
                        //inbox.AddFlags(uniqueId, MessageFlags.Seen, true);
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
    }
}
