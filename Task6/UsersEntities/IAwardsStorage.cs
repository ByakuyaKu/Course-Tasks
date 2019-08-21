using System;
using System.Collections.Generic;
using System.Text;

namespace Users.Entities
{
    public interface IAwardStorage
    {
        void AddAward(Awards award);

        List<Awards> GetAllAwards();

        void DeleteAward(Guid id);

        void AddUserToAward(Guid UserId, Guid AwardId);
    }
}
