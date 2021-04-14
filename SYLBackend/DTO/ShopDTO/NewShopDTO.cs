using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SYLBackend.DTO.ShopDTO
{
    public class NewShopDTO
    {
        public string sellerId { get; set; }
        public string shopName { get; set; }
        public string shopAddress { get; set; }
        public Base64FormattingOptions shopPicture { get; set; }
    }
}
