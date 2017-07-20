using SquareTeamsAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SquareTeamsAPI.Dao
{
    public class UserTeamDao
    {
        public static UserTeam UserGet(int userId, int teamId)
        {

            using (var model = new EntityDataHelper())
            {
                var userTeam = model.UserTeam.Where(m => m.UserId == userId && m.TeamId == teamId).SingleOrDefault();
                return userTeam;
            }

        }



    }
}
