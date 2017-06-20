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
         * The originial project objective was to find the 100th number in the sequence.
         *********************/
        static void Main(string[] args)
        {
            // Variables
            int checkpoint = 100;           // The default spot in the sequence to check.
            ulong tempFirst = 0;
            ulong tempSecond = 1;
            ulong total = tempFirst + tempSecond;
            bool result;

            Console.WriteLine("The Fibonacci Sequence Number Finder");
            Console.WriteLine("By Jeff Peterson");

            Console.WriteLine("\nThe Fibonacci sequence is a series of numbers where each digit");
            Console.WriteLine("is composed of the sum of the two numbers before it.");

            // Obtain the spot to check while verifying that we have a good result.
            while (true)
            {
                Console.Write("\nWhich point in the sequence do you want to check (max=100): ");
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
                else if (checkpoint == 1 || checkpoint == 2)
                {
                    // Do a dummy check.  If the user entered 1 or 2, give the actual value.
                    Console.Write("\nThe number at {0} of the sequence is ", checkpoint);
                    if (checkpoint == 1)
                    {
                        Console.WriteLine("{0}.", tempFirst);
                    }
                    else
                    {
                        Console.WriteLine("{0}.", tempSecond);
                    }
                    return;
                }
                else if (checkpoint > 100)
                {
                    Console.WriteLine("\nThat is not a valid integer.  Cannot search greater than 100.");
                    continue;
                }
                else
                {
                    break;
                }
            }

            // Start the display of the numbers.
            Console.Write("\n{0}, {1}", tempFirst, tempSecond);

            // Iterate through the sequence, starting at position 3.
            for (int i = 3; i <= checkpoint; i++)
            {
                // Place the comma and space before the next number.
                Console.Write(", ");

                // Start by moving values in the temp* variables. Shift them down the line.
                tempFirst = tempSecond;     // Put the second value into the first temp variable.
                tempSecond = total;         // Put the most recent result into the second temp variable.

                // Now find the new total.
                total = tempFirst + tempSecond;

                // Display the new number in the sequence.
                Console.Write("{0}", total);
            }

            // All done.  Give the final result for the user.
            Console.WriteLine("\nThe value found at spot {0} of the Fibonacci sequence is {1}", checkpoint, total);
        }
    }
}
