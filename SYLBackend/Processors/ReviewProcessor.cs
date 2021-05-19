using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SYLBackend.Context;
using SYLBackend.DTO.ReviewDTO;
using SYLBackend.Interfaces;
using SYLBackend.Models;

namespace SYLBackend.Processors
{
    public class ReviewProcessor : IReviewProcessor
    {
        private readonly SYLContext context;
        private readonly ShopProcessor _shopProcessor;
        public ReviewProcessor(SYLContext context)
        {
            this.context = context;
        }
        public Task<bool> AddNewReview(NewReviewDTO data) => Task.Run(() =>
        {
            Reviews review = new Reviews
            {
                reviewId = Guid.NewGuid().ToString(),
                customerId = data.customerId,
                customerName = data.customerName,
                shopId = data.shopId,
                reviewRating = data.reviewRating,
                reviewComment = data.reviewComment
            };
            try
            {
                context.Reviews.Add(review);
                context.SaveChanges();
            }
            catch (DbUpdateException)
            {
                return false;
            }
            return true;
        });

        public Task<bool> DeleteReview(ReviewIdDTO data)
        {
            throw new NotImplementedException();
        }

        public Task<Reviews> GetAllReviews()
        {
            throw new NotImplementedException();
        }

        public async Task<double> GetAvgRating(string shopName)
        {
            List<int> ratings = new List<int>();
            Shops shop = await _shopProcessor.GetShopsBySeller(shopName);
            var reviews = await Task.Run(() => context.Reviews.Where(a => a.shopId == shop.shopId).ToList());

            double rating = (from a in reviews select a.reviewRating).Average();
            return rating;
        }

        public Task<Reviews> GetReviews()
        {
            throw new NotImplementedException();
        }

        public async Task<List<GetReviewByShopDTO>> GetReviewsByShop(string shopName)
        {
            List<GetReviewByShopDTO> reviewlist = new List<GetReviewByShopDTO>();
            Shops shop = await _shopProcessor.GetShopsBySeller(shopName);
            var reviews = await Task.Run(() => context.Reviews.Where(a => a.shopId == shop.shopId).ToList());
            foreach(var review in reviews)
            {
                reviewlist.Add(new GetReviewByShopDTO { customerName = review.customerName, shopName = shopName, reviewRating = review.reviewRating, reviewComment = review.reviewComment });
            }
            return reviewlist;
        }
    }
}
