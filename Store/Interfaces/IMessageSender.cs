using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Store.Models;

namespace Store.Interfaces
{
    interface IMessageSender
    {
        string Send(Order order);
    }
}
