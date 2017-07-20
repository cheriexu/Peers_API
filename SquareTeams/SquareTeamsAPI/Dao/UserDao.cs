using SquareTeamsAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SquareTeamsAPI.Dao
{
    public class UserDao
    {
        public static User UserGet(int id)
        {

            using (var model = new EntityDataHelper())
            {
                var user = model.User.Where(m => m.Id == id).SingleOrDefault();
                return user;
            }

        }

        public static User UserGet(string email)
        {

            using (var model = new EntityDataHelper())
            {
                var user = model.User.Where(m => m.Email == email).SingleOrDefault();
                return user;
            }

        }

        public static int UserModify(int id, String email, String firstName, String lastName)
        {            
            using (var model = new EntityDataHelper())
            {
                if (id > 0)
                {
                    var entity = (from u in model.User where u.Id == id && u.Email == email select u).SingleOrDefault();

                    if (entity != null)
                    {
                        entity.FirstName = firstName;
                        entity.LastName = lastName;

                        model.SaveChanges();

                        return id;

                    }
                }
                else
                {
                    var entity = new User()
                    {
                        Email = email,
                        FirstName = firstName,
                        LastName = lastName,
                        EmailVerfied = false,
                        Deleted = false,
                    };
                    model.Add(entity);
                    model.SaveChanges();

                    return entity.Id;
                }
            }

            return id;
        }

        public static int UserDelete(int id)
        {            
            using (var model = new EntityDataHelper())
            {
                if (id > 0)
                {
                    var entity = (from u in model.User where u.Id == id select u).SingleOrDefault();

                    if (entity != null)
                    {
                        entity.Deleted = true;
                        model.SaveChanges();

                        return id;

                    }
                }
            }

            return 0;
        }
    }
}
