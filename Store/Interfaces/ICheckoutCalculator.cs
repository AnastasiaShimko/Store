using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Store.Models;

namespace Store.Interfaces
{
    /// <summary>
    /// ISP example.
    /// If we have calculator logic and message sending logic, we should make two interfaces for them.
    /// Even if one class will be using all methods of these interfaces it will implement both the interface.
    /// So Calculator doesn't have logic for MessageSender and any extra code.
    /// </summary>
    public interface ICheckoutCalculator
    {
        double GetProductsFullPrice(List<Product> products);
    }
}
