using System;
using System.Collections.Generic;
using System.Linq;

namespace _2_Word_Frequency
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Jmishenko Valerii Albertovuch gaga gaga";
            Console.WriteLine(text.FrequencyCount("gaga"));
            Console.ReadKey();
        }

    }
    public static class StringExtending
    {
        private static List<string> SplitedString(string s)
        {
            s = s.ToLower();
            List<string> str = new List<string>(s.Split(new char[] { ' ', '.' }, StringSplitOptions.RemoveEmptyEntries));
            return str;
        }

        public static int FrequencyCount(this string s, string search)
        {
            int i = 0;
            search = search.ToLower();
            List<string> ListOfWords = SplitedString(s);
            var SearchValue = from word in ListOfWords
                              where word == search
                              select word;
            foreach (string str in SearchValue)
                i += 1;
            return i;
        }
    }
}
