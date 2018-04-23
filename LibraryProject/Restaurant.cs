using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LibraryProject.Interfaces;

namespace LibraryProject
{
    public class Restaurant : ITaggable, IReviewable
    {
        private int _id;
        private string _address;
        private string _phone;
        private string _city;
        private string _state;
        private string _zip;
        private string _name;

        private List<Review> _reviews;
        private List<string> _tags;

        public int ID { get => _id; private set => _id = value; }
        public string Address { get => _address; private set => _address = value; }
        public string Phone { get => _phone; private set => _phone = value; }
        public string City { get => _city; private set => _city = value; }
        public string State { get => _state; private set => _state = value; }
        public string Zip { get => _zip; private set => _zip = value; }
        public string Name { get => _name; private set => _name = value; }

        public List<Review> Reviews { get => _reviews; private set => _reviews = value; }
        public List<string> Tags { get => _tags; private set => _tags = value; }

        public Restaurant(int id, string address, string phone, string city, string state, string zip, string name)
        {
            ID = id;
            Address = address;
            Phone = phone;
            _city = city;
            State = state;
            Zip = zip;
            Name = name;
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
