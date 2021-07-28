using System;

namespace ReturnTheNextNumber
{
    class Program
    {
        // Task : Create a function that takes a number as an argument, increments the number by +1 and returns the result.



        /// <summary>
        /// It take a number from user and increase by 1.
        /// </summary>
        /// <param name="num">number</param>
        /// <returns>Number increase by 1</returns>
        static int Next(int num)
        {
            int result = num += 1;
            return result;
        }



        static void Main(string[] args)
        {
            Console.WriteLine(Next(7));
        }
    }
}
