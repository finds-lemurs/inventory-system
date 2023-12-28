public class InventorySystem
{
    public List<Product> Products { get; set; }
    public List<Order> Orders { get; set; }

    public InventorySystem()
    {
        Products = new List<Product>();
        Orders = new List<Order>();
    }

    public void AddProduct(Product product)
    {
        Products.Add(product);
    }

    public void CreateOrder(int orderId, List<int> productIds)
    {
        var order = new Order(orderId);
        foreach (var productId in productIds)
        {
            var product = Products.Find(p => p.ProductId == productId);
            if (product != null && product.QuantityInStock > 0)
            {
                order.AddProduct(product);
                product.QuantityInStock--;
            }
        }
        Orders.Add(order);
    }

    public void DisplayInventory()
    {
        Console.WriteLine("Current Inventory:\n");
        foreach (var product in Products)
        {
            product.DisplayProductInfo();
        }
    }

    public void DisplayOrders()
    {
        Console.WriteLine("Order History:\n");
        foreach (var order in Orders)
        {
            order.DisplayOrderInfo();
        }
    }
}
