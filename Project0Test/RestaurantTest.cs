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
        Review rev;
        const int id = 0;
        const string address = "1600 Pennsylvania Ave";
        const string city = "Washington";
        const string state = "DC";
        const string zip = "20500";
        const string phoneNum = "555-555-5555";
        const string name = "White House";
        const int rating = 5;
        const string desc = "this is a fake review";

        [TestMethod]
        public void TestRestaurantID()
        {
            res = new Restaurant(id, address, phoneNum, city, state, zip, name);
            Assert.AreEqual(res.ID, id);
        }

        [TestMethod]
        public void TestRestaurantAddress()
        {
            res = new Restaurant(id, address, phoneNum, city, state, zip, name);
            Assert.AreEqual(res.Address, address);
        }

        [TestMethod]
        public void TestRestaurantCity()
        {
            res = new Restaurant(id, address, phoneNum, city, state, zip, name);
            Assert.AreEqual(city, res.City);
        }

        [TestMethod]
        public void TestRestaurantState()
        {
            res = new Restaurant(id, address, phoneNum, city, state, zip, name);
            Assert.AreEqual(res.State, state);
        }

        [TestMethod]
        public void TestRestaurantZIP()
        {
            res = new Restaurant(id, address, phoneNum, city, state, zip, name);
            Assert.AreEqual(zip, res.Zip);
        }

        [TestMethod]
        public void TestRestaurantReviews()
        {
            res = new Restaurant(id, address, phoneNum, city, state, zip, name);
            int rating = 5;
            rev = new Review(rating, desc);

            res.Reviews.Add(rev);

            Assert.IsTrue(res.Reviews.Count == 1 && res.Reviews[0].Rating == rating);
        }

        [TestMethod]
        public void TestRestaurantPhoneNum()
        {
            res = new Restaurant(id, address, phoneNum, city, state, zip, name);
            Assert.AreEqual(phoneNum, res.Phone);
        }

        [TestMethod]
        public void TestRestaurantAddReview()
        {
            res = new Restaurant(id, address, phoneNum, city, state, zip, name);
            rev = new Review(rating, desc);
            if (!res.AddReview(rev))
            {
                Assert.Fail("failed to add review");
            } else
            {
                Assert.AreEqual(rev, res.Reviews[0]);
            }
        }

        [TestMethod]
        public void TestRestaurantAvgReview()
        {
            res = new Restaurant(id, address, phoneNum, city, state, zip, name);
            float avg = 0f;
            for(int i = 1; i <= 5; i++)
            {
                rev = new Review(rating, desc);
                res.AddReview(rev);
                avg += i;
            }
            avg /= 5f;
            Assert.AreEqual(avg, res.GetAvgRating());
        }
    }
}
