﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LibraryProject.Interfaces;

namespace LibraryProject
{
    public class Restaurant : ITaggable, IReviewable
    {
        public int RestaurantID { get; set; }
        public string Address { get; set; }
        public List<Review> Reviews { get; set; }
        public string PhoneNum { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZIP { get; set; }
        public List<string> Tags { get; set; }
        public string Name { get; set; }

        public Restaurant()
        {
            Reviews = new List<Review>();
            Tags = new List<string>();
        }

        public bool AddReview(Review NewReview)
        {
            int count = Reviews.Count;
            Reviews.Add(NewReview);
            return Reviews.Count == count + 1;
        }

        public bool AddTag(string NewTag)
        {
            int count = Tags.Count;
            Tags.Add(NewTag);
            return Tags.Count == count + 1;
        }

        public float GetAvgRating()
        {
            float sum = 0f;

            foreach (var i in Reviews)
            {
                sum += i.Rating;
            }

            return sum / Reviews.Count;
        }
    }
}
