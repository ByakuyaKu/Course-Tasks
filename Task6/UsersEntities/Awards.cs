using System;
using System.Collections.Generic;
using System.Text;

namespace Users.Entities
{
    public class Awards
    {
        public string Name { get; private set; }
        public Guid Id { get; private set; }
        public List<string> UserNamesWithAward;

        public List<string> userNamesWithAward
        {
            get
            {
                List<string> List = new List<string>();
                return List;
            }
            private set { }
        }

        public Awards(string name)
        {
            Name = name;
            Id = Guid.NewGuid();
            UserNamesWithAward = userNamesWithAward;
        }

        private string Print(List<string> UserNamesWithAward)
        {
            String str = "";
            foreach (string item in UserNamesWithAward)
                str += item + "\t";
            return str;
        }

        public override string ToString()
        {
            return $"ID: {Id} Award name: {Name}\t \n" +
                $"Users with this award: {Print(UserNamesWithAward)}\n";
        }
    }
}
