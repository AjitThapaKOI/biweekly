using System;
using System.Collections.Generic;  // Required for List

namespace Tutorial4Ex3
{
    class Customer
    {
        // Properties
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Email { get; private set; }

        // List to store products
        public List<Product> ShoppingList { get; private set; }

        // Constructor
        public Customer(int id, string name, string email)
        {
            Id = id;
            Name = name;
            Email = email;
            ShoppingList = new List<Product>(); // Initialize the list
        }

        // Method to add product to shopping list
        public void AddProduct(Product product)
        {
            ShoppingList.Add(product);
        }

        // Method to display customer and shopping list details
        public void DisplayCustomerInfo()
        {
            Console.WriteLine($"Customer ID: {Id}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine("Shopping List:");
            foreach (var product in ShoppingList)
            {
                product.DisplayProduct();
            }
            Console.WriteLine("-------------------------");
        }
    }
}
