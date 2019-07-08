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
            Console.WriteLine("Enter a");
            string a = Console.ReadLine();

            Console.WriteLine("Enter b");
            string b = Console.ReadLine();

            while (Input_Check(a, b) == false)
            {
                Console.WriteLine("Enter a");
                a = Console.ReadLine();

                Console.WriteLine("Enter b");
                b = Console.ReadLine();
            }

            Print(Convert.ToInt32(a), Convert.ToInt32(b));
            Console.ReadKey();
        }


        static void Print(int a, int b) => Console.WriteLine(Square(a, b));

        static bool Input_Check(string sa, string sb)
        {
            bool result = true;
            int a;
            int b;
            if (!Int32.TryParse(sb, out a))
                result = false;
            else
                if (!Int32.TryParse(sb, out b))
                result = false;
            else
                if (a <= 0 | b <= 0)
            {
                Console.WriteLine("Enter only integer n > 0");
                result = false;
            }

                return result;
        }

        static int Square(int a, int b) => a * b;
    }
}
