using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RezaB.Mailing.TestUnit
{
    class DownloadedAttachment
    {
        public string FileName { get; set; }

        public byte[] Data { get; set; }

        public override string ToString()
        {
            return FileName;
        }
    }
}
