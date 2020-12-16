using System;
using System.Collections.Generic;
using System.Text;

namespace RezaB.Mailing
{
    public interface IMailClient
    {
        void SendMail(string to, string subject, string body, MailBodyType bodyType, IEnumerable<MailFileAttachment> attachments);
        void RemoveAttachment(int id);

        int GetInboxMessageCount();

        IEnumerable<InboxMailMessageInfo> GetAllInboxMessages();

        StandardMailMessage GetInboxMessageById(string uuid);
    }
}
