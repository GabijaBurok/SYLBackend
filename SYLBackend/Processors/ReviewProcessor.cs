using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SYLBackend.DTO.ReviewDTO;
using SYLBackend.Interfaces;
using SYLBackend.Models;

namespace SYLBackend.Processors
{
    public class ReviewProcessor : IReviewProcessor
    {
        public Task<bool> AddNewReview(NewReviewDTO data)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteReview(ReviewIdDTO data)
        {
            throw new NotImplementedException();
        }

        public Task<Reviews> GetAllReviews()
        {
            throw new NotImplementedException();
        }

        public Task<Reviews> GetRatings()
        {
            throw new NotImplementedException();
        }

        public Task<Reviews> GetReviews()
        {
            throw new NotImplementedException();
        }

        public Task<Reviews> GetReviewsByShop(GetReviewByShopDTO data)
        {
            throw new NotImplementedException();
        }
    }
}
