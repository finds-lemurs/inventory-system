public class Order
{
    public int OrderId { get; set; }
    public List<Product> Products { get; set; }

    public Order(int orderId)
    {
        OrderId = orderId;
        Products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        Products.Add(product);
    }

    public double CalculateTotal()
    {
        double total = 0;
        foreach (var product in Products)
        {
            total += product.Price;
        }
        return total;
    }

    public void DisplayOrderInfo()
    {
        Console.WriteLine($"Order ID: {OrderId}");
        Console.WriteLine("Products in the order:");
        foreach (var product in Products)
        {
            Console.WriteLine($"- {product.Name}");
        }
        Console.WriteLine($"Total: ${CalculateTotal()}\n");
    }
}
