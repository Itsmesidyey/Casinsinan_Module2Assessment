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
            Console.WriteLine("This program will check whether a given number is armstrong number or not");

            Console.Write("Please input a number: ");
            temp = int.Parse(Console.ReadLine());

            if (temp >= 0)
            {
                number = temp;
                while (temp > 0)
                {
                    r = temp % 10;
                    sum += (r * r * r);
                    temp /= 10;
                }

               if (sum == temp)
            Console.WriteLine("\nThe given number: " + number + "is An Armstrong number"); //Print if the input number is an Armstrong number
            }
            else
            {
            Console.WriteLine("\nThe given number: " + number + "is not An Armstrong number"); //Print if the input number is not an Armstrong number
            }   
        }
    }
}