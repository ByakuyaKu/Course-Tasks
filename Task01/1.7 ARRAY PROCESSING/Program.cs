using System;
using System.Collections.Generic;

namespace ARRAY_PROCESSING
{
    public class ARRAY_PROCESSING
    {
        private static void Main(string[] args)
        {
            List<int> Random_array = Random_Array();
            Print(Random_array);
            Print(SelectionSort(Random_array));
            Max(Random_array);
            Min(Random_array);
            Console.ReadLine();
        }

        public static List<int> SelectionSort(List<int> arr)
        {
            int index, temp;
            for (int i = 0; i < arr.Count; ++i)
            {
                index = i;
                temp = arr[i];
                for (int j = i + 1; j < arr.Count; ++j)
                {
                    if (arr[j] < temp)
                    {
                        index = j;
                        temp = arr[j];
                    }
                }
                arr[index] = arr[i];
                arr[i] = temp;
            }
            return arr;
        }

        private static void Max(List<int> Arr)
        {
            int tmp = -21;
            for (int i = 0; i < Arr.Count; i++)
            {
                if (Arr[i] > tmp)
                    tmp = Arr[i];
            }
            Console.WriteLine("Max =" + tmp);
        }

        private static void Min(List<int> Arr)
        {
            int tmp = 21;
            for (int i = 0; i < Arr.Count; i++)
            {
                if (Arr[i] < tmp)
                    tmp = Arr[i];
            }
            Console.WriteLine("Min =" + tmp);
        }

        /// <summary>
        /// Print array
        /// </summary>
        /// <param name="Arr"></param>
         public static void Print(List<int> Arr)
        {
            for (int i = 0; i < Arr.Count; i++)
                Console.Write(Arr[i] + " ");
            Console.WriteLine();
        }


        /// <summary>
        /// Generate array[1-15] of random integers with range from -20 to 20
        /// </summary>
        /// <returns></returns>
        public static List<int> Random_Array()
        {
            List<int> Arr = new List<int>();

            Random rnd = new Random();
            for (int i = 0; i < 15; i++) 
            {
                int Random_Number = rnd.Next(-20, 20);
                Arr.Add(Random_Number);
            }
            return Arr;
        }
    }
}
