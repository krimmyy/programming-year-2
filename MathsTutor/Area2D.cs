using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathsTutor
{
    abstract class Area2D:Area1D
    {
        private double dimension2;

        public Area2D(string newDescription, double newDimension1, double newDimension2)
            : base(newDescription, newDimension1)
        {
            dimension2 = newDimension2;
        }

        public void setDimension2(double newDimension2)
        {
            dimension2 = newDimension2;
        }

        public double getDimension2()
        {
            return dimension2;
        }
    }
}
