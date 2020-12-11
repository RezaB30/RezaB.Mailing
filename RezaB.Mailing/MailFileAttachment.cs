using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace RezaB.Mailing
{
    public class MailFileAttachment : IDisposable
    {
        public string FileName { get; set; }
        public string ContentType { get; set; }
        public Stream Content { get; set; }

        public void Dispose()
        {
            Content.Dispose();
        }
    }
}
