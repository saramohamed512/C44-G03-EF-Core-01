using EntitySession01.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
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
        public DbSet<Employee> Employees { get; set; }
        public DbSet<User> UsersTable { get; set; }


    }
}
