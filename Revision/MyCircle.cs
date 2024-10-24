using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

/* Program to ask for the radius of a circle, calculate diameter, circumference and area and then print it to the console.
 * AUTHOR: Eligijus Ciza
 * DATE CREATED: 26th September 2023 */

namespace Revision
{
    internal class MyCircle
    {
        static void Main(string[] args)
        {
            double pi = Math.PI, radius, diameter, circumference, area;

            Console.WriteLine("What is the radius of the circle?");
            radius = Convert.ToDouble(Console.ReadLine());

            diameter = (2 * radius);
            circumference = (2 * pi * radius);
            area = (pi * radius * radius);

            Console.WriteLine("The diameter is : " + Convert.ToInt16(Math.Round(diameter)));
            Console.WriteLine("The circumference is : " + Convert.ToInt16(Math.Round(circumference)));
            Console.WriteLine("The area is : " + Convert.ToInt16(Math.Round(area)));
            Console.ReadLine();

        }//Main
    }//MyCircle
}
