public class Product
{
    public int ProductId { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
    public int QuantityInStock { get; set; }

    public Product(int productId, string name, double price, int quantityInStock)
    {
        ProductId = productId;
        Name = name;
        Price = price;
        QuantityInStock = quantityInStock;
    }

    public void DisplayProductInfo()
    {
        Console.WriteLine($"Product ID: {ProductId}");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Price: ${Price}");
        Console.WriteLine($"Quantity in Stock: {QuantityInStock}\n");
    }
}
