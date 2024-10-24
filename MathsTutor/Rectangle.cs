using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathsTutor
{
    class Rectangle:Area2D
    {
        public Rectangle(string newDescription, double newDimension1, double newDimension2)
            : base (newDescription, newDimension1, newDimension2)
        {

        }

        public override double calculateArea()
        {
            return getDimension1() * getDimension2();
        }
    }
}
