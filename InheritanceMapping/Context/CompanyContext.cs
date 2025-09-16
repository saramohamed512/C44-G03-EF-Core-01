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
        #region 1.Table Per Concrete Type [TPCT]
        public DbSet<FullTimeEmployee> FullTimeEmployees { get; set; }
        public DbSet<PartTimeEmployee> PartTimeEmployees { get; set; }
        #endregion
        #region 2.Table Per Hierarchy [TPH]

        #endregion

   
    }
}
