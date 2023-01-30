using System;

/** Module 2: Armstrong numbers
   Casinsinan, Cj C.
   BSCS 3-1N
*/

namespace Casinsinan_Module2Assessment
{
    class ArmstrongChecker
    {
        private static void Main(string[] args)
        {
            int number, r, sum = 0, temp;
            Console.WriteLine("This program will check whether a given number is Armstrong number or not:");

            Console.Write("\nPlease input a number: ");
            number = Convert.ToInt32(Console.ReadLine());

            /* When the total of the cubes of a number's constituent digits equals that number, the number is identified as the Armstrong number. */

            for (temp = number; number != 0; number = number / 10)
            {
                r = number % 10;
                sum = sum + (r * r * r); // sum of cube of individual number
            }
            if (sum == temp)
                Console.Write("The given number: {0} is an Armstrong number.\n", temp); // Print if the number is an Armstrong number
            else
                Console.Write("The given number: {0} is not an Armstrong number.\n", temp); // Print if the number is not an Armstrong number
        }
    }
}
