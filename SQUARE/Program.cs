using System;

namespace Task00_SQUARE
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();

            Print(n);

            Console.ReadKey();
        }

        static void Print(string s)
        {
            if (Check_input(s))
                Square(Convert.ToInt32(s));
            else
                Console.WriteLine("You can enter only odd number > 0");
        }

        static bool Check_input(string s)
        {
            bool result = true;

            uint a;
            if (UInt32.TryParse(s, out a))
                if (!Odd_check(Convert.ToUInt32(s)))
                    result = false;
            return result;
        }

        static bool Odd_check(uint z) => z % 2 != 0;

        static void Square(int z)
        {
            string s = null;
            for (int i = 0; i < z; i++)
                s += "*";

            for (int i = 0; i < z; i++)
            {
                if (i == (z / 2))
                    Console.WriteLine(s.Remove(i, 1).Insert(i, " "));
                else
                    Console.WriteLine(s);
            }
        }
    }
}
