using System;
using System.Collections.Generic;
using System.Text;

namespace _4_MyString
{
    public class MyString
    {
        public char[] Mass_of_Char { get; set; }

        public MyString()
        {
            Mass_of_Char = new char[0];
        }

        public MyString(int i)
        {
            Mass_of_Char = new char[i];
        }

        public MyString(char[] massofchar)
        {
            Mass_of_Char = new char[massofchar.Length];
            Mass_of_Char = massofchar;
        }

        public MyString(string str)
        {
            Mass_of_Char = new char[str.Length];

            for (int i = 0; i < str.Length; i++)
                Mass_of_Char[i] = str[i];
        }

        public char this[int i]
        {
            get => Mass_of_Char[i];
            set => Mass_of_Char[i] = value;
        }

        public int Search(char Searching_Char)
        {
            for (int i = 0; i < Mass_of_Char.Length; i++)
                if (Mass_of_Char[i] == Searching_Char)
                    return i + 1;

            return -1;
        }

        public static MyString operator +(MyString str1, MyString str2)
        {
            MyString New_My_Str = new MyString(str1.Length + str2.Length);

            for (int i = 0; i < str1.Length; i++)
                New_My_Str.Mass_of_Char[i] = str1.Mass_of_Char[i];

            for (int j = 0; j < str2.Length; j++)
                New_My_Str.Mass_of_Char[str1.Length + j] = str2.Mass_of_Char[j];

            return New_My_Str;
        }

        public static bool MyEquals(MyString str1, MyString str2)
        {
            if (str1.Length != str2.Length)
                return false;
            else
            for (int i = 0; i < str1.Length; i++)
                if (str1.Mass_of_Char[i] != str2.Mass_of_Char[i])
                    return false;

            return true;
        }

        public static bool operator !=(MyString mystr1, MyString mystr2) => !MyString.MyEquals(mystr1, mystr2);
        public static bool operator ==(MyString mystr1, MyString mystr2) => MyString.MyEquals(mystr1, mystr2);

        public int Length => Mass_of_Char.Length;

        public static MyString ToMyString(char[] MassOfChar) => new MyString(MassOfChar);
        public static MyString ToMyString(string str) => new MyString(str);
        public static char[] ToChar(MyString mystr) => mystr.Mass_of_Char;

        public override string ToString()
        {
            return new string(Mass_of_Char);
        }
    }
}
