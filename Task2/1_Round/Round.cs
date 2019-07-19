using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Round
{
    public class Round
    {
        public int Center_X { get; set; }
        public int Center_Y { get; set; }
        private int Radius;

        public Round(int x, int y, int r)
        {
            Center_X = x;
            Center_Y = y;
            Radius_Check = r;
        }

        public Round()
        {
            Center_X = Center_Y = Radius = 0;
        }

        public int Radius_Check
        {
            get
            {
                return Radius;
            }

            set
            {
                if (value >= 0)
                    Radius = value;
                else 
                    throw new ArgumentException("Radius can be only >= 0");
            }
        }

        public double Length_of_Round => Math.PI * 2 * Radius;

        public double Square_of_Round => Math.PI * Math.Pow(Radius, 2);

        public override string ToString()
        {
            return $"Center: ({Center_X},{Center_Y}), Radius: {Radius}\nLength: {Length_of_Round} \nSquare: {Square_of_Round}";
        }
    }
}
