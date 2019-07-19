using System;
using System.Collections.Generic;
using System.Text;

namespace _7_Vector_Graphics_Editor
{
    public class Circle : Figure
    {
        public Point center;
        public int radius { get; set; }

        public Circle(Point Center, int r)
        {
            center = Center;
            radius = r;
            ToString();
        }

        public override string ToString()
        {
            return $"Circle with center: " + center.ToString() + " and radius: " + radius;
        }
    }
}
