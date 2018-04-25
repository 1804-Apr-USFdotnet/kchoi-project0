﻿using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LibraryProject.Interfaces;

namespace LibraryProject
{
    public class Restaurant : IReviewable
    {
        private int _id;
        private string _address;
        private string _phone;
        private string _city;
        private string _state;
        private string _zip;
        private string _name;

        private List<Review> _reviews = new List<Review>();

        private float _avgRating;

        public int ID { get => _id; set => _id = value; }
        public string Address { get => _address; set => _address = value; }
        public string Phone { get => _phone; set => _phone = value; }
        public string City { get => _city; set => _city = value; }
        public string State { get => _state; set => _state = value; }
        public string Zip { get => _zip; set => _zip = value; }
        public string Name { get => _name; set => _name = value; }

        public List<Review> Reviews { get => _reviews; set => _reviews = value; }

        [JsonIgnore]
        public float AvgRating { get => _avgRating; }

        public bool AddReview(Review NewReview)
        {
            bool result;
            int count = Reviews.Count;

            Reviews.Add(NewReview);

            if ((result = Reviews.Count == count + 1))
            {
                _avgRating *= count;
                _avgRating += NewReview.Rating;
                _avgRating /= (count + 1);
            }

            return result;
        }

        public void RecalculateAvgRating()
        {
            _avgRating = 0f;

            foreach(Review review in Reviews)
            {
                _avgRating += review.Rating;
            }

            _avgRating /= Reviews.Count;
        }

        public bool Equals(Restaurant obj)
        {
            bool result = ID.Equals(obj.ID)
                && Address.Equals(obj.Address)
                && Phone.Equals(obj.Phone)
                && City.Equals(obj.City)
                && State.Equals(obj.State)
                && Zip.Equals(obj.Zip)
                && Name.Equals(obj.Name);

            if (result)
            {
                for (int i = 0; i < Reviews.Count; i++)
                {
                    if (obj.Reviews[i] != null)
                    {
                        if (!Reviews[i].Equals(obj.Reviews[i]))
                        {
                            result = false;
                            break;
                        }
                    }
                    else
                    {
                        result = false;
                        break;
                    }
                }
            }

            return result;
        }
    }
}
