using Microsoft.EntityFrameworkCore;
using SYLBackend.Context;
using SYLBackend.DTO.ReviewDTO;
using SYLBackend.Models;
using SYLBackend.Processors;
using System;
using Xunit;

namespace SYLBackend.Tests
{
    public class ReviewUnitTests //: IDisposable
    {
        #region SetUp
        private readonly SYLContext context;

        public ReviewUnitTests()
        {
            var options = new DbContextOptionsBuilder<SYLContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;

             context = new SYLContext(options);
            //context.Database.EnsureCreated();

            Seed(context);
        }

        private void Seed(SYLContext context)
        {
            var users = new[]
            {
                new Users {
                    userEmail="Test1@test.test",
                    userId="TestUser-1",
                    userLastName="Test",
                    userName="Test",
                    userPassword="Test",
                    userType=1
                },
                new Users {
                    userEmail="Test2@test.test",
                    userId="TestUser-2",
                    userLastName="Test",
                    userName="Test",
                    userPassword="Test",
                    userType=0
                }
            };
            context.Users.AddRange(users);
            context.SaveChanges();

            var shops = new[]
            {
                new Shops
                {
                    shopAddress="Test str. 1",
                    sellerId="TestUser-2",
                    shopId="TestShop-1",
                    shopName="Test1"
                },
                new Shops
                {
                    shopAddress="Test str. 2",
                    sellerId="TestUser-2",
                    shopId="TestShop-2",
                    shopName="Test2"
                }
            };
            context.Shops.AddRange(shops);
            context.SaveChanges();

            var reviews = new[]
            {
                new Reviews
                {
                    reviewComment="TestComment -1",
                    reviewId="Review-1",
                    reviewRating=1,
                    customerId="TestUser-1",
                    shopId="TestShop-1",
                    customerName="Test"
                },
                new Reviews
                {
                    reviewComment="TestComment -2",
                    reviewId="Review-2",
                    reviewRating=3,
                    customerId="TestUser-1",
                    shopId="TestShop-2",
                    customerName="Test"
                },
                new Reviews
                {
                    reviewComment="TestComment -3",
                    reviewId="Review-3",
                    reviewRating=5,
                    customerId="TestUser-2",
                    shopId="TestShop-2",
                    customerName="Test"
                }
            };
            context.Reviews.AddRange(reviews);
            context.SaveChanges();
        }
        #endregion
        #region Tests
        [Fact]
        public void AddReview_ValidData_Success()
        {
            var processor = new ReviewProcessor(context);

            var review = new NewReviewDTO
            {
                customerId = "TestUser-1",
                customerName = "Test",
                shopId = "TestShop-1",
                reviewRating = 2,
                reviewComment = Guid.NewGuid().ToString()
            };
            var result = processor.AddNewReview(review).Result;

            Assert.True(result);
        }

        [Fact]
        public void AddReview_NotValidCustomerId_Fails()
        {
            var processor = new ReviewProcessor(context);

            var review = new NewReviewDTO
            {
                customerId = "NOT VALID",
                customerName = "Test",
                shopId = "TestShop-1",
                reviewRating = 2,
                reviewComment = Guid.NewGuid().ToString()
            };
            var result = processor.AddNewReview(review).Result;

            Assert.False(result);
        }

        [Fact]
        public void AddReview_NotValidShopId_Fails()
        {
            var processor = new ReviewProcessor(context);

            var review = new NewReviewDTO
            {
                customerId = "TestUser-1",
                customerName = "Test",
                shopId = "NOT VALID",
                reviewRating = 2,
                reviewComment = Guid.NewGuid().ToString()
            };
            var result = processor.AddNewReview(review).Result;

            Assert.False(result);
        }

        [Fact]
        public void AddReview_NotValidRating_Fails()
        {
            var processor = new ReviewProcessor(context);

            var review = new NewReviewDTO
            {
                customerId = "TestUser-1",
                customerName = "Test",
                shopId = "TestShop-1",
                reviewRating = 100,
                reviewComment = Guid.NewGuid().ToString()
            };
            var result = processor.AddNewReview(review).Result;

            Assert.False(result);
        }

        [Fact]
        public void AddReview_NotValidComment_Fails()
        {
            var processor = new ReviewProcessor(context);

            var review = new NewReviewDTO
            {
                customerId = "TestUser-1",
                customerName = "Test",
                shopId = "TestShop-1",
                reviewRating = 2,
                reviewComment = ""
            };
            var result = processor.AddNewReview(review).Result;

            Assert.False(result);
        }
/*
        [Fact]
        public void GetReviewsByShop_ValidShopName_Succeeds()
        {
            var processor = new ReviewProcessor(context);

            var result = processor.GetReviewsByShop("TestShop-2").Result;

            Assert.Equal(2, result.Count);
        }*/
        #endregion
    }
}
