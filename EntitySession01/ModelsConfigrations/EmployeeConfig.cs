using EntitySession01.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitySession01.ModelsConfigrations
{
    internal class EmployeeConfig:IEntityTypeConfiguration<Employee>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(e => e.Id);//Primary Key
            builder.Property(e => e.Id).UseIdentityColumn(10, 10);
            builder.Property(e => e.Id).ValueGeneratedNever();
            builder.Property(e => e.Name).HasColumnName("EmpName").HasColumnType("varchar(50)").HasMaxLength(50).IsRequired();
            builder.Property(e => e.Salary).HasColumnName("EmpSalary").IsRequired();
        }
    }
   
}
