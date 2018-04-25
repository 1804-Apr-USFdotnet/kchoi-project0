using Newtonsoft.Json;

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
        const string testRestaurantJSON = "{\"ID\":80,\"Address\":\"8616 Cardinal Alley\",\"Phone\":\"203-677-5272\",\"City\":\"New Haven\",\"State\":\"CT\",\"Zip\":\"06510\",\"Name\":\"Krajcik Inc\",\"Reviews\":[{\"ReviewerName\":\"Nappie Colegrove\",\"Rating\":1,\"Description\":\"This is a fake review.\"}]}";

        [TestMethod]
        public void TestDeserializeRestaurants()
        {
            string filePath = ConfigurationManager.AppSettings["DataDirectory"] + ConfigurationManager.AppSettings["RestaurantsFile"];
            Restaurant expectedRestaurant = JsonConvert.DeserializeObject<Restaurant>(testRestaurantJSON);

            List<Restaurant> list = Serializer.DeserializeList<Restaurant>(filePath);

            Assert.IsTrue(list[0].Equals(expectedRestaurant));
        }

        [TestMethod]
        public void TestSerializeRestaurant()
        {
            string filePath = ConfigurationManager.AppSettings["DataDirectory"] + ConfigurationManager.AppSettings["RestaurantsFile"];
            Restaurant expectedRestaurant = JsonConvert.DeserializeObject<Restaurant>(testRestaurantJSON);

            Serializer.SerializeAndWrite<Restaurant>(filePath, testRestaurant, true);

            Restaurant verifyRestaurant;
            using (System.IO.StreamReader reader = new System.IO.StreamReader(filePath))
            {
                verifyRestaurant = JsonConvert.DeserializeObject<Restaurant>(reader.ReadLine());
            }
            Assert.IsTrue(verifyRestaurant.Equals(testRestaurant));
        }
    }
}
