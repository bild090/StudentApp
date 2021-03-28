using Microsoft.EntityFrameworkCore;
using StudentApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentApp.EntityFrameworkCore
{
    public class StudentContext : DbContext
    {

        public StudentContext(DbContextOptions<StudentContext> options)
            : base(options)
        {
        }
        public DbSet<Student> students { get; set; }
        public DbSet<Level> levels { get; set; }

    }
}
