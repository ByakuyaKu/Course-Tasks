using System;

namespace Custom_Sort_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] mass2 = new string[] { "abc", "Abc", "Bca", "bAc", "aBc", "ABC", "abcd", "abcde", "m", "ABC", "abC", "bca", "ab" };
            Print(mass2);
            Func<string, string, bool> strCompare = Compare;
            CustomSortDemo(mass2, strCompare);
            Print(mass2);
        }

        static void Print(string[] arr)
        {
            foreach (var item in arr)
                Console.Write(item + " ;");
            Console.WriteLine();
        }

        static bool Compare(string str1, string str2)
        {
            if (str1.Length == str2.Length)
            {
                string str1ToLower = str1.ToLower();
                string str2ToLower = str2.ToLower();

                for (int i = 0; i < str1.Length; i++)
                {
                    if (str1ToLower[i] == str2ToLower[i])
                    {
                        if (str1[i] == str2[i])
                            continue;
                        else if (str1[i] > str2[i])
                            return true;
                        else
                            return false;
                    }

                    else if (str1ToLower[i] > str2ToLower[i])
                        return true;
                    else
                        return false;
                }
            }
            return str1.Length > str2.Length;
        }

        static void CustomSortDemo(string[] array, Func<string, string, bool> comparer)
        {
            for (int i = 1; i < array.Length; i++)
            {
                string tmp = array[i];
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
