using System;
using System.Collections.Generic;

namespace _1._5_SUM_OF_NUMBERS
{
    class Program
    {
        static void Main(string[] args)
        {
            Sum_of_Numbers();
            Console.ReadKey();
        }

        static bool Dev_by_5_check(int z) => z % 5 == 0;
        static bool Dev_by_3_check(int z) => z % 3 == 0;
        static void Sum_of_Numbers()
        {
            int sum = 0;
            for (int i = 0; i < 1000; i++)
            {
                if (Dev_by_5_check(i) | Dev_by_3_check(i))
                sum += i;
            }
            Console.WriteLine(sum);
        }
    }
}
