public class Product
{
    public string Name { get; private set; }
    public string ProductId { get; private set; }
    public decimal Price { get; private set; }
    public int Quantity { get; private set; }

    public Product(string name, string productId, decimal price, int quantity)
    {
        Name = name;
        ProductId = productId;
        Price = price;
        Quantity = quantity;
    }

    public decimal CalculateProductPrice()
    {
        return Price * Quantity;
    }
}
