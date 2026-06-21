using System;

class Program
{
    static void Main(string[] args)
    {
        EmployeeManager manager =
            new EmployeeManager(10);

        manager.AddEmployee(
            new Employee(101, "Rahul",
                         "Developer", 60000));

        manager.AddEmployee(
            new Employee(102, "Priya",
                         "Tester", 50000));

        manager.AddEmployee(
            new Employee(103, "Amit",
                         "Manager", 80000));

        manager.TraverseEmployees();

        Console.WriteLine("\nSearching Employee 102:");

        Employee employee =
            manager.SearchEmployee(102);

        if (employee != null)
        {
            Console.WriteLine(
                $"Found: {employee.Name}");
        }

        manager.DeleteEmployee(102);

        manager.TraverseEmployees();
    }
}