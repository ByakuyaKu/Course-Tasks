using System;

namespace _7_Vector_Graphics_Editor
{
    class Program
    {
        static void Main(string[] args)
        {
            Ring ring = new Ring(-3, 1, 18, 19);
            Console.WriteLine(ring);

            Point c = new Point(1, 2);
            Circle Circle = new Circle(c, 3);
            Console.WriteLine(Circle);

            Point a = new Point(1, 2);
            Point b = new Point(2, 4);
            Line l = new Line(a, b);
            Console.WriteLine(l);

            Point d = new Point(0, 2);
            Rectangle r = new Rectangle(a, b, c, d);
            Console.WriteLine(r);

            Round round = new Round(c, 2);
            Console.WriteLine(round);

            Console.ReadKey();
        }
    }
}
