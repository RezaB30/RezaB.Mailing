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
    }
}
