using System;

namespace WorkingWithNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(3 * 9);


            int num = 5;
            Console.WriteLine( (5 + 3) * num );



            int num2 = 7;   // num2 = 7
            num2++;         // num2 = 8
            num2 += 7;      // num2 = 8 + 7
            Console.WriteLine(num2);



            // Absoulte value
            Console.WriteLine( Math.Abs(-40) );

            //power
            Console.WriteLine( Math.Pow(5, 2) );

            // square root
            Console.WriteLine( Math.Sqrt(9) );

            // which num is bigger
            Console.WriteLine( Math.Max(49, 8) );

            // which num is smaller
            Console.WriteLine(Math.Min(9, 7));

            // round
            Console.WriteLine(Math.Round(4.6));
        }
    }
}
