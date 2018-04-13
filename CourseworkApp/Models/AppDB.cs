using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using CourseworkApp.Models;

namespace CourseworkApp.Models
{
    public class AppDB : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Report> Reports { get; set; }

        public System.Data.Entity.DbSet<CourseworkApp.Models.Publication> Publications { get; set; }

        public System.Data.Entity.DbSet<CourseworkApp.Models.ConferenceCall> ConferenceCalls { get; set; }

        public System.Data.Entity.DbSet<CourseworkApp.Models.WorkLocation> WorkLocations { get; set; }

        public System.Data.Entity.DbSet<CourseworkApp.Models.Researcher> Researchers { get; set; }
    }
}