/*
 * Ailyn Diaz
 * CSC 2036 C#
 * 10/1/2022
 * UPDATED diamond program ----> Write an app that displays the a diamond shape.
 * First, read in an odd number in the range 1 to 19 to specify the number of rows in the diamond.
 * Continually prompt the user for a value until a valid number is entered. 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond
{
    class Program
    {
        //Main method
        static void Main(string[] args)
        {

            //user inputs and variables
            Console.Write("Enter number of rows (odd number 1 to 19): ");
            int number = int.Parse(Console.ReadLine());

            // validating input
            // re ask user to input IF its not odd
            while (number < 1 || number > 19 || number % 2 == 0)
            {
                Console.WriteLine("Invalid input.");
                Console.Write("Enter number of rows (odd number 1 to 19): ");
                number = int.Parse(Console.ReadLine());
            }

            // initialsing the number of spaces and asterisks
            int spaces = (number) / 2;
            int stars = 1;

            // loop to print the whole diamond
            for (int i = 1; i <= number; i++)
            {
                // loop to print spaces
                for (int j = 1; j <= spaces; j++)
                {
                    Console.Write(" ");
                }

                // loop to print asteriks
                for (int k = 1; k <= stars; k++)
                {
                    Console.Write("*");
                }

                if (i <= number / 2)
                {
                    spaces -= 1;
                    stars += 2;
                }
                else
                {
                    spaces += 1;
                    stars -= 2;
                }

                Console.Write("\n");
            }
        }
    }
}