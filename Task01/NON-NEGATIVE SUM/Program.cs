using System;
using System.Collections.Generic;
using ARRAY_PROCESSING;

namespace ARRAY_PROCESSING
{
    namespace _1._8_NO_POSITIVE
    {
        class Program
        {
            private static void Main(string[] args)
            {
                List<int> Random_array = ARRAY_PROCESSING.Random_Array();
                ARRAY_PROCESSING.Print(Random_array);
                Non_Negative_Sum(Random_array);
                Console.ReadKey();
            }

            static void Non_Negative_Sum(List<int> arr)
            {
                int sum = 0;
                for (int i = 0; i < arr.Count; i++)
                {
                    if (arr[i] > 0)
                        sum += arr[i];
                }
                Console.WriteLine("sum = " + sum);
            }
        }
    }
}