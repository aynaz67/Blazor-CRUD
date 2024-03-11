using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Entities;

namespace DataAccess.Repository
{

    public class CustomerRepository : ICustomerRepository
    {
        private readonly CustomerDBContext _context;
        public CustomerRepository(CustomerDBContext context)
        {
            _context = context;
        }
        public void AddCustomer(Customer customer)
        {
            _context.Customers.Add(customer);
            Save();
        }

        public bool DeleteCustomer(Customer customer)
        {
            var _customer = _context.Customers.Find(customer.Id);
            if (_customer != null)
            {
                _context.Customers.Remove(_customer);
                Save();
            }
            else
            {
                return false;
            }
            return true;
        }

        public List<Customer> GetAll()
        {
            return _context.Customers.ToList();
        }

        public Customer GetCustomerById(int customerId)
        {
            return _context.Customers.Find(customerId);
        }

        public bool UpdateCustomer(Customer customer)
        {
            var _customer = _context.Customers.Find(customer.Id);
            if (_customer != null)
            {
                _customer.Name = customer.Name;
                _customer.Age = customer.Age;
                _customer.Height = customer.Height;
                _customer.Postcode = customer.Postcode;
                _context.Update(_customer);
                Save();
            }
            else
            {
                return false;
            }
            return true;
        }

        //DRY Principle
        private void Save()
        {
            _context.SaveChanges();
        }
    }
}

