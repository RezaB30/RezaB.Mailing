using OpenPop.Pop3;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Text;

namespace RezaB.Mailing.Client
{
    /// <summary>
    /// A mail client that supports <i>SMTP</i> & <i>POP3</i>.
    /// </summary>
    public class MailClient : IMailClient, IDisposable
    {
        private bool disposedValue;
        /// <summary>
        /// Mail host name.
        /// </summary>
        public string HostName { get; private set; }
        /// <summary>
        /// Host port.
        /// </summary>
        public int HostPort { get; private set; }
        /// <summary>
        /// Should use SSL. (currently not supported.)
        /// </summary>
        public bool UseSSL { get; private set; }
        /// <summary>
        /// Mail username.
        /// </summary>
        public string Username { get; private set; }
        /// <summary>
        /// Mail password.
        /// </summary>
        public string Password { get; private set; }
        /// <summary>
        /// Creates a mail client for sending and receiving messages.
        /// </summary>
        /// <param name="hostName">Mail host name.</param>
        /// <param name="hostPort">Host port.</param>
        /// <param name="useSSL">Should use SSL. (currently not supported.)</param>
        /// <param name="username">Mail username.</param>
        /// <param name="password">Mail password.</param>
        public MailClient(string hostName, int hostPort, bool useSSL, string username, string password)
        {
            HostName = hostName;
            HostPort = hostPort;
            UseSSL = useSSL;
            Username = username;
            Password = password;
        }

        public IEnumerable<InboxMailMessageInfo> GetAllInboxMessages()
        {
            using (var mailClient = new Pop3Client())
            {
                mailClient.Connect(HostName, HostPort, UseSSL);
                mailClient.Authenticate(Username, Password);
                var allMessageInfos = mailClient.GetMessageInfos();
                var allMessageHeaders = allMessageInfos.Select(mi => new
                {
                    Headers = mailClient.GetMessageHeaders(mi.Number),
                    Number = mi.Number,
                    UUID = mi.Identifier
                }).Select(message => new InboxMailMessageInfo()
                {
                    UUID = message.UUID,
                    Subject = message.Headers.Subject,
                    From = message.Headers.From.Address
                }).ToArray();
                mailClient.Disconnect();
                return allMessageHeaders;
            }
        }

        public StandardMailMessage GetInboxMessageById(string uuid)
        {
            using (var mailClient = new Pop3Client())
            {
                mailClient.Connect(HostName, HostPort, UseSSL);
                mailClient.Authenticate(Username, Password);

                var messageNo = mailClient.GetMessageInfos().FindIndex(info => info.Identifier == uuid);
                var currentMailMessage = mailClient.GetMessage(messageNo + 1).ToMailMessage();

                return new StandardMailMessage(currentMailMessage);
                
            }
        }

        public int GetInboxMessageCount()
        {
            var messageCount = 0;
            using (var mailClient = new Pop3Client())
            {
                mailClient.Connect(HostName, HostPort, UseSSL);
                mailClient.Authenticate(Username, Password);
                messageCount = mailClient.GetMessageCount();
                mailClient.Disconnect();
            }
            return messageCount;
        }

        public void SendMail(StandardMailMessage sendingMessage)
        {
            using (var smtpClient = new SmtpClient()
            {
                Credentials = new NetworkCredential() { Password = Password, UserName = Username },
                Port = HostPort,
                Host = HostName,
                EnableSsl = UseSSL
            })
            {
                using (var message = new MailMessage())
                {
                    message.From = new MailAddress(Username);
                    message.Subject = sendingMessage.Subject;
                    message.IsBodyHtml = sendingMessage.BodyType == MailBodyType.HTML ? true : false;
                    message.Body = sendingMessage.Body;

                    SetupMailAddressCollection(message.To, sendingMessage.To);
                    SetupMailAddressCollection(message.CC, sendingMessage.Cc);
                    SetupMailAddressCollection(message.Bcc, sendingMessage.Bcc);

                    foreach (var attachmentItem in sendingMessage.Attachments)
                    {
                        if (attachmentItem.Content.CanSeek)
                            attachmentItem.Content.Seek(0, SeekOrigin.Begin);
                        message.Attachments.Add(new Attachment(attachmentItem.Content, attachmentItem.FileName));
                    }

                    smtpClient.Send(message);
                }
            }
        }

        
        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects)
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                disposedValue = true;
            }
        }

        // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        // ~MailClient()
        // {
        //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        private void SetupMailAddressCollection(MailAddressCollection mailAddressCollection, ICollection<string> mailAddresses)
        {
            if (mailAddresses != null)
            {
                foreach (var mailAddress in mailAddresses)
                {
                    mailAddressCollection.Add(mailAddress);
                }
            }
        }
    }
}
