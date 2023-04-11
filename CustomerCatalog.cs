using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Richard_Pizzaria_UML2
{
    public class CustomerCatalog
    {
        List<Customer> _customer;
        public CustomerCatalog()
        {
            _customer = new List<Customer>();
        }

        public void Create(Customer c)
        {
            _customer.Add(c);
        }

        public void CustomerPrint()
        {
            foreach (var c in _customer)
            {
                Console.WriteLine(c);
                Console.WriteLine("======================================");
            }
        }

        public Customer SearchCustomer(Customer customer)
        {
            foreach (var c in _customer)
            {
                if (c.customerName == customer.customerName)
                {
                    Console.WriteLine($"{c}");
                }
            }
            return null;
        }

        public Customer SearchCustomerId(Customer customer)
        {
            foreach (var c in _customer)
            {
                if (c.customerId == customer.customerId)
                {
                    Console.WriteLine($"{c}");
                }
            }
            return null;
        }

        public void UpdateCustomer(Customer customer)
        {
            foreach (var c in _customer)
            {
                if (c.customerId == customer.customerId)
                {
                    c.customerName = customer.customerName;
                    c.customerId = customer.customerId;
                }
            }
        }

        public void DeleteCustomer(Customer customer)
        {
            foreach (var c in _customer)
            {
                if (c.customerId == customer.customerId)
                {
                    customer = c;
                    break;
                }

            }
            _customer.Remove(customer);
        }
    }
}
