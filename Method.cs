using System;

namespace Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Sayhello("Ahmed");
        }


        /// <summary>
        /// It take a name string and say hello to user.
        /// </summary>
        /// <param name="name">name value</param>
        static void Sayhello(string name)
        {
            print("Hello " + name);
        }


        static void print(string message)
        {
            Console.WriteLine(message);
        }

    }
}
