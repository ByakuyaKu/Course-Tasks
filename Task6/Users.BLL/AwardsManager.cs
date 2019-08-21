using System;
using System.Collections.Generic;
using System.Text;
using Users.Entities;
using Users.DAL;
using Users.Common;

namespace Users.BLL
{
    public class AwardsManager
    {
        private static IAwardStorage AwardStorage => Dependecies.AwardStorage;

        public void AddAward(Awards award) => AwardStorage.AddAward(award);

        public void DeleteAward(Guid id) => AwardStorage.DeleteAward(id);

        public List<Awards> GetAllAwards() => AwardStorage.GetAllAwards();

    }
}
