using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_1.Day_5
{
    abstract class Person 
    {
        string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value.Equals(null) ? "No Name" : value; }
        }
        public Person(string name)
        {
            Name = name;
        }
        public abstract string GetInfo();

    }
}
