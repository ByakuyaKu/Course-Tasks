using System;

namespace _1._10_2D_ARRAY
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            Array_2D(Convert.ToUInt32(n));
        }
        static void Array_2D(uint z)
        {
            string s = null;
            for (uint i = 0; i < z; i++)
            {
                s += "*";
                Console.WriteLine(s);
            }       
            }
        }
}
