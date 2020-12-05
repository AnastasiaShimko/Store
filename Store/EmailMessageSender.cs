using Store.Interfaces;
using Store.Models;

namespace Store
{
    public class EmailMessageSender : IMessageSender
    {
        public string Send(Order order)
        {
            return $"E-mail was sent to: {order.User.EmailAddress}";
        }

    }
}
