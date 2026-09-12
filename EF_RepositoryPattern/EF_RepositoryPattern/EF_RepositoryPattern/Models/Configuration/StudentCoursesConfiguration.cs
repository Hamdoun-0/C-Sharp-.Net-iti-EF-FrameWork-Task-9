using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Rev.Models.Configuration
{
    public class StudentCoursesConfiguration : IEntityTypeConfiguration<StudentCourses>
    {
        public void Configure(EntityTypeBuilder<StudentCourses> builder)
        {
            builder.HasKey(sc=> new { sc.StudentID, sc.CourseID });

            builder.HasOne(sc=> sc.Student)
                .WithMany(s=> s.StudentCourses)
                .HasForeignKey(sc=> sc.StudentID);

            builder.HasOne(sc=> sc.Course)
                .WithMany(c=> c.StudentCourses)
                .HasForeignKey(sc=> sc.CourseID);
        }
    }
}
