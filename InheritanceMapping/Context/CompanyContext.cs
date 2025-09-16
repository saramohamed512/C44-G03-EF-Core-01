using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceMapping.Context
{
    internal class CompanyContext : DbContext
    {
      
       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=. ;Database=CompanyDB;Trusted_Connection=True;TrustServerCertificate=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region TPH


            //modelBuilder.Entity<FullTimeEmployee>()
            //    .HasBaseType<Employee>();
            //modelBuilder.Entity<PartTimeEmployee>()
            //    .HasBaseType<Employee>();

            //modelBuilder.Entity<Employee>()
            //    .HasDiscriminator<string>("EmployeeType")
            //    .HasValue<FullTimeEmployee>("FTE")
            //    .HasValue<PartTimeEmployee>("PTE");
            #endregion
            #region TPT
            modelBuilder.Entity<FullTimeEmployee>()
                .ToTable("FullTimeEmployees");

            modelBuilder.Entity<PartTimeEmployee>()
                .ToTable("PartTimeEmployees");

            #endregion
        }
        #region 1.Table Per Concrete Type [TPCT]
        //public DbSet<FullTimeEmployee> FullTimeEmployees { get; set; }
        //public DbSet<PartTimeEmployee> PartTimeEmployees { get; set; }
        #endregion
        #region 2.Table Per Hierarchy [TPH]
        //public DbSet<Employee> Employees { get; set; }
        #endregion
        #region 3.Table Per Type
        public DbSet<Employee> Employees { get; set; }
        public DbSet<FullTimeEmployee> FullTimeEmployees { get; set; }
        public DbSet<PartTimeEmployee> PartTimeEmployees { get; set; }
        #endregion



    }
}
