using NLog;

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LibraryProject;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            ///*          string filePath = ConfigurationManager.AppSettings["TestDataFile"];

            //            Console.WriteLine("reading from: " + filePath);
            //*/
            //            ICollection<DataProject.Restaurant> dbList = DataProject.RestaurantCRUD.ReadRestaurants();
            //            List<Restaurant> list = new List<Restaurant>();
            //            foreach(var i in dbList)
            //            {
            //                list.Add(Converter.ConvertRestaurantFromDB(i));
            //            }

            //            foreach(Restaurant rest in list)
            //            {
            //               // DataProject.RestaurantCRUD.CreateRestaurant(Converter.ConvertRestaurantToDB(rest));

            //                DataProject.RestaurantCRUD.UpdateRestaurant(Converter.ConvertRestaurantToDB(rest));

            //            }
            #endregion

            Logger log = LogManager.GetCurrentClassLogger();
            ICollection<Restaurant> list;
            int menuSelection, targetID;
            string name;
            Restaurant rest;

            while ((menuSelection = GetMenuSelection()) != 6)
            {
                try
                {
                    Console.WriteLine("-----------");

                    switch (menuSelection)
                    {
                        case 1:
                            list = Mapper.GetRestaurantsSortByRating(3);
                            Console.WriteLine("Restaurant Name: Average Rating");
                            foreach (Restaurant restaurant in list)
                            {
                                Console.WriteLine(restaurant.Name + ": " + restaurant.AvgRating);
                            }

                            break;
                        case 2:
                            list = Mapper.GetRestaurantsSortByName();
                            Console.WriteLine("Restaurant Name");
                            foreach (Restaurant restaurant in list)
                            {
                                Console.WriteLine(restaurant.Name);
                            }

                            break;
                        case 3:
                            Console.WriteLine("Enter the Restaurant ID: ");
                            targetID = int.Parse(Console.ReadLine());
                            rest = Mapper.FindRestaurantByID(targetID);
                            Console.WriteLine("Name: " + rest.Name);
                            Console.WriteLine("Average Rating: " + rest.AvgRating);
                            Console.WriteLine("Address: " + rest.Address);
                            Console.WriteLine("City: " + rest.City);
                            Console.WriteLine("State: " + rest.State);
                            Console.WriteLine("ZIP: " + rest.ZIP);
                            Console.WriteLine("Phone #: " + rest.PhoneNum);

                            break;
                        case 4:
                            Console.WriteLine("Enter the Restaurant ID: ");
                            targetID = int.Parse(Console.ReadLine());
                            ICollection<Review> revs = Mapper.FindReviewsByRestaurantID(targetID);
                            foreach (Review review in revs)
                            {
                                Console.WriteLine(review.Rating + " " + review.Description);
                            }

                            break;
                        case 5:
                            Console.WriteLine("Enter the Restaurant name: ");
                            name = Console.ReadLine();
                            list = Mapper.FindRestaurantsByName(name);
                            foreach (Restaurant rest1 in list)
                            {
                                Console.WriteLine(rest1.Name);
                            }

                            break;
                    }

                    Console.WriteLine();
                } catch(Exception e)
                {
                    log.Error(e, e.StackTrace);

                    Console.WriteLine("Unexpected error occurred! Please check the log file and try again.");
                }
            }
        }

        static int GetMenuSelection()
        {
            Console.WriteLine("Select an option:");
            Console.WriteLine("1. Display 3 top rated restaurants");
            Console.WriteLine("2. Display all Restaurants, sorted by name");
            Console.WriteLine("3. Display Restaurant details");
            Console.WriteLine("4. Display all Reviews of Restaurant");
            Console.WriteLine("5. Search for Restaurant by name");
            Console.WriteLine("6. Quit");

            return int.Parse(Console.ReadLine());
        }


    }
}
