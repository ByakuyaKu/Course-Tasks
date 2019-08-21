using System;
using System.Collections.Generic;
using System.Text;

namespace Users.Entities
{
    public class Userss
    {
        public Guid UserId { get; private set; }
        public string name { get; set; }
        public DateTime DateOfBirth { get; set; }

        private int age;

        public List<string> Awards;

        public List<string> awards
        {
            get
            {
                List<string> List = new List<string>();
                return List;
            }
            private set { }
        }

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
            Awards = awards;
        }

        private string Print(List<string> Awards)
        {
            String str = "";
            foreach (string item in Awards)
                str += item + "\t";
            return str;
        }

        public override string ToString()
        {
            string dateofbirth = string.Format("{0:d}", DateOfBirth);
            return $"ID: {UserId} Имя пользователя: {name}\t Дата рождения: {dateofbirth}\tВозраст:{Age}\n" +
                $"User's awards: {Print(Awards)}\n";
        }
    }
}
