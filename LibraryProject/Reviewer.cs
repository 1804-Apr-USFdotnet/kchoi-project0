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
        
        public string Name { get => _name; private set => _name = value; }
        public int ID { get => _id; private set => _id = value; }

        public Reviewer(int id, string name)
        {
            ID = id;
            Name = name;
        }
    }
}
