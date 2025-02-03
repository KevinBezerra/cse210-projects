using System;

class Program
{
    static void Main(string[] args)
    {
        Customer customer1 = new Customer("Kevin", new Address("123 Main St", "Springfield", "IL", "USA"));
        Customer customer2 = new Customer("Alice", new Address("456 Maple Ave", "Toronto", "ON", "Canada"));


        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", 101, 899.99, 1));
        order1.AddProduct(new Product("Mouse", 102, 19.99, 2));
        order1.AddProduct(new Product("Keyboard", 103, 49.99, 1));

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Phone", 201, 699.99, 1));
        order2.AddProduct(new Product("Charger", 202, 29.99, 1));

      
        Console.WriteLine("===== Order 1 =====");
        Console.WriteLine(order1.PackingLabel());
        Console.WriteLine(order1.ShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.OrderCost()}\n");

    
        Console.WriteLine("===== Order 2 =====");
        Console.WriteLine(order2.PackingLabel());
        Console.WriteLine(order2.ShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.OrderCost()}");
        
    }
}