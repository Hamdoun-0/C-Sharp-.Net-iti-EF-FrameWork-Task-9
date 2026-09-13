using EF_framework_My_Company.Data;
using EF_framework_My_Company.Models;
using EF_framework_My_Company.Repository;

namespace EF_framework_My_Company
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var DbContext = new ApplicationDbContext();

                var Company = new Company
                {
                    name = "traxx",
                    Address = "silicon Valley for techology"
                };
                //Company repo
                var cmp = new GenericRepo<Company>(DbContext);
                cmp.Create(Company);
                cmp.SaveChange();

                Console.WriteLine($"Company ID = {Company.Companyid}");


                var Employee1 = new Employee
                {
                    FName = "Mohamed",
                    LName = "Hamdoun",
                    CompanyId = Company.Companyid
                };

                var Employee2 = new Employee
                {
                    FName = "Mohamed",
                    LName = "Hesham",
                    CompanyId = Company.Companyid
                };

                var Employee3 = new Employee
                {
                    FName = "Mohamed",
                    LName = "Ahmed",
                    CompanyId = Company.Companyid
                };


                var emp = new GenericRepo<Employee>(DbContext);

                emp.Create(Employee1);
                emp.Create(Employee2);
                emp.Create(Employee3);
                

                Console.WriteLine($"Employee1 CompanyId = {Employee1.CompanyId}");
                Console.WriteLine($"Employee2 CompanyId = {Employee2.CompanyId}");
                Console.WriteLine($"Employee3 CompanyId = {Employee3.CompanyId}");

               
                emp.SaveChange();
                var findemployees = emp.GetEmployeesByCompanyId(e => e.CompanyId == Company.Companyid);
                foreach (var e in findemployees)
                {
                    Console.WriteLine($"Employeeid: {e.EmployeeId}\nName : {e.FName} {e.LName}\nDateHired : {e.DateHired}\n CompanyName : {e.Company.name}\nCompanyid : {e.CompanyId}");
                }





            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
