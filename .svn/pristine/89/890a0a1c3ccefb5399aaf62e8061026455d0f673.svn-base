using SquareTeamsAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SquareTeamsAPI.Dao
{
    public class TeamDao
    {

        public static Team TeamGet(int id)
        {

            using (var model = new EntityDataHelper())
            {
                var team = model.Team.Where(m => m.Id == id).SingleOrDefault();
                return team;
            }

        }

        public static int TeamModify(int id, String name)
        {
            using (var model = new EntityDataHelper())
            {
                if (id > 0)
                {
                    var entity = (from t in model.Team where t.Id == id select t).SingleOrDefault();

                    if (entity != null)
                    {
                        entity.Name = name;

                        model.SaveChanges();

                        return id;

                    }
                }
                else
                {
                    var entity = new Team()
                    {
                        Name = name,
                        Deleted = false,
                    };
                    model.Add(entity);
                    model.SaveChanges();

                    return entity.Id;
                }
            }

            return id;
        }

        public static int TeamDelete(int id)
        {
            using (var model = new EntityDataHelper())
            {
                if (id > 0)
                {
                    var entity = (from t in model.Team where t.Id == id select t).SingleOrDefault();

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
