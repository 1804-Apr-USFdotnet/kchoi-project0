using System;
using System.Collections.Generic;
using System.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using LibraryProject;

namespace Project0Test
{
    [TestClass]
    public class SerializeTest
    {
        [TestMethod]
        public void TestDeserializeRestaurants()
        {
            string filePath = ConfigurationManager.AppSettings["DataDirectory"] + ConfigurationManager.AppSettings["RestaurantsFile"];
            List<Restaurant> list = Serializer.Deserialize<Restaurant>(filePath);
            Assert.IsTrue(list.Count > 0);
        }

        [TestMethod]
        public void TestDeserializeReviews()
        {
            string filePath = ConfigurationManager.AppSettings["DataDirectory"] + ConfigurationManager.AppSettings["ReviewsFile"];
            List<Review> list = Serializer.Deserialize<Review>(filePath);
            Assert.IsTrue(list.Count > 0);
        }

        [TestMethod]
        public void TestSerializeRestaurants()
        {
            Assert.Fail();
        }

        [TestMethod]
        public void TestSerializeReviews()
        {
            Assert.Fail();
        }
    }
}
