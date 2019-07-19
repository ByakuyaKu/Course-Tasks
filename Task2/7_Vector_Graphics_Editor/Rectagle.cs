using System;
using System.Collections.Generic;
using System.Text;

namespace _7_Vector_Graphics_Editor
{
    public class Rectangle
    {
        private Point a;
        private Point b;
        private Point c;
        private Point d;

        public Rectangle(Point A, Point B, Point C, Point D)
        {
            a = A;
            b = B;
            c = C;
            d = D;
            ToString();
        }

        public override string ToString()
        {
            return $"Rectangle with points: " + a.ToString() + ", " + b.ToString() + ", "
                + c.ToString() + ", " + d.ToString();
        }
    }
}
