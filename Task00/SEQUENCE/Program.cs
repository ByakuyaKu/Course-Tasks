using System;
using System.Collections.Generic;

namespace Task00_SEQUENCE
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter n > 0");
            string n = Console.ReadLine();

            Check_Print(n);

            Console.ReadKey();
        }

        static void Check_Print(string s)
        {
            uint a;
            if (UInt32.TryParse(s, out a) && s != "0") 
                Console.WriteLine("Sequence is: " + Seq(Convert.ToUInt32(s)));
            else
                Console.WriteLine("You can enter only n > 0");
        }

        static string Seq(uint z)
        {
            string s = null;

             for(uint i = 1; i <= z; i++)
               s += Convert.ToString(i) + ',' + ' ';

            return s.Remove(s.Length - 2);
        }
    }
}
