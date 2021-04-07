﻿using SYLBackend.Models;
using SYLBackend.DTO.ReviewDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SYLBackend.Interfaces
{
    interface IReviewProcessor
    {
        Task<bool> AddNewReview(NewReviewDTO data);
        Task<bool> DeleteReview(ReviewIdDTO data);
        Task<Reviews> GetAllReviews();
        Task<Reviews> GetRatings();
        Task<Reviews> GetReviewsByShop(GetReviewByShopDTO data);
    }
}
