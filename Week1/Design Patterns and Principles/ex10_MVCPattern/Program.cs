using System;

class Program
{
    static void Main(string[] args)
    {
        Student model = new Student(
            "Nenika",
            101,
            "A"
        );

        StudentView view = new StudentView();

        StudentController controller =
            new StudentController(model, view);

        controller.UpdateView();

        Console.WriteLine();

        controller.SetStudentName("Jennie");
        controller.SetStudentGrade("A+");

        Console.WriteLine("After Update:");
        controller.UpdateView();
    }
}