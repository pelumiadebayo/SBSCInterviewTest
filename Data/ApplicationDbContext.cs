using Microsoft.AspNet.Identity.EntityFramework;
using sbsc.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace sbsc.Data
{
    public class ApplicationDbContext: IdentityDbContext
    {
        //public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        //: base(options)
        //{
        //}

        public DbSet<Course> Courses { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<PracticeExam> PracticeExams { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Support> Supports { get; set; }
        public DbSet<SupportThread> SupportThreads { get; set; }

    }

}