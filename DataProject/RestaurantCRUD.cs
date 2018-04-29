using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataProject
{
    public static class RestaurantCRUD
    {
        private static RestaurantReviewsEntities db;

        public static void CreateRestaurant(Restaurant restaurant)
        {
            using (db = new RestaurantReviewsEntities())
            {
                db.Restaurants.Add(restaurant);

                try
                {
                    db.SaveChanges();
                }
                catch (System.Data.Entity.Validation.DbEntityValidationException e)
                {
                    foreach (var eve in e.EntityValidationErrors)
                    {
                        Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                           eve.Entry.Entity.GetType().Name, eve.Entry.State);

                        foreach (var ve in eve.ValidationErrors)
                        {
                            Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                                ve.PropertyName, ve.ErrorMessage);
                        }
                    }

                    Console.WriteLine(restaurant.Name);
                    throw;
                }
            }
        }

        public static ICollection<Restaurant> ReadRestaurants()
        {
            using (db = new RestaurantReviewsEntities())
            {
                ICollection<Restaurant> result = db.Restaurants.Include("Reviews").ToList();

                return result;
            }
        }

        public static void UpdateRestaurant(Restaurant newRestaurant)
        {
            using (db = new RestaurantReviewsEntities())
            {
                Restaurant oldRestaurant = db.Restaurants.Find(newRestaurant.ID);

                oldRestaurant.Address = newRestaurant.Address;
                oldRestaurant.AvgRating = newRestaurant.AvgRating;
                oldRestaurant.City = newRestaurant.City;
                oldRestaurant.ID = newRestaurant.ID;
                oldRestaurant.Name = newRestaurant.Name;
                oldRestaurant.PhoneNum = newRestaurant.PhoneNum;
                oldRestaurant.State = newRestaurant.State;
                oldRestaurant.ZIP = newRestaurant.ZIP;

                Review tmpReview = null;
                Review oldReview;
                int i = 0;
                while (i <  oldRestaurant.Reviews.Count)
                {//TODO: foreach iterator not modification safe
                    oldReview = oldRestaurant.Reviews.ElementAt(i);
                    tmpReview = newRestaurant.Reviews.Where(x => x.ID == oldReview.ID).FirstOrDefault();
                    if (tmpReview != null)
                    {
                        oldReview.Description = tmpReview.Description;
                        oldReview.Rating = tmpReview.Rating;
                        oldReview.ReviewerID = tmpReview.ReviewerID;
                        i++;
                    }
                    else
                    {
                        oldRestaurant.Reviews.Remove(oldReview);
                    }
                }

                foreach (Review newReview in newRestaurant.Reviews)
                {
                    tmpReview = oldRestaurant.Reviews.Where(x => x.ID == newReview.ID).FirstOrDefault();
                    if(tmpReview == null)
                    {
                        oldRestaurant.Reviews.Add(newReview);
                    }
                }
                
                try
                {
                    db.SaveChanges();
                }
                catch (System.Data.Entity.Validation.DbEntityValidationException e)
                {
                    foreach (var eve in e.EntityValidationErrors)
                    {
                        Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                           eve.Entry.Entity.GetType().Name, eve.Entry.State);

                        foreach (var ve in eve.ValidationErrors)
                        {
                            Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                                ve.PropertyName, ve.ErrorMessage);
                        }
                    }
                    throw;
                }
            }
        }

        public static bool DeleteRestaurant(Restaurant restaurant)
        {
            using (db = new RestaurantReviewsEntities())
            {
                int count = db.Restaurants.Count();

                db.Restaurants.Remove(restaurant);

                try
                {
                    db.SaveChanges();
                }
                catch (System.Data.Entity.Validation.DbEntityValidationException e)
                {
                    foreach (var eve in e.EntityValidationErrors)
                    {
                        Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                           eve.Entry.Entity.GetType().Name, eve.Entry.State);

                        foreach (var ve in eve.ValidationErrors)
                        {
                            Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                                ve.PropertyName, ve.ErrorMessage);
                        }
                    }
                    throw;
                }

                return count == db.Restaurants.Count() + 1;
            }
        }
    }
}
