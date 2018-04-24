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
            int numEntries = 0;
            using(System.IO.StreamReader reader = new System.IO.StreamReader(filePath))
            {
                while(!reader.EndOfStream)
                {
                    reader.ReadLine();
                    numEntries++;
                }
            }

            List<Restaurant> list = Serializer.DeserializeList<Restaurant>(filePath);

            Assert.AreEqual(list.Count, numEntries);
        }

        [TestMethod]
        public void TestDeserializeReviews()
        {
            string filePath = ConfigurationManager.AppSettings["DataDirectory"] + ConfigurationManager.AppSettings["ReviewsFile"];
            int numEntries = 0;
            using (System.IO.StreamReader reader = new System.IO.StreamReader(filePath))
            {
                while (!reader.EndOfStream)
                {
                    reader.ReadLine();
                    numEntries++;
                }
            }

            List<Review> list = Serializer.DeserializeList<Review>(filePath);

            Assert.AreEqual(list.Count, numEntries);
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
