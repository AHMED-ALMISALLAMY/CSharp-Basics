using System;

namespace ConvertMinutesIntoSeconds
{
    class Program
    {
        // Task : Write a function that takes an integer minutes and converts it to seconds.

        /// <summary>
        /// It take a integer minutes and convert it to seconds.
        /// </summary>
        /// <param name="minutes">integer value</param>
        /// <returns></returns>
        static int Convert(int minutes)
        {
            int result = minutes *= 60;
            return result;
        }




        static void Main(string[] args)
        {
            Console.WriteLine(Convert(5));
        }
    }
}
