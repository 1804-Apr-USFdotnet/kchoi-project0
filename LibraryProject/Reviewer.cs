using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject
{
    public class Reviewer
    {
        private string _name;
        private int _id;

        public string Name { get => _name; set => _name = value; }
        public int ID { get => _id; set => _id = value; }

        public override bool Equals(object obj)
        {
            bool result = true;
            Reviewer testObj = null;

            try
            {
                testObj = (Reviewer)obj;
            } catch(InvalidCastException e)
            {
                result = false;
            }

            if (result)
            {
                result = Name.Equals(testObj.Name)
                    && ID.Equals(testObj.ID);
            }

            return result;
        }
    }
}
