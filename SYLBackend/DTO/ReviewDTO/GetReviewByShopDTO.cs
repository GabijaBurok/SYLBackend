using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SYLBackend.DTO.ReviewDTO
{
    public class GetReviewByShopDTO
    {
        public string customerName { get; set; }
        public string shopName { get; set; }
        public int reviewRating { get; set; }
        public string reviewComment { get; set; }
    }
}
