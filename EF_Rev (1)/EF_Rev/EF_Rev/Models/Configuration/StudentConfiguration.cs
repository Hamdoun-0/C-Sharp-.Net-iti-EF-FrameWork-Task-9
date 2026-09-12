using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace EF_Rev.Models.Configuration
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.ToTable("tblStudents");
            builder.HasKey(s => s.StudentId);
            builder.Property(s => s.StudentName).IsRequired().HasMaxLength(150);
            builder.Property(s => s.StudentPhone).IsRequired().HasMaxLength(15);
            builder.Property(s => s.StudentAddress).IsRequired().HasMaxLength(200);
            builder.Property(s => s.CreatedDate).HasDefaultValueSql("GETDATE()");
        }
    }
}
