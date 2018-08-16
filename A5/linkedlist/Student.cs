using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZiqingQiu_Lab05_Ex03
{
    class Student
    {
        //private instance variables
        private string _id;
        private string _name;

        //public properties
        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        //constructors
        public Student(string id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        //private methods

        //public methods
        public override string ToString()
        {
            return $"Id: {Id}, Name:{Name}";
        }
    }
}
