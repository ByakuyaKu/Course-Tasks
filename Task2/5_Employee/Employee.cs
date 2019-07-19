using System;
using System.Collections.Generic;
using System.Text;
using _3_User;

namespace _5_Employee
{
    public class Employee : User
    {
        private int position;
        private int work_exp;

        public Employee()
        {
            position = 0;
            work_exp = 0;
        }

        public Employee(string Name_1, string Name_2, string Name_3, int year, int month, int day, int Position, int WorkExp)
        {
            First_Name = Name_1;
            Second_Name = Name_2;
            Third_Name = Name_3;

            DateTime dateofbirth = new DateTime(year: year, month: month, day: day);
            Date_of_Birth = dateofbirth;

            Position_Check = Position;
            Work_Experience_Check = WorkExp;
        }

        public int Position_Check
        {
            get
            {
                return position;
            }
            set
            {
                if (value >= 0 && value <= 3)
                    position = value;
                else
                    throw new ArgumentException("This position doesn`t exist"); ;
            }
        }


        public int Work_Experience_Check
        {
            get
            {
                return work_exp;
            }
            set
            {
                if (value >= 0 &&  value < Age)
                    work_exp = value;
                else
                    throw new ArgumentException("Work experience can`t be < 0 and > age");
            }
        }

        public string Position => Enum.GetName(typeof(PositionList), position);

        public override string ToString()
        {
            string dateofbirth;
            dateofbirth = string.Format("{0:d}", Date_of_Birth);
            return $"User name {First_Name} {Second_Name} {Third_Name}\nDate of birth: {dateofbirth} Age:{Age} Position: {Position} Work experience: {work_exp}";
        }
    }
    enum PositionList
    {
        Junior_developer = 0,
        Middle_developer = 1,
        Senior_developer = 2,
        Uborshica = 3,
    }
}
