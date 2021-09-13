using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CloudDatabaseProject.Models
{
    public class EmployeeRole
    {
        public int EmployeeRoleID { get; set; }
        public String Name { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
