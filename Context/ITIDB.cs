using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFASSS1.Entites;
using Microsoft.EntityFrameworkCore;

namespace EFASSS1.Context
{
    internal class ITIDB :DbContext

    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = DESKTOP-QJQ25HU ; database =ITIDB;Trusted_Connection=True;Encrypt=false   ");
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Crs_Ins> Crs_Ins { get; set; }
        public DbSet<Instructor>  Instructors { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Student_Course>  Student_Courses { get; set; }
        public DbSet<Department> Departments { get; set; }
       
    }
}
