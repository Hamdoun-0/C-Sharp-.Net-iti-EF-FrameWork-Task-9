using EF_Rev.Data;
using EF_Rev.Models;
using EF_Rev.Repository;
using System.ComponentModel.DataAnnotations;

namespace EF_Rev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var DbContext = new ApplicationDbContext();


                // student 
                var student = new Student
                {
                    StudentName = "Anas",
                    StudentPhone = "1234567890",
                    StudentAddress = "123 Main St",
                };


                // course
                var course = new Courses
                {
                    CourseName = "Math",
                };

                
                // std repo 
                var std = new GenericRepo<Student>(DbContext);
                //std.Create(student);
                //std.UpdateRaw(student);
                //std.Delete(student);
                //var foundStudent = std.FindBy(id => id.StudentName == "Anas" /*&& id.StudentAddress=="123 Main St"*/ );
                //var allStudents = std.GetAll();
                //var studentById = std.getByID(1);
                //std.SaveChanges();

                // crs repo 
                var crs = new GenericRepo<Courses>(DbContext);
                //crs.Create(course);
                //crs.UpdateRaw(course);
                //crs.Delete(course);
                //var foundCourse = crs.FindBy(id => id.CourseName == "Math");
                //var allCourse = crs.GetAll();
                //var courseById = crs.getByID(1);

                //crs.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


    }
}
