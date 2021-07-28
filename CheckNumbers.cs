using System;

namespace CheckNumber
{
    class Program
    {
        // Task : Create a function that takes a number as its only argument and returns true if it's less than or equal to zero, otherwise return false.

        
        /// <summary>
        /// It take number and check if this num less than and equal zero it will return 'true' | else return 'false'.
        /// </summary>
        /// <param name="a">number</param>
        /// <returns></returns>
        static bool check(double a)
        {
            if (a <= 0) {
                return true;
            }
            else
            {
                return false;
            }
        }



        static void Main(string[] args)
        {
            Console.WriteLine(check(5));
        }
    }
}
