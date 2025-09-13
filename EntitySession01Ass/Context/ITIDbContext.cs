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

            //modelBuilder.Entity<Department>()
            //.HasOne(d => d.Instructor)
            //.WithOne(i => i.Department) 
            //.HasForeignKey<Department>(d => d.Ins_ID)
            //.OnDelete(DeleteBehavior.NoAction);

            //modelBuilder.Entity<Instructor>()
            //  .HasOne(i => i.Department)
            //  .WithOne(d => d.Instructor) 
            //  .HasForeignKey<Instructor>(i => i.Dept_ID)
            //  .OnDelete(DeleteBehavior.NoAction);

            // Configure composite keys for junction tables
            modelBuilder.Entity<Stud_Course>()
                .HasKey(sc => new { sc.stud_ID, sc.course_ID });

            modelBuilder.Entity<Course_Inst>()
                .HasKey(ci => new { ci.inst_ID, ci.course_ID });

            #region ONE-TO-MANY RELATIONSHIPS
            // Department -> Students (1:*)
            modelBuilder.Entity<Department>()
                .HasMany(d => d.Students)
                .WithOne()
                .HasForeignKey(s => s.Dep_Id)
                .OnDelete(DeleteBehavior.Restrict);

            // Department -> Instructors (1:*)
            modelBuilder.Entity<Department>()
                .HasMany(d => d.Instructors)
                .WithOne(i => i.Department)
                .HasForeignKey(i => i.Dept_ID)
                .OnDelete(DeleteBehavior.Restrict);

            // Department has one Manager (Instructor)
            modelBuilder.Entity<Department>()
                .HasOne(d => d.Manager)
                .WithMany()
                .HasForeignKey(d => d.Ins_ID)
                .OnDelete(DeleteBehavior.Restrict);

            // Topic -> Courses (1:*)
            modelBuilder.Entity<Topic>()
                .HasMany(t => t.Courses)
                .WithOne(c => c.Topic)
                .HasForeignKey(c => c.Top_ID)
                .OnDelete(DeleteBehavior.Restrict);
            #endregion
            #region MANY-TO-MANY RELATIONSHIPS
            // Student <-> Course (through Stud_Course)
            modelBuilder.Entity<Stud_Course>()
                .HasOne(sc => sc.Student)
                .WithMany(s => s.StudentCourses)
                .HasForeignKey(sc => sc.stud_ID)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Stud_Course>()
                .HasOne(sc => sc.Course)
                .WithMany(c => c.StudentCourses)
                .HasForeignKey(sc => sc.course_ID)
                .OnDelete(DeleteBehavior.Cascade);

            // Instructor <-> Course (through Course_Inst)
            modelBuilder.Entity<Course_Inst>()
                .HasOne(ci => ci.Instructor)
                .WithMany(i => i.CourseInstructors)
                .HasForeignKey(ci => ci.inst_ID)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Course_Inst>()
                .HasOne(ci => ci.Course)
                .WithMany(c => c.CourseInstructors)
                .HasForeignKey(ci => ci.course_ID)
                .OnDelete(DeleteBehavior.Cascade);
            #endregion
            // Configure table names
            modelBuilder.Entity<Stud_Course>().ToTable("Stud_Course");
            modelBuilder.Entity<Course_Inst>().ToTable("Course_Inst");

            // Data Seed
            SeedData(modelBuilder);
        }
        private void SeedData(ModelBuilder modelBuilder)
        {
            // Manual Data Seed
            SeedTopics(modelBuilder);
            SeedDepartments(modelBuilder);
            SeedInstructors(modelBuilder);
            SeedStudents(modelBuilder);
            SeedCourses(modelBuilder);
            SeedStudentCourses(modelBuilder);
            SeedCourseInstructors(modelBuilder);
        }
        private void SeedTopics(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Topic>().HasData(
                new Topic { ID = 1, Name = "Programming" },
                new Topic { ID = 2, Name = "Database" },
                new Topic { ID = 3, Name = "Web Development" },
                new Topic { ID = 4, Name = "Networking" }
            );
        }

        private void SeedDepartments(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>().HasData(
                new Department { ID = 1, Name = "Computer Science", HiringDate = DateTime.Now.AddYears(-5) },
                new Department { ID = 2, Name = "Information Technology", HiringDate = DateTime.Now.AddYears(-3) },
                new Department { ID = 3, Name = "Software Engineering", HiringDate = DateTime.Now.AddYears(-2) }
            );
        }

        private void SeedInstructors(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Instructor>().HasData(
                new Instructor { ID = 1, Name = "Dr. Ahmed Ali", Address = "Cairo", Salary = 15000, Dept_ID = 1 },
                new Instructor { ID = 2, Name = "Prof. Mohamed Hassan", Address = "Alexandria", Salary = 18000, Dept_ID = 1 },
                new Instructor { ID = 3, Name = "Dr. Sarah Smith", Address = "Giza", Salary = 16000, Dept_ID = 2 }
            );
        }

        private void SeedStudents(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(
                new Student { ID = 1, FName = "John", LName = "Doe", Age = 20, Dep_Id = 1, Address = "Cairo" },
                new Student { ID = 2,  FName = "Jane", LName = "Smith", Age = 21, Dep_Id = 1, Address = "Alexandria" },
                new Student { ID = 3, FName = "Mike", LName = "Johnson", Age = 22, Dep_Id = 2, Address = "Giza" }
            );
        }

        private void SeedCourses(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().HasData(
                new Course { ID = 1, Name = "C# Programming", Duration = 60, Description = "Learn C# fundamentals", Top_ID = 1 },
                new Course { ID = 2, Name = "SQL Server", Duration = 45, Description = "Database management", Top_ID = 2 },
                new Course { ID = 3, Name = "ASP.NET Core", Duration = 75, Description = "Web development", Top_ID = 3 }
            );
        }

        private void SeedStudentCourses(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Stud_Course>().HasData(
                new Stud_Course { stud_ID = 1, course_ID = 1, Grade = 85.5m },
                new Stud_Course { stud_ID = 1, course_ID = 2, Grade = 90.0m },
                new Stud_Course { stud_ID = 2, course_ID = 1, Grade = 78.0m },
                new Stud_Course { stud_ID = 3, course_ID = 3, Grade = 92.5m }
            );
        }

        private void SeedCourseInstructors(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course_Inst>().HasData(
                new Course_Inst { inst_ID = 1, course_ID = 1, evaluate = "Excellent course" },
                new Course_Inst { inst_ID = 2, course_ID = 2, evaluate = "Good material" },
                new Course_Inst { inst_ID = 3, course_ID = 3, evaluate = "Challenging but rewarding" }
            );
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
