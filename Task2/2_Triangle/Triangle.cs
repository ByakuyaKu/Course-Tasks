using System;
using System.Collections.Generic;
using System.Text;

namespace _2_Triangle
{
    public class Triangle
    {
        public int a;
        public int b;
        public int c;

        public Triangle(int a, int b, int c)
        {
            A = a;
            B = b;
            C = c;

            if (!Side_Length_Check)
                throw new ArgumentException("side of triangle can`t be more than summ of other sides");
        }

        public int A
        {
            get
            {
                return a;
            }
            set
            {
                if (value > 0)
                    a = value;
                else
                    throw new ArgumentException("Side of triangle can be only > 0");
            }
        }

        public int B
        {
            get
            {
                return b;
            }
            set
            {
                if (value > 0)
                    b = value;
                else
                    throw new ArgumentException("Side of triangle can be only > 0");
            }
        }

        public int C
        {
            get
            {
                return c;
            }
            set
            {
                if (value > 0)
                    c = value;
                else
                    throw new ArgumentException("Side of triangle can be only > 0");
            }
        }

        public bool Side_Length_Check => a < b + c && b < a + c && c < a + b;

        public double Length_of_Triangle => a + b + c;

        public double Square_of_Triangle => Math.Sqrt(Length_of_Triangle * (Length_of_Triangle - 2 * a)
            * (Length_of_Triangle - 2 * b) * (Length_of_Triangle - 2 * c)) / 4;

        public override string ToString()
        {
            return $"a = {a}, b = {b}, c = {c}\nLength: {Length_of_Triangle}\nSquare: {Square_of_Triangle}";
        }
    }
}
