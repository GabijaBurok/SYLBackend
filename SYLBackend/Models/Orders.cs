using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SYLBackend.Models
{
    public class Orders
    {
        public string orderId { get; set; }
        public string productId { get; set; }
        public string customerId { get; set; }
        public float quantity { get; set; }
        public TimeSpan timeStamp { get; set; }

    }
}
