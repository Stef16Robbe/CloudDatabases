using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CloudDatabaseProject.Models
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public String Name { get; set; }
        public virtual ICollection<EmployeeRole> Roles { get; set; }
    }
}
