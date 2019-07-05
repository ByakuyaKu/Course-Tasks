using System;
using System.Collections.Generic;

namespace ANOTHER_TRIANGLE
{
     public class ANOTHER_TRIANGLE
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Enter odd n > 0");
            string n = Console.ReadLine();
            Print(n);
            Console.ReadLine();
        }

        private static void Print(string s)
        {
            if (Check_input(s))
                Triangle(Convert.ToInt32(s));
            else
                Console.WriteLine("You can enter only odd number > 0");
        }

        public static bool Odd_check(int z) => z % 2 != 0;

        public static bool Check_input(string s)
        {
            bool result = true;

            int a;
            if (Int32.TryParse(s, out a))
                if (!Odd_check(Convert.ToInt32(s)) | Convert.ToInt32(s) <= 0) 
                    result = false;
            return result;
        }

        private static void Triangle(int z)
        {
            List<string> strngs = new List<string>();
            string s = null;

            for (int i = 0; i < z; i++)
            {
                s += "*";
            }

            for (int i = 0; i < z; i++)
            {
                int right_index = --z; // i - left index
                strngs.Add(s);
                s = s.Remove(i, 1).Insert(i, " ").Remove(right_index, 1).Insert(right_index, " ");
                right_index--;
            }

            for (int i = strngs.Count - 1; i >= 0; i--) 
                Console.WriteLine(strngs[i]);
        }
    }
}