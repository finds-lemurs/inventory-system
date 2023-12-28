using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create the inventory system
        var inventorySystem = new InventorySystem();

        // Add products to the inventory
        inventorySystem.AddProduct(new Product(1, "Laptop", 999.99, 10));
        inventorySystem.AddProduct(new Product(2, "Smartphone", 499.99, 20));
        inventorySystem.AddProduct(new Product(3, "Headphones", 79.99, 30));

        // Display the initial inventory
        inventorySystem.DisplayInventory();

        // Create orders
        inventorySystem.CreateOrder(101, new List<int> { 1, 2 });
        inventorySystem.CreateOrder(102, new List<int> { 2, 3 });

        // Display the updated inventory and order history
        inventorySystem.DisplayInventory();
        inventorySystem.DisplayOrders();
    }
}
