using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SYLBackend.DTO.OrderDTO
{
    public class ModifyOrderDTO
    {
        public string productId { get; set; }
        public string customerId { get; set; }
        public float newQuantity { get; set; }
        public TimeSpan newTime { get; set; }

    }
}
