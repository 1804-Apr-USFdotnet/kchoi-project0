using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using LibraryProject;

namespace Project0Test
{
    [TestClass]
    public class ReviewTest
    {
        [TestMethod]
        public void TestReviewRating()
        {
            Review review = new Review();
            int rating = 5;
            review.Rating = rating;
            Assert.AreEqual(review.Rating, rating);
        }

        [TestMethod]
        public void TestReviewDescription()
        {
            Review review = new Review();
            string desc = "This review is a fake.";
            review.Description = desc;
            Assert.AreEqual(review.Description, desc);
        }
    }
}
