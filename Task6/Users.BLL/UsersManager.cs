using System;
using System.Collections.Generic;
using System.Text;
using Users.Entities;
using Users.DAL;
using Users.Common;

namespace Users.BLL
{
    public class UsersManager
    {

        private static IUsersStorage UserStorage => Dependecies.UserStorage;
        private static IAwardStorage AwardStorage => Dependecies.AwardStorage;

        public void AddUser(Userss user) => UserStorage.AddUser(user);

        public List<Userss> GetAllUsers() => UserStorage.GetAllUsers();

        public void DeleteUser(Guid id) => UserStorage.DeleteUser(id);


        //public void AddAward(Awards award) => AwardStorage.AddAward(award);

        //public void DeleteAward(Guid id) => AwardStorage.DeleteAward(id);

        //public List<Awards> GetAllAwards() => AwardStorage.GetAllAwards();

        public void AddAwardToUser(Guid UserId, Guid AwardId)
        {
            if (UserStorage.AddAwardToUser(UserId, AwardId))
                AwardStorage.AddUserToAward(UserId, AwardId);
        }


    }
}
