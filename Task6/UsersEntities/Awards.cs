using System;
using System.Collections.Generic;
using System.Text;

namespace Users.Entities
{
    public class Awards
    {
        public string Name { get; private set; }
        public Guid Id { get; private set; }
        public List<string> UserNamesWithAward { get; private set; }

        public Awards(string name)
        {
            Name = name;
            Id = Guid.NewGuid();
            //UserNamesWithAward = users;
        }

        public override string ToString()
        {
            return $"ID: {Id} Award name: {Name}\t \n" +
                $"{UserNamesWithAward}";
        }
    }
}
