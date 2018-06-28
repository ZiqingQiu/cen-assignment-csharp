using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq1
{
    class Person
    {
        public string Name { get; set; }
        public double Asset { get; set; }
        public bool IsFemale { get; set; }
        public string Country { get; set; }
        public int Age { get; set; }
        public override string ToString()
        {
            return string.Format("{0} {1}B {2} {3} {4}yrs", Name, Asset, IsFemale ? "F" : "M", Country, Age);
        }

    }
}
