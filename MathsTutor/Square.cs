using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathsTutor
{
    class Square:Area1D
    {
        public Square(string newDescription, double newDimension1)
            : base(newDescription, newDimension1)
        {

        }

        public Square(string newDescription)
            : base(newDescription)
        {
        }

        public override double calculateArea()
        {
            return Math.Pow(getDimension1(), 2);
        }
    }
}
