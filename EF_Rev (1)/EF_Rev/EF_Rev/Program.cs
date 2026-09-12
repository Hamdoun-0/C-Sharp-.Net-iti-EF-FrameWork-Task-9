using EF_Rev.Data;
using EF_Rev.Models;

namespace EF_Rev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var DbContext = new ApplicationDbContext();
                //// Add a new student
                //var student = new Student()
                //{
                //    StudentName = "Anas",
                //    StudentAddress = "Aexandriaa",
                //    StudentPhone = "01000000000",
                //};
                //DbContext.Add(student);

                //// add Courses

                //var course = new Courses()
                //{
                //    CourseName = "C#",
                //};
                //DbContext.Add(course);

                //DbContext.SaveChanges();

                //// by Defaulat, Assign this Course to the Student
                //var sc = new StudentCourses()
                //{
                //    StudentID = student.StudentId,
                //    CourseID = course.CourseID,
                //};
                //DbContext.Add(sc);
                //DbContext.SaveChanges();


                //DisplayStudents(DbContext);
                List<StudentCourseView> stdQuery = GetStudentCourseWithLINQ(DbContext);
                DisplayStudentCourses(stdQuery);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void DisplayStudents(ApplicationDbContext DbContext)
        {
            var students = DbContext.Students.ToList();
            foreach (var student in students)
            {
                Console.WriteLine($"Student Name: {student.StudentName}, Address: {student.StudentAddress}, Phone: {student.StudentPhone}");
               
            }
        }

        public static List<StudentCourseView> GetStudentCourseWithLINQ(ApplicationDbContext dbContext)
        {
            var query = from std in dbContext.Students
                        join sc in dbContext.StudentCourses on std.StudentId equals sc.StudentID
                        join c in dbContext.Courses on sc.CourseID equals c.CourseID
                        select new StudentCourseView
                        {
                            StudentName = std.StudentName,
                            CourseName = c.CourseName
                        };
            return query.ToList();
        }

        public static void DisplayStudentCourses(List<StudentCourseView> studentCourses)
        {
            foreach (var sc in studentCourses)
            {
                Console.WriteLine($"Student Name: {sc.StudentName}, Course Name: {sc.CourseName}");
            }
        }
    }

    // hard type 
    public class StudentCourseView
    {
        public string StudentName { get; set; }
        public string CourseName { get; set; }
    }
}
