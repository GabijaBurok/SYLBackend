using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SYLBackend.DTO.ReviewDTO
{
    public class ReviewIdDTO
    {
        public string reviewId { get; set; }
        public string customerId { get; set; }
        public string shopId { get; set; }
        public int reviewRating { get; set; }
        public string reviewComment { get; set; }
    }
}
