using System;
using System.Collections.Generic;
using System.Text;

namespace EF_framework_My_Company.Models
{
    public class Company
    {
        public int Companyid { get; set; }
        public string name { get; set; }
        public string Address { get; set; }

        

        

        //many employees in one company
        public virtual ICollection<Employee> Employees { get; set; } = new HashSet<Employee>();
    }
}
