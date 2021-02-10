using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = "789123";
            customer1.Name = "Selda";
            customer1.Surname = "Demir";
            customer1.City = "Denizli";


            Customer customer2 = new Customer();
            customer2.Id = "357951";
            customer2.Name = "Ayşenur";
            customer2.Surname = "Deniz";
            customer2.City = "İstanbul";

            Customer customer3 = new Customer();
            customer3.Id = "621991";
            customer3.Name = "Fatih";
            customer3.Surname = "Bilgeç";
            customer3.City = "Kırıkkale";

            Customer customer4 = new Customer();
            customer4.Id = "871255";
            customer4.Name = "Batuhan";
            customer4.Surname = "Balcı";
            customer4.City = "Trabzon";

            Customer[] customers = new Customer[] { customer1, customer2, customer3, customer4 };

            CustomerManager customerManager = new CustomerManager();
            Console.WriteLine("---------------ADD-------------");
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);
            customerManager.Add(customer4);

            Console.WriteLine("---------------REMOVE---------------");
            customerManager.Remove(customer1);
            customerManager.Remove(customer2);
            customerManager.Remove(customer3);
            customerManager.Remove(customer4);

            Console.WriteLine("---------------ARRAY----------------");
            customerManager.Array(customers);

            
        }
        
    }
}
