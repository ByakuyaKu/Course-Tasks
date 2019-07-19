using System;
using System.Collections.Generic;
using System.Text;

namespace _7_Vector_Graphics_Editor
{
    public class Line : Figure
    {
        public Point point_a { get; set; }
        public Point point_b { get; set; }

        public Line(Point pointa, Point pointb)
        {
            point_a = pointa;
            point_b = pointb;
        }

        public Line()
        {
            point_a.x = 0;
            point_a.y = 0;
            point_b.x = 1;
            point_b.y = 1;
        }

        public override string ToString()
        {
            return "Line with points " + point_a.ToString() + " and " + point_b.ToString();
        }
    }
}
