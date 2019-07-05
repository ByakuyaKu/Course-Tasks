using System;
using System.Collections.Generic;

namespace _1._10_2D_ARRAY
{
    class Program
    {
        static void Main(string[] args)
        {
            Array_2D();
            Console.ReadKey();
        }

        static bool Odd_check(int z) => z % 2 == 0;

        static void Array_2D()
        {
            List<List<int>> Array = new List<List<int>>();
            List<int> row = new List<int>();               
            int n = 3, sum = 0;

            for (int i = 0; i < n; i++)
            {
                row = new List<int>();
                for (int j = 0; j < n; j++)
                    row.Add(3); 
                Array.Add(row);                              
            }

            for (int i = 0; i < n; i++)                    
            {
                for (int j = 0; j < n; j++)
                {
                    if (Odd_check(i + j))
                        sum += Array[i][j];
                    Console.Write(Array[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("sum = " + sum);
        }
    }
}
