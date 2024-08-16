using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF01.Entities;
using Microsoft.EntityFrameworkCore;

namespace EF01.Contexts
{
    internal class ITIDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server = DESKTOP-DHMJ427 ; Database = ITIC42 ;  Trusted_Connection = True ; Encrypt = False");
        }

        DbSet <Studentcs> Students { get; set; }

        DbSet<Department> Departments { get; set; }

        DbSet<Instructor> Instructors { get; set; }

        DbSet<Course> Courses { get; set; }

        DbSet<Topic> Topics { get; set; }


    }
}
