using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject
{
    public class Review
    {
        private string _reviewerName;
        private int _rating;
        private string _description;

        public string ReviewerName { get => _reviewerName; set => _reviewerName = value; }
        public int Rating
        {
            get
            {
                return _rating;
            }
            set
            {
                if (value < 0)
                {
                    _rating = 0;
                }
                else if (value > 5)
                {
                    _rating = 5;
                }
                else
                {
                    _rating = value;
                }
            }
        }
        public string Description { get => _description; set => _description = value; }

        public override bool Equals(object obj)
        {
            return GetHashCode() == obj.GetHashCode();
        }

        public override int GetHashCode()
        {
            var hashCode = 795980842;
            hashCode = hashCode * -1521134295 + ID.GetHashCode();
            hashCode = hashCode * -1521134295 + ReviewerID.GetHashCode();
            hashCode = hashCode * -1521134295 + Rating.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Description);
            return hashCode;
        }
    }
}
