using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Users.Entities;


namespace Users.DAL
{
    public class AwardsStorage
    {
        public static List<Awards> ListWithAwards { get; set; }

        static AwardsStorage()
        {
            ListWithAwards = new List<Awards>();
        }

        public static void AddAward(Awards award)
        {
            if (ListWithAwards.Any(n => n.Name == award.Name))
                Console.WriteLine("Error!!! This award already exists");
            else
                ListWithAwards.Add(award);
        }

        public static List<Awards> GetAllAwards() => ListWithAwards;

        public static void DeleteAward(Guid id)
        {
            if (!ListWithAwards.Any(n => n.Id == id))
                Console.WriteLine("Error!!! Wrong name");
            else
                ListWithAwards.RemoveAll(n => n.Id == id);
        }

        public static void AddUserToAward(Guid UserId, Guid AwardId) =>
            ListWithAwards.Find(n => n.Id == AwardId).UserNamesWithAward.Add(UsersStorage.ListWithUsers.Find(n => n.UserId == UserId).name);
    }
}
