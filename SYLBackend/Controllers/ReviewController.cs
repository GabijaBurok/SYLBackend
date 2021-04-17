using Microsoft.AspNetCore.Mvc;
using SYLBackend.Interfaces;
using System;
using System.Threading.Tasks;
using SYLBackend.DTO.ReviewDTO;

namespace SYLBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewController
    {
        private readonly IReviewProcessor _reviewProcessor;

        public ReviewController(IReviewProcessor reviewProcessor)
        {
            _reviewProcessor = reviewProcessor;
        }

        [HttpPost]
        public Task<IActionResult> AddNewReview([FromBody] NewReviewDTO data)
        {
            throw new NotImplementedException();
        }

        [HttpDelete]
        public Task<IActionResult> DeleteReview ([FromBody] ReviewIdDTO data)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        public Task<IActionResult> GetReviews()
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        public Task<IActionResult> GetRatings()
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        public Task<IActionResult> GetReviewsByShop([FromBody] GetReviewByShopDTO data)
        {
            throw new NotImplementedException();
        }
    }
}
