using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Models
{
    public class Order
    {
        public int Id { get; set; }
        public User User { get; set; }
        public int ProductId { get; set; }
        public DateTime DeliveryDateTime { get; set; }
    }
}
