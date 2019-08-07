using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mass1 = new int[] { 2, 3, 4, 5, 1, 7, 8, 2, 6, 9, 1 };
            int[] mass2 = new int[] { 2, 3, 6, 8, 1, 4, 8, 23, 15, 33, 5, 2, 7 };

            Func<int, int, bool> intCompere = Compare;

            mass1.CustomSort(intCompere);
            mass1.Print();

            mass2.CustomSort((int i, int j) => i > j);
            mass2.Print();
        }

        static bool Compare(int n1, int n2) => n1 > n2;
    }
}
public static class IntArrayExtensions
{
    public static void CustomSort(this int[] mass, Func<int, int, bool> compare)
    {
        int temp;
        for (int i = 0; i < mass.Length; i++)
        {
            for (int j = i + 1; j < mass.Length; j++)
            {
                if (compare.Invoke(mass[i], mass[j]))
                {
                    temp = mass[i];
                    mass[i] = mass[j];
                    mass[j] = temp;
                }
            }
        }
    }
    public static void Print(this int[] mass)
    {
        foreach (var i in mass)
            Console.Write(i + "; ");
        Console.Write("\n");
    }
}