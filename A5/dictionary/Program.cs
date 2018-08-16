using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZiqingQiu_Lab05_Ex04
{
    class Program
    {
        private static int _key = 1;
        static void Main(string[] args)
        {
            SortedDictionary<int, Employee> employees = new SortedDictionary<int, Employee>();

            Employee[] empArray = new[] {
                new Employee("James", 1225.0),
                new Employee("Matt", 2300.3),
                new Employee("Fang", 4000.0),
                new Employee("LinHan", 9999.0),
                new Employee("Bill", 8888.0)
            };

            for (int i = 0; i < empArray.Length; i++)
            {
                AddDictionaryItem(employees, empArray[i]);
            }

            Console.WriteLine("\n*************\nAfter add all employees: " + "\n*************");
            PrintDictionary(employees);

            Console.WriteLine("\n*************\nAfter remove: " + empArray[4] + "\n*************");
            RemoveDictionaryItem(employees, empArray[4]);
            PrintDictionary(employees);


            Employee e = new Employee("Mayun", 2222.0);
            Console.WriteLine("\n*************\nAfter search invalid employee: " + e + "\n*************");
            int key = SearchDictionaryKeyByItem(employees, e);
            if (0 == key)
            {
                Console.WriteLine("employee does not exist");
            }
            else
            {
                Console.WriteLine("find correspoding key: " + key);
            }


            Console.WriteLine("\n*************\nThe highest salary of employees: " + "\n*************");
            Employee maxemp = MaxDictionaryItem(employees);
            Console.WriteLine("The employee is :" + maxemp);
        }

        //add one employee to the dictionary
        private static void AddDictionaryItem(SortedDictionary<int, Employee> empDict, Employee emp)
        {
            empDict.Add(_key++, emp);
        }

        //remove one employee from the dictionary
        private static void RemoveDictionaryItem(SortedDictionary<int, Employee> empDict, Employee emp)
        {
            if (empDict.ContainsValue(emp))
            {
                foreach (var item in empDict.Where(kvp => kvp.Value == emp).ToList())
                {
                    empDict.Remove(item.Key);
                }
            }
            else
            {
                Console.WriteLine(emp + "does NOT exit");
            }
        }

        //remove one item by its key
        private static void RemoveDictionaryItem(SortedDictionary<int, Employee> empDict, int key)
        {
            if (empDict.ContainsKey(key))
            {
                empDict.Remove(key);
                Console.WriteLine("Employee with key: " + key + "sucessfully deleted");
            }
            else
            {
                Console.WriteLine("Employee with key: " + key + "does NOT exit");
            }
        }

        //print the entire dictionary
        private static void PrintDictionary(SortedDictionary<int, Employee> empDict)
        {
            foreach (var key in empDict.Keys)
            {
                Console.WriteLine($" Key:{key} , Employee:{empDict[key]}");
            }
        }

        //search dictionary item by key
        private static Employee SearchDictionaryItemByKey(SortedDictionary<int, Employee> empDict, int key)
        {
            return empDict[key];
        }

        //search dictionary key by item
        private static int SearchDictionaryKeyByItem(SortedDictionary<int, Employee> empDict, Employee emp)
        {
            return empDict.FirstOrDefault(x => x.Value == emp).Key;
        }


        //find the employee who has the max salary
        private static Employee MaxDictionaryItem(SortedDictionary<int, Employee> empDict)
        {
            double maxSalary = 0;
            Employee maxemp = null;

            foreach (var emp in empDict.Values)
            {
                if (emp.Salary >= maxSalary)
                {
                    maxSalary = emp.Salary;
                    maxemp = emp;                }
            }

            return maxemp;
        }
    }
}
