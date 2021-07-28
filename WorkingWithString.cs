using System;

namespace WorkingWithString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter your name: ");
            string name = Convert.ToString(Console.ReadLine());

            // change name to upper case
            Console.WriteLine("Your name in upper case: " + name.ToUpper());

            // change name to lower case
            Console.WriteLine("Your name in lower case: " + name.ToLower());

            // Is 'pharse' contain 's' -> true or false.
            string pharse = "csharp";
            Console.WriteLine(pharse.Contains("s"));

            // print character.
            string text = "Web devolober";
            Console.WriteLine(text[1]);

            // print index of character.
            Console.WriteLine(text.IndexOf('d'));

            // it will grab character from start to end of string.
            Console.WriteLine(text.Substring(5));

            // start from first index and it will take 3 character. ->evo
            Console.WriteLine(text.Substring(5,3));
        }
    }
}
