using System;

class Program
{
    static void Main(string[] args)
    {
        Order[] orders1 =
        {
            new Order(101, "Rahul", 5000),
            new Order(102, "Priya", 2000),
            new Order(103, "Amit", 8000),
            new Order(104, "Sneha", 3500)
        };

        Console.WriteLine("Before Bubble Sort:");
        SortingOperations.DisplayOrders(orders1);

        SortingOperations.BubbleSort(orders1);

        Console.WriteLine("\nAfter Bubble Sort:");
        SortingOperations.DisplayOrders(orders1);

        Console.WriteLine("\n-----------------------\n");

        Order[] orders2 =
        {
            new Order(101, "Rahul", 5000),
            new Order(102, "Priya", 2000),
            new Order(103, "Amit", 8000),
            new Order(104, "Sneha", 3500)
        };

        Console.WriteLine("Before Quick Sort:");
        SortingOperations.DisplayOrders(orders2);

        SortingOperations.QuickSort(
            orders2,
            0,
            orders2.Length - 1);

        Console.WriteLine("\nAfter Quick Sort:");
        SortingOperations.DisplayOrders(orders2);
    }
}