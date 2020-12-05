using Store.Interfaces;
using Store.Models;

namespace Store
{
    public class EmailMessageSender : IMessageSender
    {
        /// <summary>
        /// According to SRP, one class should take one responsibility.
        /// So we should write different class for sending another type of messages (E-mail message).
        /// </summary>
        public string Send(Order order)
        {
            return $"E-mail was sent to: {order.User.EmailAddress}";
        }

    }
}
