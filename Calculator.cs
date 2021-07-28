using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter first number: ");
                int firstNumber = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("Enter second number");
                int secondNumber = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("Enter operator: ");
                char oper = Convert.ToChar(Console.ReadLine());


                if (oper == '+')
                {
                    Console.WriteLine(firstNumber + secondNumber);
                }

                else if (oper == '-')
                {
                    Console.WriteLine(firstNumber - secondNumber);
                }

                else if (oper == '*')
                {
                    Console.WriteLine(firstNumber * secondNumber);
                }

                else if (oper == '/')
                {
                    Console.WriteLine(firstNumber / secondNumber);
                }

                else
                {
                    Console.WriteLine("Invalid input!");
                }

            }

            
            catch(Exception)
            {
                Console.WriteLine("Invalid Input!!");
            }
        }
    }
}
