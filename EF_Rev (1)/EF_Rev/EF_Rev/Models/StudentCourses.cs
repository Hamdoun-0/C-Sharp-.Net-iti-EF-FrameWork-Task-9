using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Rev.Models
{
    public class StudentCourses
    {
        public int StudentID { get; set; } // 1
        public int CourseID { get; set; } // 2
        // one Student 
        // one Course
        public virtual Student Student { get; set; }
        public virtual Courses Course { get; set; }

    }
}
