using System;

class Program
{
    static void Main()
    {
        // Sorted by Title for Binary Search
        Book[] books =
        {
            new Book(101, "C Programming", "Dennis Ritchie"),
            new Book(102, "Data Structures", "Mark Allen"),
            new Book(103, "Java Programming", "James Gosling"),
            new Book(104, "Python Basics", "Guido van Rossum"),
            new Book(105, "Web Development", "Tim Berners-Lee")
        };

        Console.WriteLine("Linear Search:");

        Book book1 =
            SearchOperations.LinearSearch(
                books,
                "Python Basics");

        if (book1 != null)
        {
            Console.WriteLine(
                $"Found: {book1.Title} by {book1.Author}");
        }

        Console.WriteLine();

        Console.WriteLine("Binary Search:");

        Book book2 =
            SearchOperations.BinarySearch(
                books,
                "Python Basics");

        if (book2 != null)
        {
            Console.WriteLine(
                $"Found: {book2.Title} by {book2.Author}");
        }
    }
}