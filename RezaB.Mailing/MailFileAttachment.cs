using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace RezaB.Mailing
{
    /// <summary>
    /// Represents a mail attachment.
    /// </summary>
    public class MailFileAttachment : IDisposable
    {
        /// <summary>
        /// The file name for this attachment.
        /// </summary>
        public string FileName { get; set; }
        /// <summary>
        /// Attachment content type.
        /// </summary>
        public string ContentType { get; set; }
        /// <summary>
        /// The content of the attachment.
        /// </summary>
        public Stream Content { get; set; }

        public void Dispose()
        {
            Content.Dispose();
        }
    }
}
