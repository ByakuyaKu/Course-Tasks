using System;

namespace Custom_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = InputRandomArray();
            PrintArray(array);
            Func<int, int, bool> compare = Compare;
            CustomSort(array, compare);
            PrintArray(array);
        }

        static void PrintArray<T>(T[] array)
        {
            foreach(var item in array)
                Console.Write(item + "; ");
            Console.WriteLine();
        }

        static int[] InputRandomArray()
        {
            int[] arr = new int[5];
            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
                arr[i] = rand.Next(0, 10);
            return arr;
        }

        static bool Compare(int num1, int num2) => num1 > num2;

        static void CustomSort<T>(T[] array, Func<T, T, bool> comparer)
        {
            for (int i = 1; i < array.Length; i++)
            {
                T tmp = array[i];
                int j = i;
                while (j > 0 && comparer.Invoke(array[j - 1], tmp))
                {
                    array[j] = array[j - 1];
                    j--;
                }
                array[j] = tmp;
            }
        }
    }
}