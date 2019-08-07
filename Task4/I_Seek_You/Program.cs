using System;
using System.Collections.Generic;
using System.Linq;

namespace I_Seek_You
{
    class Program
    {
        static void Main(string[] args)
        {
            SearchForAllPositives searchFor = new SearchForAllPositives();
            int[] array1 = new int[] { -1, -2, 1, 2, 3 };

            int[] array2 = searchFor.SimpleSearchForPositive(array1);
            searchFor.Print(array2);

            Predicate<int> deleg = IsPositive;
            int[] array3 = searchFor.SearchForPositiveUsingDelegate(array1, deleg);
            searchFor.Print(array3);

            int[] array4 = searchFor.SearchForPositiveUsingDelegate(array1, delegate (int n) { return n > 0; });
            searchFor.Print(array4);

            int[] array5 = searchFor.SearchForPositiveUsingDelegate(array1, n => n > 0);
            searchFor.Print(array5);

            int[] array6 = searchFor.SearchForPositiveUsingLINQ(array1);
            searchFor.Print(array6);
        }

        public static bool IsPositive(int n) => n > 0;
    }

    public class SearchForAllPositives
    {
        public int[] SimpleSearchForPositive(int[] mass)
        {
            List<int> result = new List<int>();

            for (int i = 0; i < mass.Length; i++)
                if (mass[i] > 0)
                    result.Add(mass[i]);

            return result.ToArray();
        }

        public int[] SearchForPositiveUsingDelegate(int[] mass, Predicate<int> isPositive)
        {
            List<int> result = new List<int>();

            for (int i = 0; i < mass.Length; i++)
                if (isPositive(mass[i]))
                    result.Add(mass[i]);

            return result.ToArray();
        }

        public int[] SearchForPositiveUsingLINQ(int[] mass) => mass.Where(n => n > 0).ToArray();

        public void Print<T>(T[] array)
        {
            foreach (var item in array)
                Console.Write(item + "; ");
            Console.WriteLine();
        }
    }
}