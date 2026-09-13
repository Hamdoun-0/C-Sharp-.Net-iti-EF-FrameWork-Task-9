using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EF_framework_My_Company.Models.Configuration
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder) 
        {
            builder.ToTable("tblEmployee");
            builder.HasKey(e => e.EmployeeId);
            builder.Property(e => e.FName).IsRequired().HasMaxLength(150);
            builder.Property(e => e.LName).IsRequired().HasMaxLength(150);
            builder.Property(e => e.DateHired).HasDefaultValueSql("GETDATE()");

            builder.HasOne(e => e.Company)
                   .WithMany(c => c.Employees)
                   .HasForeignKey(e => e.CompanyId);       

        }
    }
}
