using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject
{
    public class Review
    {
        public int Rating {
            get
            {
                return Rating;
            }
            set
            {
                if (value < 0)
                {
                    Rating = 0;
                }
                else if (value > 5)
                {
                    Rating = 5;
                }
                else
                {
                    Rating = value;
                }
            }
        }
        public string Description { get; set; }
    }
}
