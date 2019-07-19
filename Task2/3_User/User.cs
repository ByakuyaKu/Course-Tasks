using System;
using System.Collections.Generic;
using System.Text;

namespace _3_User
{
    public class User
    {
        public string First_Name { get; set; }
        public string Second_Name { get; set; }
        public string Third_Name { get; set; }

        public DateTime Date_of_Birth { get; set; }

        public int Age
        {
            get
            {
                var today = DateTime.Today;
                var age = today.Year - Date_of_Birth.Year;
                if (Date_of_Birth.Date > today.AddYears(-age))
                    age--;
                return age;
            }
        }

        public User(string Name_1, string Name_2, string Name_3, int year, int month, int day)
        {
            First_Name = Name_1;
            Second_Name = Name_2;
            Third_Name = Name_3;

            DateTime dateofbirth = new DateTime(year: year, month: month, day: day);
            Date_of_Birth = dateofbirth;
        }

        public override string ToString()
        {
            string dateofbirth;
            dateofbirth = string.Format("{0:d}", Date_of_Birth);
            return $"User name {First_Name} {Second_Name} {Third_Name}\nDate of birth: {dateofbirth} Age:{Age}";
        }

        public User()
        {
            First_Name = null;
            Second_Name = null;
            Third_Name = null;
            Date_of_Birth = DateTime.Now;
        }
    }
}
