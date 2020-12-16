using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;
using OpenPop.Pop3;
using OpenPop.Mime;
using OpenPop.Mime.Header;
using OpenPop.Pop3.Exceptions;
using OpenPop.Common.Logging;
using System.Web;

namespace RezaB.Mailing
{
    public class InboxMailMessageInfo
    {
        public string UUID { get; set; }
        public string From { get; set; }
        public string Subject { get; set; }
 
        public IEnumerable<MailFileAttachment> Attachments { get; set; }

        public void Dispose()
        {
            foreach (var attachment in Attachments)
            {
                attachment.Dispose();
            }
        }

        //private string MailUsername { get; set; }
        //public string MailPassword { get; set; }
        //public string FilePath { get; set; }
        //public string MailAttachments { get; set; }
        //public string HostName { get; set; }
        //public int HostPort { get; set; }
        //public bool UseSSL { get; set; }



        //public IEnumerable<InboxMailMessageInfo> GetAllInboxMessages()
        //{
        //    var messageCount = 0;
        //    using (var mailClient = new Pop3Client())
        //    {
        //        mailClient.Connect(HostName, HostPort, UseSSL);
        //        mailClient.Authenticate(MailUsername, MailPassword);
        //        messageCount = mailClient.GetMessageCount();
        //        mailClient.Disconnect();
        //    }
        //    var messageList = new List<InboxMailMessageInfo>();
        //    using (var mailClient = new Pop3Client())
        //    {
        //        mailClient.Connect(HostName, HostPort, UseSSL);
        //        mailClient.Authenticate(MailUsername, MailPassword);

        //        for (int i = 1; i <= messageCount; i++)
        //        {
        //            var message = mailClient.GetMessage(i);

        //            using (var currentMailMessage = message.ToMailMessage())
        //            {
        //                string bodyContent = null;
        //                var attachmentNames = new List<string>();
        //                bodyContent = currentMailMessage.Body;
        //                foreach (var emailAttachment in currentMailMessage.Attachments)
        //                {
        //                    attachmentNames.Add($"{emailAttachment.Name}({emailAttachment.ContentId}:{emailAttachment.ContentType.MediaType})");
        //                }

        //                messageList.Add(new InboxMailMessageInfo()
        //                {
        //                    From = currentMailMessage.From.Address,
        //                    //To = $"({string.Join(",", currentMailMessage.To.Select(address => address.Address))})",
        //                    Subject = currentMailMessage.Subject,
        //                    //Body = currentMailMessage.Body,
        //                    //Attachments = $"({string.Join(",", attachmentNames)})"
        //                });
        //            }
        //        }

        //        mailClient.Disconnect();
        //    }
        //    return messageList;
        //}

    }
}
