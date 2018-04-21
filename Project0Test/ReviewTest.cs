using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using DataProject;

namespace Project0Test
{
    [TestClass]
    public class ReviewTest
    {
        [TestMethod]
        public void TestReviewRating()
        {
            Review review = new Review();
            review.Rating = 5;
            Assert.AreEqual(review.Rating, 5);
        }

        [TestMethod]
        public void TestReviewDescription()
        {
            Review review = new Review();
            string desc = "This review is a fake.";
            review.Description = desc;
            Assert.IsTrue(review.Description != null && review.Description.Equals(desc));
        }
    }
}
