using System;
using System.Collections.Generic;
using System.Text;

namespace Users.Entities
{
    public interface IUsersStorage
    {
        void AddUser(Userss user);

        List<Userss> GetAllUsers();

        void DeleteUser(Guid id);

        bool AddAwardToUser(Guid UserId, Guid AwardId);
    }
}
