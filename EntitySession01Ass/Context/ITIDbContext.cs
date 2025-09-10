using EntitySession01Ass.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitySession01Ass.Context
{
    internal class ITIDbContext : DbContext
    {
        public ITIDbContext() : base()
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            optionsBuilder.UseSqlServer("Server = . ; Database = ITIDb; Trusted_Connection = true; TrustServerCertificate= true");

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>()
            .HasOne(d => d.Instructor)
            .WithOne(i => i.Department) 
            .HasForeignKey<Department>(d => d.Ins_ID)
            .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Instructor>()
              .HasOne(i => i.Department)
              .WithOne(d => d.Instructor) 
              .HasForeignKey<Instructor>(i => i.Dept_ID)
              .OnDelete(DeleteBehavior.NoAction);
        }
        public DbSet<Student> Students { get; set; }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Stud_Course> StudentCourses { get; set; }
        public DbSet<Course_Inst> CourseInstructors { get; set; }
    }
}
