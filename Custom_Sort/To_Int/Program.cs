using System;

namespace To_Int
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "-dfghj", str2 = "rtyui", str3 = "-8", str4 = "5", str5 = "0", str6 = "94.45", str7 = "......";

            str1.PrintIfIsPositiveNumber();
            str2.PrintIfIsPositiveNumber();
            str3.PrintIfIsPositiveNumber();
            str4.PrintIfIsPositiveNumber();
            str5.PrintIfIsPositiveNumber();
            str6.PrintIfIsPositiveNumber();
            str7.PrintIfIsPositiveNumber();

        }
    }

    public static class StringExtension
    {
        public static bool IsPositiveNumber(this string str)
        {
            if (str.StartsWith('-'))
                return false;

            foreach (char item in str)
            {
                if (!Char.IsDigit(item) && item == '.' || item.Equals('0'))
                    return false;
            }
            return true;
        }

        public static void PrintIfIsPositiveNumber(this string str)
        {
            if (IsPositiveNumber(str))
                Console.WriteLine($"{ str } is a positive integer number ");
            else
                Console.WriteLine($"{ str } is not a integer positive number ");
        }
    }
}
