using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SYLBackend.DTO.ProductDTO
{
    public class ModifyProductDTO
    {
        public string shopId { get; set; }
        public string newProductName { get; set; }
        public float newProductPrice { get; set; }
        public int newProductType { get; set; }
        public Base64FormattingOptions newProductPicture { get; set; }
    }
}
