using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZiqingQiu_Lab05_Ex04
{
    class Employee
    {
        //private instance variables
        private string _name;
        private double _salary;

        //public properties
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public double Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }

        //constructors
        public Employee(string name, double salary)
        {
            this.Name = name;
            this.Salary = salary;
        }

        //private methods

        //public methods
        public override string ToString()
        {
            return $"Name: {Name}, Salary:{Salary}";
        }
    }
}
