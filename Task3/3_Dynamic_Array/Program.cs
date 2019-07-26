using System;
using System.Collections.Generic;
using System.Collections;

namespace _3_Dynamic_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new DynamicArray<int>(new int[] { 1, 2, 3, 4, 5 });
            arr.AddRange(new int[] { 8, 9, 10 });
            arr.Add(10000);
            arr.Insert(0, 8);
            arr.Remove(0);

            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\nCapacity: " + arr.Capacity);
            Console.WriteLine("Length: " + arr.Length);
            Console.WriteLine(arr[0]);
        }

    }
}