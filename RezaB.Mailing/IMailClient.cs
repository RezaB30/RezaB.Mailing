using System;
using System.Collections.Generic;
using System.Text;

namespace RezaB.Mailing
{
    public interface IMailClient
    {
        void SendMail(string to, string subject, string body, MailBodyType bodyType, IEnumerable<MailFileAttachment> attachments);

        int GetInboxMessageCount();

        IEnumerable<InboxMailMessageInfo> GetAllInboxMessages();

        InboxMailMessage GetInboxMessageById(string uuid);
    }
}
