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
    /// <summary>
    /// Represents a full mail message with attachments and headers.
    /// </summary>
    public class StandardMailMessage : IDisposable
    {
        /// <summary>
        /// Message's unique identifier.
        /// </summary>
        public string UUID { get; set; }
        /// <summary>
        /// Which mail address, this message is from.
        /// </summary>
        public MailAddress From { get; private set; }
        /// <summary>
        /// To which address(es) this message is sent.
        /// </summary>
        public ICollection<string> To { get; private set; }
        /// <summary>
        /// To which address(es) this message is sent as BCC.
        /// </summary>
        public ICollection<string> Bcc { get; private set; }
        /// <summary>
        /// To which address(es) this message is sent as CC.
        /// </summary>
        public ICollection<string> Cc { get; private set; }
        /// <summary>
        /// The subject of the message.
        /// </summary>
        public string Subject { get; private set; }
        /// <summary>
        /// The body of the message.
        /// </summary>
        public string Body { get; private set; }
        /// <summary>
        /// Whether it is a text or HTML message.
        /// </summary>
        public MailBodyType? BodyType { get; private set; }
        /// <summary>
        /// The list of attachments of this mail.
        /// </summary>
        public IEnumerable<MailFileAttachment> Attachments { get; private set; }
        /// <summary>
        /// Creates a mail message.
        /// </summary>
        /// <param name="from">Which mail address, this message is from.</param>
        /// <param name="to">To which address(es) this message is sent.</param>
        /// <param name="cc">To which address(es) this message is sent as CC.</param>
        /// <param name="bcc">To which address(es) this message is sent as BCC.</param>
        /// <param name="subject">The subject of the message.</param>
        /// <param name="body">The body of the message.</param>
        /// <param name="bodyType">Whether it is a text or HTML message.</param>
        /// <param name="attachments">The list of attachments of this mail.</param>
        public StandardMailMessage(MailAddress from, ICollection<string> to, ICollection<string> cc, ICollection<string> bcc, string subject, string body, MailBodyType? bodyType, IEnumerable<MailFileAttachment> attachments)
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
        /// <summary>
        /// Creates a mail message based on an existing mail message.
        /// </summary>
        /// <param name="message">The base mail message.</param>
        public StandardMailMessage(MailMessage message)
        {
            From = message.From;
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