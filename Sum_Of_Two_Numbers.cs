using System;

namespace Sum_of_Two_Numbers
{
    class Program
    {
        // Task : Create a function that takes two numbers as arguments and return their sum.

        static int Sum(int a , int b)
        {
            int result = a + b;
            return result;
        }


        static void Main(string[] args)
        {
            Console.WriteLine(Sum(2,3));
        }
    }
}
