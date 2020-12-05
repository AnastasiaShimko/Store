using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Store.Models;

namespace Store
{
    public static class SampleData
    {
        /// <summary>
        /// LSP example.
        /// Child class should not break parent class’s type definition and behavior.
        /// Here we can see that Product class is replaceable with objects of its subclasses (Phone) without breaking the application.
        /// </summary>
        /// <param name="context"></param>
        public static void Initialize(StoreContext context)
        {
            if (!context.Products.Any())
            {
                var phoneClassObj = new Phone
                {
                    Name = "iPhone X",
                    Company = "Apple",
                    Price = 600
                };
                var productClassObj = new Product
                {
                    Name = "Huawei P20 Lite",
                    Company = "Huawei ltd.",
                    Price = 200
                };
                context.Products.AddRange(
                    phoneClassObj,
                    productClassObj
                );
                context.SaveChanges();
            }
        }
    }
}
