using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using DataProject;

namespace Project0Test
{
    [TestClass]
    public class RestaurantTest
    {
        [TestMethod]
        public void TestRestaurantAddress()
        {
            Restaurant res = new Restaurant();
            string address = "1600 Pennsylvania Ave";
            res.Address = address;
            Assert.AreEqual(res.Address, address);
        }

        [TestMethod]
        public void TestRestaurantCity()
        {
            Restaurant res = new Restaurant();
            string city = "Washington";
            res.City = city;
            Assert.AreEqual(city, res.City);
        }

        [TestMethod]
        public void TestRestaurantState()
        {
            Restaurant res = new Restaurant();
            string state = "DC";
            res.State = state;
            Assert.AreEqual(res.State, state);
        }

        [TestMethod]
        public void TestRestaurantZIP()
        {
            Restaurant res = new Restaurant();
            long zip = 20500;
            res.ZIP = zip;
            Assert.AreEqual(zip, res.ZIP);
        }

        [TestMethod]
        public void TestRestaurantReviews()
        {
            Restaurant res = new Restaurant
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
            Restaurant res = new Restaurant();
            string phoneNum = "555-555-5555";
            res.PhoneNum = phoneNum;
            Assert.AreEqual(phoneNum, res.PhoneNum);
        }
    }
}
