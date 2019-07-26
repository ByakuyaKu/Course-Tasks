using System;
using System.Collections.Generic;

namespace _1_Lost
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> People_in_Ring = Lost(10);
            for (int i = 0; i < People_in_Ring.Count; i++)
                Console.WriteLine(People_in_Ring[i]);
            Console.ReadKey();
        }

        static List<int> Lost(int number_of_people)
        {
            List<int> People_in_Ring = new List<int>();
            for (int j = 0; j < number_of_people; j++)
                People_in_Ring.Add(j);

            int i = 1;
            while (People_in_Ring.Count > 1)
            {
                People_in_Ring.RemoveAt(i);
                i++;
                if (i == People_in_Ring.Count)
                {
                    i = 1;
                    continue;
                }
                else if (i == People_in_Ring.Count - 1) 
                {
                    i = 0;
                    continue;
                }
            }
            return People_in_Ring;
        }

    }
}
