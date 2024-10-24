using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathsTutor
{
    internal class Sphere:Volume1D
    {
        public Sphere(string newDescription, double newDimension1)
            : base(newDescription, newDimension1)
        {

        }

        public override double calculateVolume()
        {
            return 4.0 / 3 * Math.PI * getDimension1() * getDimension1() * getDimension1();
        }
    }
}
