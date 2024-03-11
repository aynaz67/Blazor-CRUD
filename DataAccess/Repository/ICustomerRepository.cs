using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Entities;

namespace DataAccess.Repository
{
    public interface ICustomerRepository
    {
        List<Customer> GetAll();
        Customer GetCustomerById(int customerId);
        void AddCustomer(Customer customer);
        bool UpdateCustomer(Customer customer);
        bool DeleteCustomer(Customer customer);
    }
}
