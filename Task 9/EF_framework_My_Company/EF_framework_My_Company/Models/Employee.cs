using System;
using System.Collections.Generic;
using System.Text;

namespace EF_framework_My_Company.Models
{
    public class Employee
    {
        public int EmployeeId {  get; set; }
        public string FName {  get; set; }
        public string LName { get; set; }
        public DateTime DateHired { get;private set; }
        public int CompanyId { get; set; } //FK
        public virtual Company Company { get; set; }


    }
}
