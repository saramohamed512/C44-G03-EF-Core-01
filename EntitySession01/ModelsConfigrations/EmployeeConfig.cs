using EntitySession01.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace EntitySession01.ModelsConfigrations
{
    internal class EmployeeConfig:IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(E => E.Id); //PK
            builder.Property(E => E.Id)
                    .UseIdentityColumn(1, 1);
            builder.Property(E => E.Name)
                    .HasColumnName("EmpName")
                    .HasColumnType("varchar(50)")
                    .HasMaxLength(50)
                    .IsRequired(false);

            builder.OwnsOne(E => E.EmpAdress, Adress => Adress.WithOwner());


        builder.HasOne(e => e.EmployeeDepartment)
                       .WithMany(D => D.Employees)
                       .HasForeignKey(e => e.EmpDeptId);
        }
    }
   
}
