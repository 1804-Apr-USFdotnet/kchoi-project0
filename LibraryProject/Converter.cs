using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject
{
    public static class Converter
    {
        public static Restaurant ConvertRestaurantFromDB(DataProject.Restaurant dbRestaurant)
        {
            Restaurant result = new Restaurant
            {
                ID = dbRestaurant.ID,
                Address = dbRestaurant.Address,
                PhoneNum = dbRestaurant.PhoneNum,
                City = dbRestaurant.City,
                State = dbRestaurant.State,
                ZIP = dbRestaurant.ZIP,
                Name = dbRestaurant.Name,
                Reviews = new List<Review>()
            };
            ICollection<DataProject.Review> reviews = dbRestaurant.Reviews;
            foreach (DataProject.Review rev in reviews)
            {
                result.AddReview(ConvertReviewFromDB(rev));
            }

            return result;
        }

        public static DataProject.Restaurant ConvertRestaurantToDB(Restaurant restaurant)
        {
            DataProject.Restaurant result = new DataProject.Restaurant
            {
                ID = restaurant.ID,
                Address = restaurant.Address,
                PhoneNum = restaurant.PhoneNum,
                City = restaurant.City,
                State = restaurant.State,
                ZIP = restaurant.ZIP,
                Name = restaurant.Name,
                AvgRating = restaurant.AvgRating,
                Reviews = new List<DataProject.Review>()
            };
            foreach(Review rev in restaurant.Reviews)
            {
                result.Reviews.Add(ConvertReviewToDB(rev));
            }

            return result;
        }

        private static Review ConvertReviewFromDB(DataProject.Review dbReview)
        {
            Review result = new Review
            {
                Description = dbReview.Description,
                Rating = (int)dbReview.Rating,
                ReviewerID = (int)dbReview.ReviewerID,
                ID = dbReview.ID
            };

            return result;
        }

        private static DataProject.Review ConvertReviewToDB(Review review)
        {
            DataProject.Review result = new DataProject.Review
            {
                Description = review.Description.Substring(0,Math.Min(200,review.Description.Length)),
                Rating = review.Rating,
                ReviewerID = review.ReviewerID,
                ID = review.ID
            };

            return result;
        }
    }
}
