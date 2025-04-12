using System;

namespace Tutorial4Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating customer object
            Customer Cust1 = new Customer(1, "Alice", "alice@example.com");

            // Creating product objects
            Product prod1 = new Product(101, "Laptop", 1200.50);
            Product prod2 = new Product(102, "Mouse", 25.99);
            Product prod3 = new Product(103, "Keyboard", 45.75);

            // Adding products to the customer's shopping list
            Cust1.AddProduct(prod1);
            Cust1.AddProduct(prod2);
            Cust1.AddProduct(prod3);

            // Displaying customer details and shopping list
            Cust1.DisplayCustomerInfo();
            Console.ReadLine();
        }
    }
}
