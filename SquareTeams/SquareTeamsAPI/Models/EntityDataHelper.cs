using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

/// <summary>
/// Summary description for EntityDataHelper
/// </summary>
/// 
namespace SquareTeamsAPI.Models
{

    public class EntityDataHelper : DbContext
    {
        public EntityDataHelper() : base()
        {

            //ObjectContext.CommandTimeout = 300;

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {            
            optionsBuilder.UseSqlServer(Startup.ConnectionString);
        }

        public DbSet<LoginTrack> LoginTrack { get; set; }
        public DbSet<User> User { get; set; }

        public DbSet<Team> Team { get; set; }
        public DbSet<UserTeam> UserTeam { get; set; }

    }

}