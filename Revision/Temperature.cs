using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Program to prompt the user for the temperature of the three departments, calculate the average temperature
 * then print out a specific message to the console depending on if its higher or lower than 17 degrees.
 * AUTHOR: Eligijus Ciza
 * DATE CREATED: 26th September 2023 */

namespace Revision
{
    internal class Temperature
    {
        static void Main(string[] args)
        {
            int temp1, temp2, temp3;
            double average;

            Console.WriteLine("What is the temperature of the Art department?");
            temp1 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("What is the temperature of the English department?");
            temp2 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("What is the temperature of the Music department?");
            temp3 = Convert.ToInt16(Console.ReadLine());

            average = (double) (temp1 + temp2 + temp3) / 3;

            Console.WriteLine();
            Console.WriteLine("The average temperature of the three departments is :" + average);
            Console.WriteLine();

            if (average < 17)
            {
                Console.WriteLine("The heating should be ON!");
            }
            else
            {
                Console.WriteLine("The heating should be OFF!");
            }
            Console.ReadLine();
        }//Main
    }//Temperature
}
