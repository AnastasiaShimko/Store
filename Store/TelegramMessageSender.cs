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
        public string Send(Order order)
        {
            return $"Telegram message was sent to: {order.User.PhoneNumber}";
        }

    }
}
