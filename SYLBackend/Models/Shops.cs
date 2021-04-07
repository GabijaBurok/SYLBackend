using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SYLBackend.Models
{
    public class Shops
    {
        public string shopId { get; set; }
        public string sellerId { get; set; }
        public string shopName { get; set; }
        public string shopAddress { get; set; }
        public string shopPicture { get; set; }   //dar gali keistis type
    }
}
