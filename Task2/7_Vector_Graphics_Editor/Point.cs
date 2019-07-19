using System;
using System.Collections.Generic;
using System.Text;

namespace _7_Vector_Graphics_Editor
{
    public class Point
    {
        public int x { get; set; }
        public int y { get; set; }

        public Point(int X, int Y)
        {
            x = X;
            y = Y;
            ToString();
        }

        public override string ToString()
        {
            return $"({x}, {y})";
        }

    }
}
