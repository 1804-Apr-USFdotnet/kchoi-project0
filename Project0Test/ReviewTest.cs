using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using LibraryProject;

namespace Project0Test
{
    [TestClass]
    public class ReviewTest
    {
        Review review;
        const string desc = "This review is a fake.";
        const int rating = 5;

        [TestMethod]
        public void TestReviewRating()
        {
            review = new Review
            {
                Rating = rating
            };
            Assert.AreEqual(review.Rating, rating);
        }

        [TestMethod]
        public void TestReviewDescription()
        {
            review = new Review
            {
                Description = desc
            };
            Assert.AreEqual(review.Description, desc);
        }
    }
}
