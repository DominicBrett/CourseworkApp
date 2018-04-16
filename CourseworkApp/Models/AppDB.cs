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
        public DbSet<Event> Events { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<CourseworkApp.Models.Publication> Publications { get; set; }

        public DbSet<CourseworkApp.Models.ConferenceCall> ConferenceCalls { get; set; }

        public DbSet<CourseworkApp.Models.WorkLocation> WorkLocations { get; set; }

        public DbSet<CourseworkApp.Models.Researcher> Researchers { get; set; }
    }
}