using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CloudDatabaseProject.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }

        [MaxLength(60)]
        public String FirstName { get; set; }

        [Required]
        public String LastName { get; set; }

        [NotMapped]
        public int Age { get; set; }

        public ICollection<Invoice> Invoices { get; set; }
    }
}
