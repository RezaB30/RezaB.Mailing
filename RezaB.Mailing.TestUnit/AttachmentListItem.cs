using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RezaB.Mailing.TestUnit
{
    internal class AttachmentListItem
    {
        public string DisplayName { get; set; }

        public string FilePath { get; set; }

        public override string ToString()
        {
            return DisplayName;
        }
    }
}
