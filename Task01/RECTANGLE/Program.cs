using System;

namespace RECTANGLE
{
    class Program
    {
        static void Main(string[] args)
        {
            Input();
        }

        static void Input()
        {
            string a = "a";
            string b = "a";
            while (Input_Check(a) == false | Input_Check(a) == false)
            {
                a = Console.ReadLine();
                b = Console.ReadLine();
            }
            Print(a, b);
            Console.ReadKey();
        }

        static void Print(string sa, string sb) => Console.WriteLine(Square(Convert.ToInt32(sa), Convert.ToInt32(sb)));

        static void Ignore() => Input();

        static bool Input_Check(string s)
        {
            bool result = false;
            uint a;
            float d;
            //if (UInt32.TryParse(s, out a) && s != "0")
            //    result = true;
            //else
            //    if (Convert.ToInt32(s) <= 0)
            //        Console.WriteLine("You can enter only a > 0 and b > 0");

            if (!(UInt32.TryParse(s, out a)) | float.TryParse(s, out d))
                Ignore();
            else
                if (UInt32.TryParse(s, out a) && s != "0")
                    result = true;

            return result;
        }

        static int Square(int a, int b) => a * b;
    }
}
