using Microsoft.AspNetCore.Mvc;
using SYLBackend.DTO.ReviewDTO;
using SYLBackend.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SYLBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewController : ControllerBase
    {
        private readonly IReviewProcessor _reviewProcessor;

        public ReviewController(IReviewProcessor reviewProcessor)
        {
            _reviewProcessor = reviewProcessor;
        }

        [HttpPost]
        public async Task<IActionResult> AddNewReview([FromBody] NewReviewDTO data)
        {
            if (await Task.Run(() => _reviewProcessor.AddNewReview(data)))
                return Ok();
            else
                return BadRequest();

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
        public async Task<IActionResult> GetRating([FromBody] string shopName)
        {
                return Ok(await Task.Run(() => _reviewProcessor.GetAvgRating(shopName)));
        }

        [HttpGet]
        public async Task<IActionResult> GetReviewsByShop([FromBody] string shopName)
        {
            return Ok(await Task.Run(() => _reviewProcessor.GetReviewsByShop(shopName)));
        }
    }
}
