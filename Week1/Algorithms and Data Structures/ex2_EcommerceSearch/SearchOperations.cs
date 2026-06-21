using System;

public class SearchOperations
{
    // Linear Search
    // Best Case  : O(1)
    // Average Case: O(n)
    // Worst Case : O(n)
    public static Product LinearSearch(Product[] products, int productId)
    {
        foreach (Product product in products) // O(n)
        {
            if (product.ProductId == productId) // O(1)
            {
                return product;
            }
        }

        return null;
    }

    // Binary Search
    // Best Case  : O(1)
    // Average Case: O(log n)
    // Worst Case : O(log n)
    public static Product BinarySearch(Product[] products, int productId)
    {
        int left = 0;
        int right = products.Length - 1;

        while (left <= right) // O(log n)
        {
            int mid = (left + right) / 2;

            if (products[mid].ProductId == productId)
                return products[mid];

            if (products[mid].ProductId < productId)
                left = mid + 1;
            else
                right = mid - 1;
        }

        return null;
    }
}