using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
     class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Customer Added SuccesFully : " + customer.Name + ":" + customer.Surname + ":" + customer.Id);

        }

        public void Listing(Customer[] customers)
        {
            foreach (Customer customer in customers)
            {
                Console.WriteLine(customer.Id);
                Console.WriteLine(customer.Name);
                Console.WriteLine(customer.Surname );
                Console.WriteLine("-----------------------------------------------");
            }
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine("Customer Deleted SuccsesFully : " + customer.Name + ":" + customer.Surname + ":" + customer.Id);
        }


    }

}
