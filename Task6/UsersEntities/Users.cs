using System;
using System.Collections.Generic;
using System.Text;

namespace Users.Entities
{
    public class Userss
    {
        public Guid UserId { get; private set; }
        public string name { get; set; }
        private DateTime DateOfBirth { get; set; }

        private int age;

        public List<string> Awards { get; set; }

        public int Age
        {
            get
            {
                age = DateTime.Today.Year - DateOfBirth.Year;
                if (DateOfBirth.Date > DateTime.Today.AddYears(-age))
                    age--;
                return age;
            }

            private set { }
        }


        public Userss(string name, DateTime birth)
        {
            this.name = name;
            UserId = Guid.NewGuid();
            DateOfBirth = birth;
            Age = age;
        }

        public override string ToString()
        {
            string dateofbirth = string.Format("{0:d}", DateOfBirth);
            return $"ID: {UserId} Имя пользователя: {name}\t Дата рождения: {dateofbirth}\tВозраст:{Age}\n" +
                $"{Awards}";
        }
    }
}
