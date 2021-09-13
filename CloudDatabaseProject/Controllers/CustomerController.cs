using CloudDatabaseProject.DAL;
using CloudDatabaseProject.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CloudDatabaseProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly CustomerContext _customerContext;
        public CustomerController(CustomerContext customerContext)
        {
            _customerContext = customerContext;
            _customerContext.Customers.Add(new Customer { FirstName = "Henkie", LastName = "de Vries" });
            _customerContext.SaveChanges();
        }

        [HttpGet]
        public IActionResult GetAllCustommers()
        {
            return Ok(_customerContext.Customers);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCustomer(int id)
        {
            _customerContext.Customers.Remove(_customerContext.Customers.Find(id));
            _customerContext.SaveChanges();
            return NoContent();
        }

        [HttpPut("{id}")]
        public IActionResult EditCustomer(int id, string firstName)
        {
            Customer customer = _customerContext.Customers.Find(id);
            customer.FirstName = firstName;
            _customerContext.Update(customer);
            _customerContext.SaveChanges();
            return Ok(customer);
        }

        [HttpGet("{id}/invoices")]
        public IActionResult GetCustomerInvoices(int id)
        {
            Customer customer = _customerContext.Customers.Find(id);
            List<Invoice> invoices = new()
            {
                new Invoice { CustomerId = 1 }
            };
            customer.Invoices = invoices;
            _customerContext.Customers.Update(customer);
            _customerContext.SaveChanges();
            return Ok(_customerContext.Customers.Find(id).Invoices);
        }
    }
}
