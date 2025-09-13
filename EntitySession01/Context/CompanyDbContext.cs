using EntitySession01.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EntitySession01.Context
{
    internal class CompanyDbContext: DbContext
    {
        public CompanyDbContext(): base()
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Data Source = . ; Intial Catalog = CompanyRoute; Integrated Securty = true");
            optionsBuilder.UseSqlServer("Server = . ; Database = CompanyRoute; Trusted_Connection = true; TrustServerCertificate= true");

        }
        #region FluentAPIS
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    //modelBuilder.Entity<Employee>().HasKey(E => E.Id);
        //    //modelBuilder.Entity<Employee>().Property("EmpName").HasColumnName("EmpName").HasMaxLength(50).IsRequired();
        //    //modelBuilder.Entity<Employee>().Property(nameof(Employee.Name)).HasMaxLength(50).IsRequired(false);

        //    //Another Way
        //    modelBuilder.Entity<Employee>(entity =>
        //    {
                
        //        entity.HasKey(e => e.Id);
        //        entity.Property(e => e.Id).UseIdentityColumn(10,10);
        //        entity.Property(e => e.Id).ValueGeneratedNever();
        //        entity.Property(e => e.Name).HasColumnName("EmpName").HasMaxLength(50).IsRequired();
        //        entity.Property(e => e.Salary).HasColumnName("EmpSalary").IsRequired();
        //    });
           
        //}
        #endregion
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            modelBuilder.Entity<Employee>()
                        .HasOne(e => e.ManagerDept)
                        .WithOne(e => e.Manager)
                        .HasForeignKey<Department>(d=>d.ManagerId);

            //modelBuilder.Entity<Employee>()
            //    .HasOne(e => e.EmployeeDepartment)
            //            .WithMany(D => D.Employees)
            //            .HasForeignKey(e => e.EmpDeptId);

            //another way
            //modelBuilder.Entity<Department>()
            //    .HasMany(d => d.Employees)
            //    .WithOne(e => e.EmployeeDepartment)
            //    .HasForeignKey(e => e.EmpDeptId);

        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<User> UsersTable { get; set; }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Adress> Adresses { get; set; }

        //public DbSet<Product> Products { get; set; }



    }
}
