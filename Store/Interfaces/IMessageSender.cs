using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Store.Models;

namespace Store.Interfaces
{
    /// <summary>
    /// OCP Example.
    /// If we want to make one more message sender, then we will inherit from IMessageSender.
    /// IMessageSender is open for extension but closed for modification.
    /// </summary>
    public interface IMessageSender
    {
        string Send(Order order);
    }
}
