using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZiqingQiu_Lab05_Ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<Student> students = new LinkedList<Student>();
            Student[] studentArray = new[] {
                new Student("300919236", "James"),
                new Student("300919238", "Han"),
                new Student("300918215", "Matt"),
                new Student("300917215", "Fang"),
                new Student("300916215", "Roy")
            };

            for (int i = 0; i < studentArray.Length; i++)
            {
                AddLinkedListItem(students, studentArray[i]);
            }

            Console.WriteLine("\n*************\nAfter add all students: "  + "\n*************");
            PrintLinkedList(students);

            Student snotexist = new Student("300816215", "Dave");
            Console.WriteLine("\n*************\nAfter search invalid student: " + snotexist + "\n*************");
            SearchLinkedListItem(students, snotexist);

            Console.WriteLine("\n*************\nAfter search invalid student: " + studentArray[4] + "\n*************");
            SearchLinkedListItem(students, studentArray[4]);

            Console.WriteLine("\n*************\nAfter remove: " + studentArray[4] + "\n*************");
            RemoveLinkedListItem(students, studentArray[4]);
            PrintLinkedList(students);

            Console.WriteLine("\n*************\nAfter remove all students: "  + "\n*************");
            RemoveAllLinkedListItems(students);
            PrintLinkedList(students);

        }
        //add one item to the linked list
        private static void AddLinkedListItem<T>(LinkedList<T> list, T item)
        {
            list.AddFirst(item);
        }

        //remove one item from the linked list
        private static void RemoveLinkedListItem<T>(LinkedList<T> list, T item)
        {
            if (list.Find(item) != null)
            {
                list.Remove(item);
            }
            else
            {
                Console.WriteLine(item + " does NOT exist");
            }
        }

        //print the whole linkedlist
        private static void PrintLinkedList<T>(LinkedList<T> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
        //search one perticular item frm linkedlist
        private static LinkedListNode<T> SearchLinkedListItem<T>(LinkedList<T> list, T item)
        {
            LinkedListNode<T> result = list.Find(item);
            if (result == null)
            {
                Console.WriteLine(item + " does NOT exist");
            }
            else
            {
                Console.WriteLine(item + " has been founded!!");
            }
            return result;
        }

        //remove all the items from the linkedlist
        private static void RemoveAllLinkedListItems<T>(LinkedList<T> list)
        {
            list.Clear();
        }
    }
}
