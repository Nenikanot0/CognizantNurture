using System;
using System.Collections.Generic;

public class Inventory
{
    private Dictionary<int, Product> products = new Dictionary<int, Product>();

    public void AddProduct(Product product)
    {
        products[product.ProductId] = product; // O(1) Average Case

        Console.WriteLine("Product Added");
    }

    public void UpdateProduct(int id,string name,int quantity,double price)
    {
        if (products.ContainsKey(id)) // O(1) Average Case
        {
            products[id].ProductName = name; // O(1)
            products[id].Quantity = quantity; // O(1)
            products[id].Price = price; // O(1)

            Console.WriteLine("Product Updated");
        }
        else
        {
            Console.WriteLine("Product Not Found");
        }
    }

    public void DeleteProduct(int id)
    {
        if (products.Remove(id)) // O(1) Average Case
        {
            Console.WriteLine("Product Deleted");
        }
        else
        {
            Console.WriteLine("Product Not Found");
        }
    }

    public void DisplayProducts()
    {
        Console.WriteLine("\nInventory:");

        foreach (var product in products.Values) // O(n)
        {
            Console.WriteLine(
                $"ID: {product.ProductId}, " +
                $"Name: {product.ProductName}, " +
                $"Qty: {product.Quantity}, " +
                $"Price: {product.Price}");
        }
    }
}