using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "Salt Lake City", "UT", "USA");
        Customer customer1 = new Customer("John Smith", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Notebook", "P001", 3.50, 4));
        order1.AddProduct(new Product("Pen", "P002", 1.25, 10));
        order1.AddProduct(new Product("Backpack", "P003", 25.00, 1));

        Address address2 = new Address("45 Av. Reforma", "Guatemala City", "Guatemala", "Guatemala");
        Customer customer2 = new Customer("Maria Lopez", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Headphones", "P101", 45.00, 1));
        order2.AddProduct(new Product("USB Cable", "P102", 8.00, 2));

        List<Order> orders = new List<Order> { order1, order2 };

        foreach (Order order in orders)
        {
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine($"\nTotal Cost: ${order.GetTotalCost():F2}");
            Console.WriteLine("------------------------------\n");
        }
    }
}
