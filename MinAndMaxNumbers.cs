using System;

namespace FindMinAndMaxNumber
{
    class Program
    {

		/// <summary>
        /// it take a list and it print maximum number and minimum number.
        /// </summary>
        /// <param name="args">int values</param>
        static void Main(string[] args)
        {
			int [] values = new int[4] { 7, 3, 9, 5 };

			double max = 0;
			double min = values[0];

			foreach (double num in values)
			{
				if (max < num)
				{
					max = num;
				}

				else if (min > num)
				{
					min = num;
				}

			}

			Console.WriteLine("Maximum number is " + max);
			Console.WriteLine("Minimum number is " + min);
		}
    }
}
