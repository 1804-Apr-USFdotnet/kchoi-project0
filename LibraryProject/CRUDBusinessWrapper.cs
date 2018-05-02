using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DataProject;

namespace LibraryProject
{
    public static class CRUDBusinessWrapper
    {
        public static ICollection<Restaurant> ReadRestaurantsSortByRating(int count)
        {
            return Mapper.ConvertRestaurantListFromDB(RestaurantCRUD.ReadRestaurantsSortByRating(count));
        }

        public static ICollection<Restaurant> ReadRestaurants()
        {
            return Mapper.ConvertRestaurantListFromDB(RestaurantCRUD.ReadRestaurants());
        }

        public static ICollection<Restaurant> ReadRestaurantsSortByName()
        {
            return Mapper.ConvertRestaurantListFromDB(RestaurantCRUD.ReadRestaurantsSortByName());
        }

        public static Restaurant FindRestaurantByID(int targetID)
        {
            return Mapper.ConvertRestaurantFromDB(RestaurantCRUD.FindRestaurantByID(targetID));
        }

        public static ICollection<Review> FindReviewsByRestaurantID(int targetID)
        {
            return Mapper.ConvertReviewListFromDB(RestaurantCRUD.FindReviewsByRestaurantID(targetID));
        }

        public static ICollection<Restaurant> FindRestaurantsByName(string name)
        {
            return Mapper.ConvertRestaurantListFromDB(RestaurantCRUD.FindRestaurantsByName(name));
        }
    }
}
