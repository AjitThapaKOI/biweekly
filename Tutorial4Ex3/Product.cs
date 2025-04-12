using System;

namespace Tutorial4Ex3
{
    class Product
    {
        // Properties
        public int ProductId { get; private set; }
        public string ProductName { get; private set; }
        public double Price { get; private set; }

        // Constructor
        public Product(int productId, string productName, double price)
        {
            ProductId = productId;
            ProductName = productName;
            Price = price;
        }

        // Method to display product details
        public void DisplayProduct()
        {
            Console.WriteLine($"Product ID: {ProductId}, Name: {ProductName}, Price: ${Price}");
        }
    }
}
