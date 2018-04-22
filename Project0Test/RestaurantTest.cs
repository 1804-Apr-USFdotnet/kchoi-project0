using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using LibraryProject;

namespace Project0Test
{
    [TestClass]
    public class RestaurantTest
    {
        Restaurant res;
        const string address = "1600 Pennsylvania Ave";
        const string city = "Washington";
        const string state = "DC";
        const string zip = "20500";
        const string phoneNum = "555-555-5555";

        [TestMethod]
        public void TestRestaurantAddress()
        {
            res = new Restaurant
            {
                Address = address
            };
            Assert.AreEqual(res.Address, address);
        }

        [TestMethod]
        public void TestRestaurantCity()
        {
            res = new Restaurant
            {
                City = city
            };
            Assert.AreEqual(city, res.City);
        }

        [TestMethod]
        public void TestRestaurantState()
        {
            res = new Restaurant
            {
                State = state
            };
            Assert.AreEqual(res.State, state);
        }

        [TestMethod]
        public void TestRestaurantZIP()
        {
            res = new Restaurant
            {
                ZIP = zip
            };
            Assert.AreEqual(zip, res.ZIP);
        }

        [TestMethod]
        public void TestRestaurantReviews()
        {
            res = new Restaurant
            {
                Reviews = new List<Review>()
            };
            int rating = 5;
            Review rev = new Review
            {
                Rating = rating,
                Description = "this is a fake description"
            };

            res.Reviews.Add(rev);

            Assert.IsTrue(res.Reviews.Count == 1 && res.Reviews[0].Rating == rating);
        }

        [TestMethod]
        public void TestRestaurantPhoneNum()
        {
            res = new Restaurant
            {
                PhoneNum = phoneNum
            };
            Assert.AreEqual(phoneNum, res.PhoneNum);
        }

        [TestMethod]
        public void TestRestaurantAddReview()
        {
            res = new Restaurant();
            Review rev = new Review();
            if (!res.AddReview(rev))
            {
                Assert.Fail("failed to add review");
            } else
            {
                Assert.AreEqual(rev, res.Reviews[0]);
            }
        }

        [TestMethod]
        public void TestRestaurantAddTag()
        {
            res = new Restaurant();
            string tag = "fake";
            if (!res.AddTag(tag))
            {
                Assert.Fail("failed to add tag");
            } else
            {
                Assert.AreEqual(tag, res.Tags[0]);
            }
        }

        [TestMethod]
        public void TestRestaurantAvgReview()
        {
            res = new Restaurant();
            float avg = 0f;
            for(int i = 1; i <= 5; i++)
            {
                Review rev = new Review
                {
                    Rating = i
                };
                res.AddReview(rev);
                avg += i;
            }
            avg /= 5f;
            Assert.AreEqual(avg, res.GetAvgRating());
        }
    }
}
