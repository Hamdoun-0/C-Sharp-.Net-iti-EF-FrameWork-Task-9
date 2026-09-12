using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Rev.Models
{
    public class Student
    {
        public int StudentId { get; set; } // 2  => {1,4,7}
        public string StudentName { get; set; }
        public string StudentPhone { get; set; }
        public string StudentAddress { get; set; }
        public DateTime CreatedDate { get; private set; }
        // many in StudentCourses
        public virtual ICollection<StudentCourses> StudentCourses { get; set; } = new HashSet<StudentCourses>();

    }
}
