using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SYLBackend.DTO.ProductDTO
{
    public class NewProductDTO
    {
        public string shopId { get; set; }
        public string productName { get; set; }
        public float productPrice { get; set; }
        public int productType { get; set; }
        public Base64FormattingOptions productPicture { get; set; }
    }
}
