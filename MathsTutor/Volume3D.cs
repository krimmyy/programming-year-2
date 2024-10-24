using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathsTutor
{
    abstract class Volume3D:Volume1D
    {
        private double dimension2;
        private double dimension3;

         public Volume3D(string newDescription, double newDimension1, double newDimension2, double newDimension3)
            : base(newDescription, newDimension1)
        {
            dimension2 = newDimension2;
            dimension3 = newDimension3;
        }

        public void setDimension2(double newDimension2)
        {
            dimension2 = newDimension2;
        }

        public void setDimension3(double newDimension3)
        {
            dimension3 = newDimension3;
        }

        public double getDimension2()
        {
            return dimension2;
        }

        public double getDimension3()
        {
            return dimension3;
        }
    }
}
