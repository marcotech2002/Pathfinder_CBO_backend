using CBO_MDE.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBO_MDE.Entities.Configurations
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("EMPLOYEES");

            builder.Property(employee => employee.CPF)
                .HasColumnName("CPF")
                .HasColumnType("CHAR(11)")
                .IsRequired();

            builder.Property(employee => employee.MobileNumber)
                .HasColumnName("MobileNumber")
                .HasColumnType("CHAR(11)")
                .IsRequired();

            builder.HasMany(employee => employee.Ventures)
                .WithMany(venture => venture.Employees);
        }
    }
}
