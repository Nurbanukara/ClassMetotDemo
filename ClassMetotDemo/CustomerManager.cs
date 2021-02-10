using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Added to the system: " + customer.Name + " " + customer.Surname);
        }

        public void Remove(Customer customer)
        {
            Console.WriteLine("Customer removed from the system: " + customer.Name + " " + customer.Surname);
        }
        public void Array(Customer[] customer)
        {
            foreach (Customer client in customer)
            {
                Console.WriteLine("Id : " + client.Id +
                    "\n Name: " + client.Name +
                    "\nSurname: " + client.Surname +
                    "\nPhone Number: " + client.City);
                Console.WriteLine("------------------------------------");

            }
        }
    }
}
