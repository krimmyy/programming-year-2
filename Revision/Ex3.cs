using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Program to prompt the user for 5 numbers then store it in an array
 * determines which is the largest number and then all numbers are printed out to the console with the largest one being on a new line
 * AUTHOR: Eligijus Ciza
 * DATE CREATED: 26th September 2023 */

namespace Revision
{
    internal class Ex3
    {
        static void Main(string[] args)
        {
            int[] list = new int[5];

            int largest = 0;

            Console.WriteLine("Enter any 5 numbers: ");
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter a number: ");
                list[i] = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();

                if (list[i] > largest)
                {
                    largest = list[i];
                }
            }
            Console.WriteLine("The 5 numbers are : ");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(list[i] + " ");
            }

            Console.WriteLine("\n\nLargest number entered: " + largest);

            Console.ReadLine();
        }//Main
    }//Ex3
}
