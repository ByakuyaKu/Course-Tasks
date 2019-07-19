using System;
using System.Collections.Generic;
using System.Text;
using _1_Round;

namespace _6_Ring
{
    class Ring : Round
    {
        private int inner_Radius, outer_Radius;

        public int Inner_Radius_Check
        {
            get
            {
                return inner_Radius;
            }
            set
            {
                if (outer_Radius != 0 && value < outer_Radius)
                    throw new ArgumentException("Inner radius can`t be > outer radius and <= 0");
                if (value > 0)
                    inner_Radius = value;
                else
                    throw new ArgumentException("Inner radius can`t be > outer radius and <= 0");
            }
        }

        public int Outer_Radius_Check
        {
            get
            {
                return outer_Radius;
            }
            set
            {
                if (value > 0 && value > inner_Radius)
                    outer_Radius = value;
                else
                    throw new ArgumentException("Outer radius can`t be < inner radius and <= 0");
            }
        }


        public Ring()
        {
            Center_X = 0;
            Center_Y = 0;
            inner_Radius = 1;
            outer_Radius = 2;
        }

        public Ring(int x, int y, int r, int R)
        {
            Center_X = x;
            Center_Y = y;
            Inner_Radius_Check = r;
            Outer_Radius_Check = R;
        }

        public double Square_of_Circuit => Math.PI * Math.Pow(outer_Radius, 2) - Math.PI * Math.Pow(inner_Radius, 2);
        public double Circuit_Length => 2 * Math.PI * inner_Radius + 2 * Math.PI * outer_Radius;


        public override string ToString()
        {
            return $"Center: ({Center_X},{Center_Y}) \nInner radius: {inner_Radius}\nOuter radius: {outer_Radius}\nCircuit length: {Circuit_Length} \nSquare: {Square_of_Circuit}"; ;
        }
    }
}
