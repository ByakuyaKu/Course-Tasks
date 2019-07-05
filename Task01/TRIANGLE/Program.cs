using System;

namespace TRIANGLE
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter integer n>=0");
            string n = Console.ReadLine();
            Check_input(n);
            Console.ReadKey();
        }

        static void Check_input(string s)
        {
            uint a;
            if (UInt32.TryParse(s, out a))
                Triangle(Convert.ToUInt32(s));
            else
                Console.WriteLine("You can enter only integer n>=0");
        }

        static void Triangle(uint z)
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