using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SYLBackend.Models
{
    public class Products
    {
        public string productId { get; set; }
        public string shopId { get; set; }
        public string productName { get; set; }
        public float productPrice { get; set; }
        public int productType { get; set; }
        public string productPicture { get; set; } //dar gal keisis
    }
}
