        using System;

namespace Task00_SIMPLE
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();

            Input_Check(n);

            Console.ReadKey();
        }

        static void Print(string s)
        {
            if (Simple_check(Convert.ToUInt32(s)))
                Console.WriteLine("number is simple");
            else
                Console.WriteLine("number isn't simple");

        }

        static void Input_Check(string s)
        {
            uint a;
            if (UInt32.TryParse(s, out a) && s != "0") 
                Print(s);
            else
                Console.WriteLine("You can enter only n > 0");
        }

        static bool Simple_check(uint z)
        {
            bool result = true;
            for (uint i = 2; i < z; i++)
            {
                if (z % i == 0)
                    result = false;
            }

            return result;
        }

    }
}
