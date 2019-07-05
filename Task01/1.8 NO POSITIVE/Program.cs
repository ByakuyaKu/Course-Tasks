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
                int[,,] Array = No_Positive();
                Print_array(Array);
                Print_array(Swap_Zero(Array));
                Console.ReadKey();
            }

            static int[,,] Swap_Zero(int[,,] Arr)
            {
                for (int i = 0; i < Arr.GetLength(2); i++)
                    for (int j = 0; j < Arr.GetLength(2); j++)
                        for (int k = 0; k < Arr.GetLength(2); k++)
                            if (Arr[i, j, k] > 0)
                                Arr[i, j, k] = 0;
                            return Arr;
            }

            static void Print_array(int[,,] Arr)
            {
                for (int i = 0; i < Arr.GetLength(2); i++)
                    for (int j = 0; j < Arr.GetLength(2); j++)
                        for (int k = 0; k < Arr.GetLength(2); k++)
                            Console.Write(Arr[i, j, k] + " ");
                Console.WriteLine();
            }

            static int[,,] No_Positive()
            {
                int[,,] Arr;
                Arr = new int[2, 2, 2] { { { 0, 1}, { 3, 5} },
                                           { {-5, 12}, {-6, 10} } };
                return Arr;
            }
        }
    }
}
