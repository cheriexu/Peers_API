using SquareTeamsAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// Summary description for PeerServiceDao
/// </summary>
/// 

namespace SquareTeamsService.Dao
{
    public class LoginTrackDao
    {
        public static int LoginTrackInsert(string email, string firstName, string lastName)
        {
            int count = 0;

            try
            {
                using (var model = new EntityDataHelper())
                {
                    model.LoginTrack.Add(new LoginTrack()
                    {
                        Email = email,
                        FirstName = firstName,
                        LastName = lastName,
                        LoginTime = DateTime.Now
                    }
                    );
                    count = model.SaveChanges();
                }
            }
            catch (Exception e)
            {

            }

            return count;
        }

        public static int LoginTrackCount(string email)
        {
            int count = 0;
            List<LoginTrack> logins;

            try
            {
                using (var model = new EntityDataHelper())
                {
                    logins = model.LoginTrack.Where(m => m.Email == email).ToList();
                }
                count = logins.Count;
            }
            catch (Exception e)
            {

            }

            return count;
        }
        
    }

}

