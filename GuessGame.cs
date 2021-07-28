using System;

namespace GuessGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string SecretWord = "c sharp";
            string guess = "";
            int GuessCount = 0;
            int GuessLimit = 5;
            bool OutOfGuesss = false;

            while (guess != SecretWord && !OutOfGuesss)
            {
                if (GuessCount < GuessLimit)
                {
                    Console.Write("Enter a guess: ");
                    guess = Console.ReadLine().ToLower();
                    GuessCount++;
                }

                else
                {
                    OutOfGuesss = true;
                }

            }

            if (OutOfGuesss)
            {
                Console.WriteLine("You lose!");
            }

            else
            {
                Console.WriteLine("You got it ⭐️");
            }
        }
    }
}
