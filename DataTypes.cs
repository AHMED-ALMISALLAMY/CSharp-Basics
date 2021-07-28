using System;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // String
            string name = "Ahmed";
            char grade = 'A';

            // Numbers
            int age = 15;
            double gba = 7.5;
            decimal price = 9;

            // boolean
            bool is_online = true;


            Console.WriteLine("Hello " + name);
            Console.WriteLine("Age age " + age);
            Console.WriteLine("Grade " + grade);

            Console.WriteLine("Gba is " + gba);

            Console.WriteLine("It coast $" + price);
            Console.WriteLine("Is he online: " + is_online);
        }
    }
}
