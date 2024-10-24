using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathsTutor
{
    internal class Circle:Area1D
    {
        public Circle(string newDescription, double newDimension1)
            : base(newDescription, newDimension1)
        {
            
        }

        public Circle(string newDescription)
            :base (newDescription)
        {

        }

        public override double calculateArea()
        {
            return Math.PI * Math.Pow(getDimension1(), 2);
        }
    }
}
