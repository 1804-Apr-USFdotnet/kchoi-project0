using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject
{
    public class Restaurant
    {
        public string Address { get; set; }
        public List<Review> Reviews { get; set; }
        public string PhoneNum { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public long ZIP { get; set; }

        public Restaurant()
        {
            Reviews = new List<Review>();
        }

        public bool AddReview(Review NewReview)
        {
            int count = Reviews.Count;
            Reviews.Add(NewReview);
            return Reviews.Count == count + 1;
        }
    }
}
