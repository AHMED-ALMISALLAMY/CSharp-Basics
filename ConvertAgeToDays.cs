using System;

namespace ConvertAgeToDays
{
    class Program
    {
        // Task : Create a function that takes the age in years and returns the age in days.


        /// <summary>
        /// It take your age in years and convert it to days.
        /// </summary>
        /// <param name="age">AgeInyEARS</param>
        /// <returns>Your age in days</returns>
        static int ConvertAge(int age)
        {
            int result = age *= 365;
            return result;
        }


        static void Main(string[] args)
        {
            Console.WriteLine(ConvertAge(15));
        }
    }
}
