using System;

namespace AreaOfTriangle
{
    class Program
    {
        // Task : Write a function that takes the base and height of a triangle and return its area.


        /// <summary>
        /// It take base and height of triangle and return its area.
        /// </summary>
        /// <param name="triabase">base</param>
        /// <param name="height">height</param>
        /// <returns>AreaofTriangle</returns>
        static int Area(int triabase , int height)
        {
            int result = (triabase * height) / 2;
            return result;
        }



        static void Main(string[] args)
        {
            Console.WriteLine(Area(7,4));
        }
    }
}
