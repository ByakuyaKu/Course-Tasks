using System;

namespace Number_Array_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[] { 2, 3, 5 };
            float[] array2 = new float[] { 1.5f, 2.5f, 1f };

            ArrayExtension.Print(array1);
            ArrayExtension.Print(array2);
        }
    }

    public static class ArrayExtension
    {
        public static int Sum(this int[] array)
        {
            int sum = 0;

            foreach (var item in array)
                sum += item;

            return sum;
        }

        public static float Sum(this float[] array)
        {
            float sum = 0f;

            foreach (var item in array)
                sum += item;

            return sum;
        }

        public static double Sum(this double[] array)
        {
            double sum = 0d;

            foreach (var item in array)
                sum += item;

            return sum;
        }

        public static decimal Sum(this decimal[] array)
        {
            decimal sum = 0m;

            foreach (var item in array)
                sum += item;

            return sum;
        }


        public static void Print<T>(this T[] array)
        {
            foreach (var item in array)
                Console.Write(item + "  ");
            Console.WriteLine();
        }
    }
}
