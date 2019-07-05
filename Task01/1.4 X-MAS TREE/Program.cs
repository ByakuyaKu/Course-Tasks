using System;
using System.Collections.Generic;
using ANOTHER_TRIANGLE;

namespace ANOTHER_TRIANGLE
{
    namespace _1._4_X_MAS_TREE
    {
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Enter odd n > 0");
                string n = Console.ReadLine();
                Print(n);
                Console.ReadKey();
            }


            static void Print(string s)
            {
                if (ANOTHER_TRIANGLE.Check_input(s))
                {
                    int k = (Convert.ToInt32(s) - 1) / 2 + 1;
                    string ss = "";
                    for (int j = 0; j < k - 1; j++)
                        ss += " ";
                    Console.WriteLine(ss + "*");
                    for (int i = 3; i <= Convert.ToInt32(s); i += 2)
                    {
                        ss = ss.Remove(ss.Length - 1, 1);
                        for (int j = Triangle(i).Count -1 ; j >= 0; j--)
                            Console.WriteLine(ss + Triangle(i)[j]);
                        
                    }
                }
                else
                    Console.WriteLine("You can enter only odd number > 0");
            }
            static List<string> Triangle(int z)
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

                return strngs;
            }
        }
    }
}

