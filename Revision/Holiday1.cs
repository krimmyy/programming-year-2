using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Program to calculate the cost of a family holiday with the company Fantastic Holidays
 * prompts the user for a name, costs of each type of ticket, how many people are in the group,
 * what the ages are of each person and how many bags of luggages are required.
 * all of this information is used to calculate the costs and then is displayed on the console for the user to see.
 * AUTHOR: Eligijus Ciza
 * DATE CREATED: 26th September 2023 */

namespace Revision
{ 
    internal class Holiday1
    {
        static void Main(string[] args)
        {
            string name;
            decimal adultCost, teenagerCost, childCost, basicCost, luggageCost, vatCost, total;
            int noOfPeople, age, noOfChildren = 0, noOfTeenagers = 0, noOfAdults = 0, noOfLuggage;
            const int COSTPERITEM = 20;
            const decimal VATRATE = 0.2M;

            Console.WriteLine("Welcome to Fantastic Holidays");
            Console.WriteLine("=============================");
            Console.Write("Please enter your name: ");
            name = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Adult Cost:    £");
            adultCost = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Teenager Cost: £");
            teenagerCost = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Child Cost:    £");
            childCost = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine();

            Console.Write("How many people are in the group? ");
            noOfPeople = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine();

            for (int count = 0; count < noOfPeople; count++)
            {
                Console.Write("Enter the age: ");
                age = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine();

                if (age <= 12)
                {
                    noOfChildren++;
                }
                else
                    if (age <18)
                {
                    noOfTeenagers++;
                }
                else
                {
                    noOfAdults++;
                }    
            }//for

            Console.Write("How many pieces of luggage do you wish to book? ");
            noOfLuggage = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine();

            basicCost = (noOfAdults * adultCost) + (noOfTeenagers * teenagerCost) + (noOfChildren * childCost);
            luggageCost = noOfLuggage * COSTPERITEM;
            vatCost = (basicCost + luggageCost) * VATRATE;
            total = basicCost + luggageCost + vatCost;

            Console.WriteLine("HOLIDAY COST for " + name);
            Console.WriteLine("========================");
            Console.WriteLine(noOfAdults + " Adults, " + noOfTeenagers + " Teenagers, " + noOfChildren + " Children");
            Console.WriteLine("Basic Cost £" + basicCost);
            Console.WriteLine("Luggage £" + luggageCost);
            Console.WriteLine("VAT £" + vatCost);
            Console.WriteLine("========");
            Console.WriteLine("Total Cost £" + total);
            Console.ReadLine();

        }//Main
    }//Holiday1
}
