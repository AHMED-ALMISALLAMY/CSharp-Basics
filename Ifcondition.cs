using System;

namespace Ifcondition
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetMax(4,7,9));
        }



        /// <summary>
        ///     It take 3 integer number and return Maximum number
        /// </summary>
        /// <param name="num1">first value</param>
        /// <param name="num2">second value</param>
        /// <param name="num3">third value</param>
        /// <returns>Maximum number</returns>
        static int GetMax(int num1 , int num2 , int num3)
        {
            int result;
            if (num1 >= num2 && num1 >= num3)
            {
                result = num1;
            }

            else if (num2 >= num1 && num2 >= num3) {
                result = num2;
            }


            else
            {
                result = num3;
            }


            return result;
        }
    }
}
