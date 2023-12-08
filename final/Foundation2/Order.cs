using System;
using System.Collections.Generic;
using System.Linq;

public class Order
{
    private List<Product> Products { get; set; }
    private Customer Customer { get; set; }

    public Order(List<Product> products, Customer customer)
    {
        Products = products;
        Customer = customer;
    }

    public decimal CalculateTotalPrice()
    {
        decimal totalPrice = Products.Sum(product => product.CalculateProductPrice());

        // Add shipping cost based on customer location
        if (Customer.IsInUSA())
        {
            totalPrice += 5;
        }
        else
        {
            totalPrice += 35;
        }

        return totalPrice;
    }

    public string GetPackingLabel()
    {
        return string.Join("\n", Products.Select(product => $"{product.Name}, ID: {product.ProductId}"));
    }

    public string GetShippingLabel()
    {
        return $"{Customer.Name}\n{Customer.GetFullAddress()}";
    }
}
