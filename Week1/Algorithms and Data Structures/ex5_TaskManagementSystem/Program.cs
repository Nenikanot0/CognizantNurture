using System;

class Program
{
    static void Main()
    {
        TaskLinkedList taskList =
            new TaskLinkedList();

        taskList.AddTask(
            new Task(101,
                     "Design Database",
                     "Pending"));

        taskList.AddTask(
            new Task(102,
                     "Develop API",
                     "In Progress"));

        taskList.AddTask(
            new Task(103,
                     "Testing",
                     "Pending"));

        taskList.TraverseTasks();

        Console.WriteLine("\nSearching Task 102:");

        Task task = taskList.SearchTask(102);

        if (task != null)
        {
            Console.WriteLine(
                $"Found: {task.TaskName}");
        }

        taskList.DeleteTask(102);

        taskList.TraverseTasks();
    }
}