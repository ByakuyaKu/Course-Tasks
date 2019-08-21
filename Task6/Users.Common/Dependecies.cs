using System;
using System.Collections.Generic;
using System.Text;
using Users.DAL;
using Users.Entities;

namespace Users.Common
{
    public static class Dependecies
    {
        public static IUsersStorage UserStorage { get; } = new UsersStorage();
        public static IAwardStorage AwardStorage { get; } = new AwardsStorage();
    }
}
