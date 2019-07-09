using System;

namespace _2_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Input_Round();
            Console.ReadKey();
        }

        static void Input_Round()
        {
            Console.WriteLine("Enter center of round");
            Console.Write("x = ");
            var x = new Triangle().a = Convert.ToInt32(Console.ReadLine());
            Triangle y = new Triangle();
            y = Console.ReadLine();
            Console.Write("y = ");
            //var y = new Triangle().b //= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter radius of round");
            Console.Write("r = ");
            var r = new Triangle().c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Center(" + x + ", " + y + ")" + " radius: " + r);
            Console.WriteLine("Length of round = " + new Triangle().Length_of_Round(r) +
                              " Square of Round = " + new Triangle().Square_of_Round(r));
            Console.WriteLine(y.GetType());
        }

        public class Triangle
        {
            public int a;
            public int b;
            public int c;

            public Triangle(int a, int b, int c)
            {
                this.a = a;
                this.b = b;
                this.c = c;
            }

            public double Length_of_Round(double r) => 3.14 * 2 * r;

            public double Square_of_Round(double r) => 3.14 * r * r;


        }
    }
}
