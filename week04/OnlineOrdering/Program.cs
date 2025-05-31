using System;

class Program
{
    static void Main(string[] args)
    {
        // First order
        Address addr1 = new Address("5 Main Street", "Springfield", "IL", "USA");
        Customer cust1 = new Customer("Chistiana Nwachukwu", addr1);
        Order order1 = new Order(cust1);
        order1.AddProduct(new Product("Laptop", "P100", 900, 1));
        order1.AddProduct(new Product("Mouse", "P101", 25, 2));

        // Second order
        Address addr2 = new Address("45 Iwuanyanwu Close", "Ikenebu", "Enugwu", "Nigeria");
        Customer cust2 = new Customer("Queen Esther", addr2);
        Order order2 = new Order(cust2);
        order2.AddProduct(new Product("Camera", "P200", 350, 2));
        order2.AddProduct(new Product("Tripod", "P201", 100, 2));
        order2.AddProduct(new Product("Bag", "P202", 40, 1));

        DisplayOrder(order1);
        Console.WriteLine("-----------------------");
        DisplayOrder(order2);
    }

    static void DisplayOrder(Order order)
    {
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order.GetTotalCost():0.00}");
    }
}

