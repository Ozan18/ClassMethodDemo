using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 12345;
            customer1.Name = "Ahmet";
            customer1.Surname = "Çalışkan";

            Customer customer2 = new Customer();
            customer2.Id = 123456;
            customer2.Name = "Mehmet";
            customer2.Surname = "Uçan";

            Customer customer3 = new Customer();
            customer3.Id = 1234567;
            customer3.Name = "Nihat";
            customer3.Surname = "Kahveci";


            Customer[] customers = new Customer[] { 
            customer1 , customer2 , customer3 
            };

            CustomerManager customerManager = new CustomerManager();
            Console.WriteLine("-----Customer Adding-----");
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);
            Console.WriteLine("-----Customer Listing-----");
            customerManager.Listing(customers);
            Console.WriteLine("-----Customer Deleting-----");
            customerManager.Delete(customer1);
            customerManager.Delete(customer2);
            customerManager.Delete(customer3);
        }
    }
}
