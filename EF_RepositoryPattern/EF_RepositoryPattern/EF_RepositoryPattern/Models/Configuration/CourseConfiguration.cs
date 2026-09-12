using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Rev.Models.Configuration
{
    public class CourseConfiguration : IEntityTypeConfiguration<Courses>
    {
        public void Configure(EntityTypeBuilder<Courses> builder)
        {
            builder.ToTable("tblCourses");
            builder.HasKey(c => c.CourseID);
            builder.Property(c => c.CourseName).IsRequired().HasMaxLength(150);
        }
    }
}
