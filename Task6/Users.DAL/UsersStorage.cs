using System;
using System.Collections.Generic;
using System.Text;
using Users.Entities;
using System.Linq;

namespace Users.DAL
{
    public class UsersStorage : IUsersStorage
    {
        public static List<Userss> ListWithUsers { get; set; }

        public UsersStorage()
        {
            ListWithUsers = new List<Userss>();
        }


        public void AddUser(Userss user)
        {
            if (ListWithUsers.Any(n => n.name == user.name))
                Console.WriteLine("Error!!! This user already exists");
            else
                ListWithUsers.Add(user);
        }

        public List<Userss> GetAllUsers() => ListWithUsers;

        public void DeleteUser(Guid id)
        {
            if (!ListWithUsers.Any(n => n.UserId == id))
                Console.WriteLine("Error!!! Wrong name");
            else
                ListWithUsers.RemoveAll(n => n.UserId == id);
        }

        public bool AddAwardToUser(Guid UserId, Guid AwardId)
        {
            if (!ListWithUsers.Any(n => n.UserId == UserId))
                Console.WriteLine("Error!!! Wrong user id");
            else if (!AwardsStorage.ListWithAwards.Any(n => n.Id == AwardId))
                Console.WriteLine("Error!!! Wrong award id");
            else
            {
                ListWithUsers.Find(n => n.UserId == UserId).Awards.Add(AwardsStorage.ListWithAwards.Find(n => n.Id == AwardId).Name);
                return true;
            }
            return false;
        }
    }
}
