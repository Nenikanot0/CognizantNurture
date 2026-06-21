using System;

public class SearchOperations
{
    // Linear Search
    // Best Case    : O(1)
    // Average Case : O(n)
    // Worst Case   : O(n)
    public static Book LinearSearch(Book[] books, string title)
    {
        foreach (Book book in books) // O(n)
        {
            if (book.Title.Equals(title,
                StringComparison.OrdinalIgnoreCase))
            {
                return book;
            }
        }

        return null;
    }

    // Binary Search
    // Best Case    : O(1)
    // Average Case : O(log n)
    // Worst Case   : O(log n)
    public static Book BinarySearch(Book[] books, string title)
    {
        int left = 0;
        int right = books.Length - 1;

        while (left <= right) // O(log n)
        {
            int mid = (left + right) / 2;

            int result = string.Compare(
                books[mid].Title,
                title,
                StringComparison.OrdinalIgnoreCase);

            if (result == 0)
                return books[mid];

            if (result < 0)
                left = mid + 1;
            else
                right = mid - 1;
        }

        return null;
    }
}