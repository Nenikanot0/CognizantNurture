using System;

class Program
{
    static void Main(string[] args)
    {
        Product[] products =
        {
            new Product(101, "Laptop", "Electronics"),
            new Product(102, "Mouse", "Electronics"),
            new Product(103, "Keyboard", "Electronics"),
            new Product(104, "Monitor", "Electronics"),
            new Product(105, "Printer", "Electronics")
        };

        Console.WriteLine("Linear Search:");

        Product result1 =
            SearchOperations.LinearSearch(products, 104);

        if (result1 != null)
        {
            Console.WriteLine(
                $"Found: {result1.ProductName}");
        }

        Console.WriteLine();

        Console.WriteLine("Binary Search:");

        Product result2 =
            SearchOperations.BinarySearch(products, 104);

        if (result2 != null)
        {
            Console.WriteLine(
                $"Found: {result2.ProductName}");
        }
    }
}