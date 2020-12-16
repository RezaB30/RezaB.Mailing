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
using static System.Net.Mime.MediaTypeNames;

namespace RezaB.Mailing
{
    public class StandardMailMessage : IDisposable
    {
        public string UUID { get; set; }
        public string From { get; private set; }
        public ICollection<string> To { get; private set; }
        public ICollection<string> Bcc { get; private set; }
        public ICollection<string> Cc { get; private set; }

        public string Subject { get; private set; }
        public string Body { get; private set; }
        public MailBodyType? BodyType { get; private set; }
        public IEnumerable<MailFileAttachment> Attachments { get; private set; }

        public StandardMailMessage(string from, ICollection<string> to, ICollection<string> cc, ICollection<string> bcc, string subject, string body, MailBodyType? bodyType, IEnumerable<MailFileAttachment> attachments)
        {
            From = from;
            To = to;
            Cc = cc;
            Bcc = bcc;
            Subject = subject;
            Body = body;
            BodyType = bodyType;
            Attachments = attachments;
        }

        public StandardMailMessage(MailMessage message)
        {
            From = message.From.Address;
            To = message.To.Cast<MailAddress>().Select(ma => ma.Address).ToList();
            Cc = message.CC.Cast<MailAddress>().Select(ma => ma.Address).ToList();
            Bcc = message.Bcc.Cast<MailAddress>().Select(ma => ma.Address).ToList();
            Subject = message.Subject;
            Body = message.Body;
            BodyType = message.IsBodyHtml ? MailBodyType.HTML : MailBodyType.Text;
            Attachments = message.Attachments.Select(ma => new MailFileAttachment()
            {
                Content = ma.ContentStream,
                ContentType = ma.ContentType.MediaType,
                FileName = ma.Name
            });
        }

        public void Dispose()
        {
            foreach (var attachment in Attachments)
            {
                attachment.Dispose();
            }
        }
    }
}