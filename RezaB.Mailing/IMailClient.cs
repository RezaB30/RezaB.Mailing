using System;
using System.Collections.Generic;
using System.Text;

namespace RezaB.Mailing
{
    /// <summary>
    /// Represents a mail client from this library.
    /// </summary>
    public interface IMailClient
    {
        /// <summary>
        /// Sends an email message.
        /// </summary>
        /// <param name="sendingMessage">The email message to send.</param>
        void SendMail(StandardMailMessage sendingMessage);
        /// <summary>
        /// Gets the count of messages in the mail inbox.
        /// </summary>
        /// <returns></returns>
        int GetInboxMessageCount();
        /// <summary>
        /// Gets a brief summary of all the messages in the inbox.
        /// </summary>
        /// <returns></returns>
        IEnumerable<InboxMailMessageInfo> GetAllInboxMessages();
        /// <summary>
        /// Retreives a mail message from server.
        /// </summary>
        /// <param name="uuid">The message unique id.</param>
        /// <returns></returns>
        StandardMailMessage GetInboxMessageById(string uuid);
    }
}
