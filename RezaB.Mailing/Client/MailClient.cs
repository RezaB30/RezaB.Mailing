using OpenPop.Pop3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace RezaB.Mailing.Client
{
    public class MailClient : IMailClient, IDisposable
    {
        private bool disposedValue;

        public string HostName { get; private set; }
        public int HostPort { get; private set; }
        public bool UseSSL { get; private set; }
        public string Username { get; private set; }
        public string Password { get; private set; }

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
            var messageCount = 0;
            using (var mailClient = new Pop3Client())
            {
                mailClient.Connect(HostName, HostPort, UseSSL);
                mailClient.Authenticate(Username, Password);
                messageCount = mailClient.GetMessageCount();
                mailClient.Disconnect();
            }
            var messageList = new List<InboxMailMessageInfo>();
            using (var mailClient = new Pop3Client())
            {
                mailClient.Connect(HostName, HostPort, UseSSL);
                mailClient.Authenticate(Username, Password);

                for (int i = 1; i <= messageCount; i++)
                {
                    var message = mailClient.GetMessage(i);

                    using (var currentMailMessage = message.ToMailMessage())
                    {
                        string bodyContent = null;
                        var attachmentNames = new List<string>();
                        bodyContent = currentMailMessage.Body;
                        foreach (var emailAttachment in currentMailMessage.Attachments)
                        {
                            attachmentNames.Add($"{emailAttachment.Name}({emailAttachment.ContentId}:{emailAttachment.ContentType.MediaType})");
                        }

                        messageList.Add(new InboxMailMessageInfo()
                        {
                            From = currentMailMessage.From.Address,
                            Subject = currentMailMessage.Subject
                        });
                    }
                }
                mailClient.Disconnect();
            }
            return messageList;
        }

        public InboxMailMessage GetInboxMessageById(string uuid)
        {
            using (var mailClient = new Pop3Client())
            {
                mailClient.Connect(HostName, HostPort, UseSSL);
                mailClient.Authenticate(Username, Password);
                var messageNo = mailClient.GetMessageInfos().FirstOrDefault(info => info.Identifier == uuid).Number;
                using (var currentMailMessage = mailClient.GetMessage(messageNo).ToMailMessage())
                {
                    string bodyContent = null;
                    var attachmentNames = new List<string>();
                    bodyContent = currentMailMessage.Body;
                    foreach (var emailAttachment in currentMailMessage.Attachments)
                    {
                        attachmentNames.Add($"{emailAttachment.Name}({emailAttachment.ContentId}:{emailAttachment.ContentType.MediaType})");
                    }

                    return new InboxMailMessage()
                    {
                        From = currentMailMessage.From.Address,
                        To = $"({string.Join(",", currentMailMessage.To.Select(address => address.Address))})",
                        Bcc = currentMailMessage.Bcc,
                        Cc = currentMailMessage.CC,
                        Subject = currentMailMessage.Subject,
                        Body = currentMailMessage.Body,
                        Attachments = currentMailMessage.Attachments.Select(att => new MailFileAttachment()
                        {
                            FileName = att.Name,
                            ContentType = att.ContentType.MediaType,
                            Content = att.ContentStream
                        })
                    };
                }
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

        public void SendMail(string to, string subject, string body, MailBodyType bodyType, IEnumerable<MailFileAttachment> attachments)
        {
            using (var smtpClient = new SmtpClient()
            {
                Credentials = new NetworkCredential() { Password = Password, UserName = Username },
                Port = HostPort,
                Host = HostName,
                EnableSsl = UseSSL
            })
            {
                using (var message = new MailMessage(Username, to, subject, body))
                {
                    message.Subject = subject;
                    message.IsBodyHtml = bodyType == MailBodyType.HTML ? true : false;
                    message.Body = body;
                    message.Attachments.Add(new Attachment(attachments.ToString()));
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
    }
}
