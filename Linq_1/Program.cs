using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq1
{
    class Program
    {
        //person
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

        //fruits
        static List<Fruit> fruits = new List<Fruit>()
        {
            new Fruit(){ Name="Mango", Origin="Guyana", Price=5.67},
            new Fruit(){ Name="Kiwi", Origin="New Zeeland", Price=1.34},
            new Fruit(){ Name="Dragon Fruit", Origin="China", Price=3.45},
            new Fruit(){ Name="Avacado", Origin="Mexico", Price=2.56},
            new Fruit(){ Name="Banana", Origin="Ecuador", Price=0.25},
            new Fruit(){ Name="Persimon", Origin="Spain", Price=1.36 },
            new Fruit(){ Name="Blueberry", Origin="Canada", Price=0.19 },
            new Fruit(){ Name="Strawberry", Origin="Russia", Price=0.45 },
            new Fruit(){ Name="Avocado", Origin="Mexico", Price=0.45 }
        };


        static string[] words = "the quick brown fox jumps over the lazy dog".Split();

        static string[] second = "a b c e c".Split();
        static string[] third = "a c d e c".Split();

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
            Linq9_Inner();
            Linq9_Left();
            Linq9_Right();

            Console.WriteLine("---------End---------");
        }

        static void Linq1()
        {
            Console.WriteLine("***********Q1***************");
            var r = persons.Where(p => p.Country != "US");

            foreach (var i in r)
            {
                Console.WriteLine(i);
            }
        }

        static void Linq2()
        {
            Console.WriteLine("***********Q2***************");
            var r = persons.Where(p => p.Country == "US");

            foreach (var i in r)
            {
                Console.WriteLine(i.Name);
            }
        }

        static void Linq3()
        {
            Console.WriteLine("***********Q3***************");
            var r = persons.Where(p => p.Country == "India" && p.IsFemale);

            foreach (var i in r)
            {
                Console.WriteLine(i);
            }
        }

        static void Linq4()
        {
            Console.WriteLine("***********Q4***************");
            var r = persons.OrderBy(p => p.Name.Split()[0]).ThenBy(p => p.Name.Split()[1]);

            foreach (var i in r)
            {
                Console.WriteLine(i);
            }
        }

        static void Linq5()
        {
            Console.WriteLine("***********Q5***************");
            var r = persons.GroupBy(p => p.IsFemale);

            foreach (var grp in r)
            {
                foreach (var w in grp)
                {
                    Console.WriteLine(w);
                }
            }
        }


        static void Linq6()
        {
            Console.WriteLine("***********Q6***************");
            string longest = words.Aggregate((big, next) => next.Length > big.Length ? next : big);
            Console.WriteLine(longest);
        }

        static void Linq7()
        {
            Console.WriteLine("***********Q7***************");
            string longest = words.Aggregate((big, next) => next.Count(c => "aeiou".Contains(Char.ToLower(c))) > big.Count(c => "aeiou".Contains(Char.ToLower(c))) ? next : big);
            Console.WriteLine(longest);
        }


        static void Linq8()
        {
            Console.WriteLine("***********Q8***************");
            var query = second.Intersect(third);
            foreach (var q in query)
            {
                Console.WriteLine(q);
            }
        }

        static void Linq9_Inner()
        {
            Console.WriteLine("***********Q9 Inner***************");
            var IJoin = from p in persons
                        join f in fruits
                        on p.Country equals f.Origin
                        let fruitname = f.Name
                        select new { p.Name,  fruitname };
            Console.WriteLine("Inner Join");
            foreach (var item in IJoin)
            {
                Console.WriteLine($"{item.Name} {item.fruitname}");
            }
        }


        static void Linq9_Left()
        {
            Console.WriteLine("***********Q9  Left***************");
            var LJoin = from p in persons
                        join f in fruits
                        on p.Country equals f.Origin
                        into a
                        from b in a.DefaultIfEmpty(new Fruit())
                        let fruitname = b.Name
                        select new { p.Name, fruitname };
            Console.WriteLine("Left Join");
            foreach (var item in LJoin)
            {
                Console.WriteLine($"{item.Name} {item.fruitname}");
            }
        }

        static void Linq9_Right()
        {
            Console.WriteLine("***********Q9  Right***************");
            var LJoin = from f in fruits
                        join p in persons
                        on f.Origin equals p.Country
                        into a
                        from b in a.DefaultIfEmpty(new Person())
                        let personname = b.Name
                        select new { f.Name, personname };
            Console.WriteLine("Right Join");
            foreach (var item in LJoin)
            {
                Console.WriteLine($"{item.Name} {item.personname}");
            }
        }
    }
}
