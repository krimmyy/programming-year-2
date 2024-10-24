﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathsTutor
{
    abstract class Volume2D:Volume1D
    {
        private double dimension2;

        public Volume2D(string newDescription, double newDimension1, double newDimension2)
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
