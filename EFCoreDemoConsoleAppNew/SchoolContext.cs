using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreDemoConsoleAppNew
{
    public class SchoolContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

       // public DbSet<Grade> Grades { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer(@"Server=SAI-DELL-PC\SQLEXPRESS;Database=SchoolDB;User Id=sa;Password=password123;Encrypt=False;");
        }
    }
}
