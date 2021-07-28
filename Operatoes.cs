using System;

namespace AndOperators
{
    class Program
    {
        // Task : C# has a logical operator &&. The && operator takes two boolean values, and returns true if both values are true.

        //Consider a && b:

        //a is checked if it is true or false.
        //If a is false, false is returned.

        //b is checked if it is true or false.
        //If b is false, false is returned.

        //Otherwise, true is returned(as both a and b are therefore true ).

        //Rembember that the default value for bool is false. (eg.var c = new bool (); c is false.)
        //The && operator will only return true for true && true.






        /// <summary>
        /// If 'a' and 'b' equal true -> return true , if 'a' and 'b' equal false -> return false , else return false.
        /// </summary>
        /// <param name="x">first value</param>
        /// <param name="y">second value</param>
        /// <returns>true or false</returns>
        static bool And(bool x , bool y)
        {
            if (x == true && y == true)
            {
                return true;
            }
            else if (x == false && y == false)
            {
                return false;
            }

            else
            {
                return false;
            }
        }





        static void Main(string[] args)
        {
            Console.WriteLine(And(true,false));
        }
    }
}
