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
    public class InboxMailMessage : IDisposable
    {
        public string From { get; internal set; }
        public string To { get; internal set; }
        public MailAddressCollection Bcc { get; internal set; }
        public MailAddressCollection Cc { get; internal set; }
        public string Subject { get; internal set; }
        public string Body { get; internal set; }
        public IEnumerable<MailFileAttachment> Attachments { get; internal set; }

        public void Dispose()
        {
            foreach (var attachment in Attachments)
            {
                attachment.Dispose();
            }
        }
    }
}