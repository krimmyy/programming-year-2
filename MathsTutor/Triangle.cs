using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathsTutor
{
    class Triangle:Area2D
    {
        public Triangle(string newDescription, double newDimension1, double newDimension2)
            : base (newDescription, newDimension1, newDimension2)
        {

        }

        public override double calculateArea()
        {
            return getDimension1() * getDimension2() / 2;
        }
    }
}
