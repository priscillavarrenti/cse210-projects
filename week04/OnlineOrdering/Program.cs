using System;

class Program
{
    static void Main(string[] args)
    {
        //primero
        Address address1 = new Address("123 Main St", "Springfield", "IL", "USA");
        Customer customer1 = new Customer("John Doe", address1);
        Order order1 = new Order(customer1);

        order1.AddProduct(new Product("Laptop", "LP1001", 999.99, 1));
        order1.AddProduct(new Product("Mouse", "MS2002", 25.50, 2));

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalPrice()}\n");

        //segundo
        Address address2 = new Address("456 Elm St", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Jane Smith", address2);
        Order order2 = new Order(customer2);

        order2.AddProduct(new Product("Smartphone", "SP3003", 799.99, 1));
        order2.AddProduct(new Product("Headphones", "HP4004", 199.99, 1));
        order2.AddProduct(new Product("Charger", "CH5005", 29.99, 3));

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalPrice()}\n");


    }
}