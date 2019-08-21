using System;
using System.Collections.Generic;
using System.Text;
using Users.Entities;
using Users.DAL;

namespace Users.BLL
{
    public class UsersManager
    {

        public void AddUser(Userss user) => UsersStorage.AddUser(user);

        public List<Userss> GetAllUsers() => UsersStorage.GetAllUsers();

        public void DeleteUser(Guid id) => UsersStorage.DeleteUser(id);


        public void AddAward(Awards award) => AwardsStorage.AddAward(award);

        public void DeleteAward(Guid id) => AwardsStorage.DeleteAward(id);

        public List<Awards> GetAllAwards() => AwardsStorage.GetAllAwards();

        public void AddAwardToUser(Guid UserId, Guid AwardId)
        {
            if (UsersStorage.AddAwardToUser(UserId, AwardId))
                AwardsStorage.AddUserToAward(UserId, AwardId);
        }


    }
}
