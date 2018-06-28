using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq1
{
    class Program
    {
        static List<Person> persons = new List<Person>()
        {
          new Person(){ Age = 72, Asset = 7.0, Country="South Africa", IsFemale=false, Name="Nicky Oppenheimer"},
          new Person(){ Age = 67, Asset = 7.6, Country="India", IsFemale=true, Name="Savitri Jindal"},
          new Person(){ Age = 81, Asset = 3.1, Country="India", IsFemale=true, Name="Indu Jain"},
          new Person(){ Age = 70, Asset = 2.5, Country="India", IsFemale=true, Name="Vinod Gupta"},
          new Person(){ Age = 77, Asset = 27.0, Country = "US",IsFemale = true,Name = "Jacqueline Mars"},
          new Person(){ Age = 76, Asset = 25.2, Country = "Italy", IsFemale = true, Name = "Maria Franca Fissolo"},
          new Person(){ Age = 55, Asset = 20.4, Country = "Germany", IsFemale = true, Name = "Susanne Klatten"},
          new Person(){ Age = 53, Asset = 20.0, Country = "US",IsFemale = true,Name = "Laurene Jobs"},
          new Person(){ Age = 60, Asset = 12.5, Country = "Nigeria", IsFemale=false, Name="Aliko Dangote" },
          new Person(){ Age = 76, Asset = 10.9, Country = "Ethiopia", IsFemale=false, Name="Mohammed Al Amoudi"},
          new Person(){ Age = 60, Asset = 30.7, Country = "Canada", IsFemale=false, Name="David Thomson" },
          new Person(){ Age = 76, Asset = 11.4, Country = "Canada", IsFemale=false, Name="Galen Weston"},
          new Person(){ Age = 60, Asset = 22.3, Country = "India", IsFemale=false, Name="Mukesh Ambani"},
          new Person(){ Age = 50, Asset = 17.5, Country = "India", IsFemale=false, Name="Dilip Shanghvi"},
          new Person(){ Age = 83, Asset = 30.4, Country = "US", IsFemale=false, Name="Sheldon Adelson"},
          new Person(){ Age = 78, Asset = 30.0, Country = "Brazil", IsFemale=false, Name="Jorge Lemann"},
          new Person(){ Age = 62, Asset = 18.4, Country = "Russia", IsFemale=false, Name="Leonid Mikhelson"},
          new Person(){ Age = 51, Asset = 17.5, Country = "Russia", IsFemale=false, Name="Alexey Mordashov"},
          new Person(){ Age = 89, Asset = 31.2, Country = "Hong Kong", IsFemale=false, Name="Li Ka-shing"},
          new Person(){ Age = 62, Asset = 31.2, Country = "China", IsFemale=false, Name="Wang Jianlin"},
          new Person(){ Age = 67, Asset = 33.8, Country = "US", IsFemale=true, Name="Alice Walton" },
          new Person(){ Age = 60, Asset = 34.0, Country = "US", IsFemale=false, Name="Jim Walton"},
          new Person(){ Age = 72, Asset = 34.1, Country = "US", IsFemale=false, Name="Rob Walton"},
          new Person(){ Age = 94, Asset = 39.5, Country = "France", IsFemale=true, Name="Liliane Bettencourt"},
          new Person(){ Age = 43, Asset = 39.8, Country = "US", IsFemale=false, Name="Sergey Brin"},
          new Person(){ Age = 43, Asset = 39.6, Country = "US", IsFemale=false, Name="Larry Page"},
          new Person(){ Age = 68, Asset = 41.5, Country = "France", IsFemale=false, Name="Bernard Arnault"},
          new Person(){ Age = 75, Asset = 47.5, Country = "US", IsFemale=false, Name="Michael Bloomberg"},
          new Person(){ Age = 77, Asset = 48.3, Country = "US", IsFemale=false, Name="David Koch"},
          new Person(){ Age = 81, Asset = 48.3, Country = "US", IsFemale=false, Name="Charles Koch"},
          new Person(){ Age = 72, Asset = 52.2, Country = "US", IsFemale=false, Name="Larry Ellison"},
          new Person(){ Age = 77, Asset = 54.5, Country = "Mexico", IsFemale=false, Name="Carlos Slim Helu"},
          new Person(){ Age = 33, Asset = 56.0, Country = "US", IsFemale=false, Name="Mark Zuckerberg"},
          new Person(){ Age = 81, Asset = 71.3, Country = "Spain", IsFemale=false, Name="Amancio Ortega"},
          new Person(){ Age = 53, Asset = 72.8, Country = "US", IsFemale=false, Name="Jeff Bezos" },
          new Person(){ Age = 85, Asset = 75.6, Country = "US", IsFemale=false, Name="Warren Buffet" },
          new Person(){ Age = 60, Asset = 86.0, Country = "US", IsFemale=false, Name="Bill Gates"}
        };
        static void Main(string[] args)
        {
            Linq1();
            Linq2();
            Linq3();
            Linq4();
            Linq5();
            Linq6();
            Linq7();
            Linq8();
            Linq9();

            Console.WriteLine("Finished");
        }


        static void Linq1()
        {
            var r = from p in persons
                    where p.Asset > 50
                    select p;
            Console.WriteLine("*************Q1***************");
            foreach (var i in r)
            {
                Console.WriteLine(i);
            }
        }


        static void Linq2()
        {
            var r = from p in persons
                    where p.Country != "US"
                    select p;
            Console.WriteLine("*************Q2***************");
            foreach (var i in r)
            {
                Console.WriteLine(i);
            }
        }


        static void Linq3()
        {
            var r = from p in persons
                    where (p.Country == "India" && p.IsFemale)
                    select p.Name;
            Console.WriteLine("*************Q3***************");
            foreach (var i in r)
            {
                Console.WriteLine(i);
            }
        }


        static void Linq4()
        {
            var r = from p in persons
                    where (p.Name.Split(' ')[0].Length < 5)
                    select p.Name;
            Console.WriteLine("*************Q4***************");
            foreach (var i in r)
            {
                Console.WriteLine(i);
            }
        }

        static void Linq5()
        {
            var r = from p in persons
                    orderby p.Asset
                    select p.Name + " " + p.Asset;
            Console.WriteLine("*************Q5***************");
            foreach (var i in r)
            {
                Console.WriteLine(i);
            }
        }

        static void Linq6()
        {
            var r = from p in persons
                    group p by p.Country into country_groups
                    select country_groups;
            Console.WriteLine("*************Q6***************");
            foreach (var country_groups in r)
            {
                Console.WriteLine(country_groups.Key);
                foreach (var grp in country_groups)
                {
                    Console.WriteLine(grp);
                }
            }
        }

        static void Linq7()
        {
            var r = from p in persons
                    orderby p.Country
                    group p by p.Country into country_groups                   
                    select country_groups;
            Console.WriteLine("*************Q7***************");
            foreach (var country_groups in r)
            {
                Console.WriteLine(country_groups.Key);
                foreach (var grp in country_groups)
                {
                    Console.WriteLine(grp);
                }
            }
        }

        static void Linq8()
        {
            var r = from p in persons
                    where p.Age > 50
                    orderby p.Country
                    group p by p.Country into country_groups
                    select country_groups;
            Console.WriteLine("*************Q8***************");
            foreach (var country_groups in r)
            {
                Console.WriteLine(country_groups.Key);
                foreach (var grp in country_groups)
                {
                    Console.WriteLine(grp);
                }
            }
        }

        static void Linq9()
        {
            var r = from p in persons
                    where (p.Asset > 50 && p.Age > 50) 
                    select p;
            Console.WriteLine("*************Q9***************");
            foreach (var i in r)
            {
                Console.WriteLine(i);
            }
        }
    }
}
