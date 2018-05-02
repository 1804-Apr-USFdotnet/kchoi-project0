using System.Collections.Generic;

namespace LibraryProject
{
    public static class CRUDBusinessWrapper
    {
        public static ICollection<Restaurant> ReadRestaurantsSortByRating(int count)
        {
            return Mapper.GetRestaurantsSortByRating(count);
        }

        public static ICollection<Restaurant> ReadRestaurants()
        {
            return Mapper.GetRestaurants();
        }

        public static ICollection<Restaurant> ReadRestaurantsSortByName()
        {
            return Mapper.GetRestaurantsSortByName();
        }

        public static Restaurant FindRestaurantByID(int targetID)
        {
            return Mapper.FindRestaurantByID(targetID);
        }

        public static ICollection<Review> FindReviewsByRestaurantID(int targetID)
        {
            return Mapper.FindReviewsByRestaurantID(targetID);
        }

        public static ICollection<Restaurant> FindRestaurantsByName(string name)
        {
            return Mapper.FindRestaurantsByName(name);
        }
    }
}
