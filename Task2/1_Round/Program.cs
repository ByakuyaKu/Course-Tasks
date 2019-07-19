using System;

namespace _1_Round
{
    class Program
    {
        static void Main(string[] args)
        {
            Round Circle1 = new Round(-3, 1, 4);
            Round Circle2 = new Round();

            Console.WriteLine(Circle1 + "\n\n" + Circle2);
            Console.ReadKey();
        }
    }
}
