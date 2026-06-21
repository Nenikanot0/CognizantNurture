using System;

public class SortingOperations
{
    // Bubble Sort
    // Best Case    : O(n)
    // Average Case : O(n²)
    // Worst Case   : O(n²)
    public static void BubbleSort(Order[] orders)
    {
        int n = orders.Length;

        for (int i = 0; i < n - 1; i++) // O(n)
        {
            for (int j = 0; j < n - i - 1; j++) // O(n)
            {
                if (orders[j].TotalPrice > orders[j + 1].TotalPrice)
                {
                    Order temp = orders[j];
                    orders[j] = orders[j + 1];
                    orders[j + 1] = temp;
                }
            }
        }
    }

    // Quick Sort
    // Best Case    : O(n log n)
    // Average Case : O(n log n)
    // Worst Case   : O(n²)
    public static void QuickSort(Order[] orders, int low, int high)
    {
        if (low < high)
        {
            int pivotIndex = Partition(orders, low, high);

            QuickSort(orders, low, pivotIndex - 1);
            QuickSort(orders, pivotIndex + 1, high);
        }
    }

    private static int Partition(Order[] orders, int low, int high)
    {
        double pivot = orders[high].TotalPrice;

        int i = low - 1;

        for (int j = low; j < high; j++) // O(n)
        {
            if (orders[j].TotalPrice < pivot)
            {
                i++;

                Order temp = orders[i];
                orders[i] = orders[j];
                orders[j] = temp;
            }
        }

        Order swap = orders[i + 1];
        orders[i + 1] = orders[high];
        orders[high] = swap;

        return i + 1;
    }

    // O(n)
    public static void DisplayOrders(Order[] orders)
    {
        foreach (Order order in orders)
        {
            Console.WriteLine(
                $"Order ID: {order.OrderId}, " +
                $"Customer: {order.CustomerName}, " +
                $"Price: {order.TotalPrice}");
        }
    }
}