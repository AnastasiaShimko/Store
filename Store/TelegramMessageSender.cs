using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Store.Interfaces;
using Store.Models;

namespace Store
{
    public class TelegramMessageSender : IMessageSender
    {
        /// <summary>
        /// According to SRP, one class should take one responsibility.
        /// So we should write different class for sending another type of messages (Telegram message).
        /// </summary>
        public string Send(Order order)
        {
            return $"Telegram message was sent to: {order.User.PhoneNumber}";
        }

    }
}
