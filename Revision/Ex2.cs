using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Program to prompt the user for their age and then depending on their age print out a specific message to the console.
 * AUTHOR: Eligijus Ciza
 * DATE CREATED: 26th September 2023 */

namespace Revision
{
    internal class Ex2
    {
        static void Main(string[] args)
        {
            int age;
            Console.WriteLine("Enter your age: ");
            age = Convert.ToInt32(Console.ReadLine());

            if (age >= 65)
                Console.WriteLine("You are entitled to a discount!");

            else
                Console.WriteLine("You are not entitled to a discount!");

            Console.ReadLine();
        }//Main

    }//Ex2
}
