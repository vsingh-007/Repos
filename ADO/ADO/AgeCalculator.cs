using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO
{
    public class AgeCalculator
    {
        public static void Main(string[] args)    //DO NOT CHANGE the 'Main' method signature
        //{
        //    Console.WriteLine("Enter the date of birth (dd-mm-yyyy): ");
        //    string dateOfBirth = Console.ReadLine();
        //    Console.WriteLine(calculateAge(dateOfBirth));

        //}

        //public static int calculateAge(string dateOfBirth)
        //{
        //    int age = 0;
        //    DateTime currentDate = DateTime.Now;
        //    int year = currentDate.Year;
        //    int month = currentDate.Month;
        //    int day = currentDate.Day;
        //    string[] dob = dateOfBirth.Split('-');
        //    age = year-int.Parse(dob[2]);
        //    if (month > int.Parse(dob[1]))
        //    {
        //        age += 1;
        //    }
        //    if (month == int.Parse(dob[1]) && day > int.Parse(dob[0]))
        //    {
        //        age += 1;
        //    }
        //    return age;
        //}

        {
            Console.Clear();
            DateTime currentTime = DateTime.Now;
            Console.WriteLine(currentTime);
            Console.WriteLine(Convert.ToDateTime("13:54:10"));
            int result = DateTime.Compare(Convert.ToDateTime("13:54:10"), currentTime);
            TimeSpan diff1 = Convert.ToDateTime("13:54:10").Subtract(currentTime);
            Console.WriteLine(diff1);

            Console.ReadKey();
        }
    }
}
