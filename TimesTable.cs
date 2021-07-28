using System;

namespace TimesTable
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("Enter a number");
                int number = Convert.ToInt32(Console.ReadLine());

                for (int multiple = 0; multiple < 11; multiple++)
                {
                    Console.WriteLine(number + "x" + multiple + "=" + multiple * number);
                }
            }


            catch(Exception)
            {
                Console.WriteLine("Invalid input!");
            }

        }
    }
}
