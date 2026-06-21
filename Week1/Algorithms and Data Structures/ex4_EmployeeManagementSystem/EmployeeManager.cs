using System;

public class EmployeeManager
{
    // Time Complexity Summary
    // Add Employee      : O(1)
    // Search Employee   : O(n)
    // Traverse Records  : O(n)
    // Delete Employee   : O(n)

    private Employee[] employees;
    private int count;

    public EmployeeManager(int size)
    {
        employees = new Employee[size];
        count = 0;
    }

    public void AddEmployee(Employee employee)
    {
        // O(1)
        if (count < employees.Length)
        {
            employees[count] = employee;
            count++;
            Console.WriteLine("Employee Added");
        }
        else
        {
            Console.WriteLine("Array Full");
        }
    }

    public Employee SearchEmployee(int employeeId)
    {
        // O(n)
        for (int i = 0; i < count; i++)
        {
            if (employees[i].EmployeeId == employeeId)
            {
                return employees[i];
            }
        }

        return null;
    }

    public void TraverseEmployees()
    {
        // O(n)
        Console.WriteLine("\nEmployee Records:");

        for (int i = 0; i < count; i++)
        {
            Console.WriteLine(
                $"ID: {employees[i].EmployeeId}, " +
                $"Name: {employees[i].Name}, " +
                $"Position: {employees[i].Position}, " +
                $"Salary: {employees[i].Salary}");
        }
    }

    public void DeleteEmployee(int employeeId)
    {
        // O(n)
        int index = -1;

        for (int i = 0; i < count; i++)
        {
            if (employees[i].EmployeeId == employeeId)
            {
                index = i;
                break;
            }
        }

        if (index == -1)
        {
            Console.WriteLine("Employee Not Found");
            return;
        }

        // Shift elements left
        // O(n)
        for (int i = index; i < count - 1; i++)
        {
            employees[i] = employees[i + 1];
        }

        employees[count - 1] = null;
        count--;

        Console.WriteLine("Employee Deleted");
    }
}