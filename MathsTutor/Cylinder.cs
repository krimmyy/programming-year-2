using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathsTutor
{
    internal class Cylinder:Volume2D
    {
        public Cylinder(string newDescription, double newDimension1, double newDimension2)
            : base (newDescription, newDimension1, newDimension2)
        {

        }

        public override double calculateVolume()
        {
            return Math.PI * Math.Pow(getDimension1(), 2) * getDimension2();
        }
    }
}
