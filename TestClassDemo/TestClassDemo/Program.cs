using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace TestClassDemo
{
    class Student
    {
        public int Id;
        public string Name;
    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Bill", "Steve", "James", "Mohan" };
            var linq = from i in names
                       where i.Length >= 5
                       select i;
            foreach (var item in linq)
            {
                Console.WriteLine(item);
            }


            ArrayList arrayList = new ArrayList();
            string choice = "n";

            Console.WriteLine("enter items in arraylist :");
            do
            {
                arrayList.Add(Console.ReadLine());
                Console.WriteLine("wanna continue (y/n)");
                choice = Console.ReadLine();
            }
            while (choice == "y");

            arrayList.Add(10);
            arrayList.Add(20);
            arrayList.Add(30);
            arrayList.Add("Hello");
            arrayList.Add("Welcome");
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }

            List<int> myList = new List<int>();
            myList.Add(10);
            myList.Add(20);
            myList.Add(30);
            myList.Add(40);
            myList.Add(50);
            myList.Insert(2,25);
            myList.ForEach(i => Console.WriteLine(i));

            var students = new List<Student>() { 
                new Student(){ Id = 1, Name="Bill"},
                new Student(){ Id = 2, Name="Steve"},
                new Student(){ Id = 3, Name="Ram"},
                new Student(){ Id = 4, Name="Abdul"}
            };

            students.ForEach(i => Console.WriteLine(i.Id + " " + i.Name));
        }
    }
}
