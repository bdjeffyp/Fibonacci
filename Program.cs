using System;

namespace Fibonacci
{
    class Program
    {
        /*********************
         * Fibonacci
         * Developer: Jeff Peterson
         * Date: 06/17/2017
         * Purpose: Display the specified number in the Fibonacci sequence.
         *********************/
        static void Main(string[] args)
        {
            // Variables
            int checkpoint = 1;         // The spot in the sequence to check.
            bool result;

            Console.WriteLine("The Fibonacci Sequence Number Finder");
            Console.WriteLine("By Jeff Peterson");

            Console.WriteLine("\nThe Fibonacci sequence is a series of numbers where each digit");
            Console.WriteLine("is composed of the sum of the two numbers before it.");

            // Obtain the spot to check while verifying that we have a good result.
            while (true)
            {
                Console.Write("\nWhich point in the sequence do you want to check: ");
                result = int.TryParse(Console.ReadLine(), out checkpoint);
                if (result == false)
                {
                    Console.WriteLine("\nThat is not a valid integer.  Specify a number greater than zero.");
                    continue;
                }

                if (checkpoint < 1)
                {
                    Console.WriteLine("\nThat is not a valid integer.  Specify a number greater than zero.");
                    continue;
                }
                else if (checkpoint == 1)
                {
                    // Do a dummy check.  If the user entered 1 or 2, give the actual value.
                    Console.WriteLine("\nThe number at {0} of the sequence is 0.");
                    return;
                }
                else
                {
                    break;
                }
            }

            
            // Iterate through the sequence, starting at position 3.
        }
    }
}
