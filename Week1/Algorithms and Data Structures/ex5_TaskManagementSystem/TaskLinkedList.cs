using System;

public class TaskLinkedList
{
    // Time Complexity Summary
    // Add Task      : O(n)
    // Search Task   : O(n)
    // Traverse Task : O(n)
    // Delete Task   : O(n)

    private TaskNode head;

    public void AddTask(Task task)
    {
        TaskNode newNode = new TaskNode(task);

        // O(1)
        if (head == null)
        {
            head = newNode;
            Console.WriteLine("Task Added");
            return;
        }

        // O(n)
        TaskNode current = head;

        while (current.Next != null)
        {
            current = current.Next;
        }

        current.Next = newNode;

        Console.WriteLine("Task Added");
    }

    public Task SearchTask(int taskId)
    {
        // O(n)
        TaskNode current = head;

        while (current != null)
        {
            if (current.Data.TaskId == taskId)
            {
                return current.Data;
            }

            current = current.Next;
        }

        return null;
    }

    public void TraverseTasks()
    {
        // O(n)
        Console.WriteLine("\nTask List:");

        TaskNode current = head;

        while (current != null)
        {
            Console.WriteLine(
                $"ID: {current.Data.TaskId}, " +
                $"Name: {current.Data.TaskName}, " +
                $"Status: {current.Data.Status}");

            current = current.Next;
        }
    }

    public void DeleteTask(int taskId)
    {
        // O(1)
        if (head == null)
            return;

        if (head.Data.TaskId == taskId)
        {
            head = head.Next;
            Console.WriteLine("Task Deleted");
            return;
        }

        // O(n)
        TaskNode current = head;

        while (current.Next != null &&
               current.Next.Data.TaskId != taskId)
        {
            current = current.Next;
        }

        if (current.Next != null)
        {
            current.Next = current.Next.Next;
            Console.WriteLine("Task Deleted");
        }
        else
        {
            Console.WriteLine("Task Not Found");
        }
    }
}