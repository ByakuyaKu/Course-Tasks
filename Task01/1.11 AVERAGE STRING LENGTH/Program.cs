using System;
using System.Collections.Generic;

namespace _1._11_AVERAGE_STRING_LENGTH
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter words");
            string inputstr = Console.ReadLine();
            StringSplit(inputstr);
            Console.ReadKey();
        }

        static void StringSplit(string s)
        {
            double count = 0;
            List<string> elements = new List<string> (s.Split(' ', ',', '.', ':', ';', '\t', '!', '?'));
            for (int i = 0; i < elements.Count; i++)
            {
                if (elements[i] == "")
                {
                    elements.RemoveAt(i);
                }
                count += elements[i].Length;
                Console.Write(elements[i] + " ");
            }
            Console.WriteLine("\n" + "Averege length of inserted words is " + count/elements.Count);
        }
    }
}
