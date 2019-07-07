using System;

namespace _1._12_CHAR_DOUBLER
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter firs string");
            string inputstr1 = Console.ReadLine();
            Console.WriteLine("Enter second string (doubler)");
            string inputstr2 = Console.ReadLine();
            Char_Doubler(inputstr1, inputstr2);
            Console.ReadKey();
        }

        static void Char_Doubler(string s1, string s2)
        {
            string output = "";
            for (int i = 0; i < s2.Length; i++)
            {
                for (int j = 0; j < s1.Length; j++)
                {
                    if (s1[j] == s2[i])
                        output = s1.Insert(j, s2[i].ToString()); 
                }
                s1 = output;
            }
            Console.WriteLine(output);
        }
    }
}
