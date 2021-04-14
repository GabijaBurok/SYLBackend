using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SYLBackend.DTO.OrderDTO
{
    public class GetCustomerOrdersDTO
    {
        public string productId { get; set; }
        public string customerId { get; set; }
        public float quantity { get; set; }
        public TimeSpan time { get; set; }
    }
}
