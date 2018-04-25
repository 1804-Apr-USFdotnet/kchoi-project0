using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject
{
    public class Review
    {
        private int _rating;
        private string _description;

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
    }
}
