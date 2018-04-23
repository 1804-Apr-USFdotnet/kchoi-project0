using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using LibraryProject;

namespace Project0Test
{
    [TestClass]
    public class ReviewTest
    {
        Review rev;
        const string desc = "This review is a fake.";
        const int rating = 5;

        [TestMethod]
        public void TestReviewRating()
        {
            rev = new Review(rating, desc);
            Assert.AreEqual(rev.Rating, rating);
        }

        [TestMethod]
        public void TestReviewDescription()
        {
            rev = new Review(rating, desc);
            Assert.AreEqual(rev.Description, desc);
        }
    }
}
