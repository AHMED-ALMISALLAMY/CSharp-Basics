using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Numbers = { 1, 2, 3, 4, 5 };

            Numbers[2] = 900;

            Console.WriteLine(Numbers[2]);

            Console.WriteLine(Numbers.Length);
        }
    }
}
