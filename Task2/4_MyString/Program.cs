using System;

namespace _4_MyString
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "sdfghjklp";
            MyString str1 = new MyString(str);
            MyString str2 = new MyString(str);

            Console.WriteLine(str1 + str2);
            Console.WriteLine(str1.Search('p'));
            Console.WriteLine(str1 != str2);

            Console.ReadKey();
        }
    }
}
