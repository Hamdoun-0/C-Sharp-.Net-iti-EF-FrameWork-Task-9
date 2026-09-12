using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Rev.Models
{
    public class Courses
    {
        public int CourseID { get; set; }
        public string CourseName { get; set; }
        // have many StudentCourses
        public virtual ICollection<StudentCourses> StudentCourses { get; set; } = new HashSet<StudentCourses>();
    }
}
