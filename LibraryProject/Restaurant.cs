using Newtonsoft.Json;

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

        private float _avgRating;

        private List<Review> _reviews;

        public int ID { get => _id; set => _id = value; }
        public string Address { get => _address; set => _address = value; }
        public string Phone { get => _phone; set => _phone = value; }
        public string City { get => _city; set => _city = value; }
        public string State { get => _state; set => _state = value; }
        public string Zip { get => _zip; set => _zip = value; }
        public string Name { get => _name; set => _name = value; }

        public float AvgRating { get => _avgRating; }

        [JsonIgnore]
        public List<Review> Reviews { get => _reviews; private set => _reviews = value; }

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
    }
}
