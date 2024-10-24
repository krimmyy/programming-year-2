using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathsTutor
{
    internal class Cube:Volume1D
    {
        public Cube(string newDescription, double newDimension1)
            : base (newDescription, newDimension1)
        {

        }

        public override double calculateVolume()
        {
            return Math.Pow(getDimension1(), 3);
        }
    }
}
