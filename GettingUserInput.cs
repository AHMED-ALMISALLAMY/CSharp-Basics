using System;

namespace GettingUserInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");

            string name = Console.ReadLine();

            Console.WriteLine("please enter your age");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hello " + name.ToUpper() + "You are " + age + " years");
        }
    }
}
