using System;
using System.Collections.Generic;
using System.Text;

namespace _7_Vector_Graphics_Editor
{
    public class Round : Circle
    {
        public Round(Point center, int r) : base(center, r)
        {
            ToString();
        }

        public override string ToString()
        {
            return $"Round with center in point " + center.ToString() + ", radius = " + radius;
        }
    }
}

