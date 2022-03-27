using System;

namespace Task5
{
    class MVCPatternDemo
    {
        static void Main(string[] args)
        {
            Student model = RetriveStudentFromDatabase();

            //Create a view : to write student details on console
            StudentView view = new StudentView();

            StudentController controller = new StudentController(model, view);

            controller.UpdateView();

            //update model data
            controller.SetStudentName("John");

            controller.UpdateView();
        }

        private static Student RetriveStudentFromDatabase()
        {
            Student student = new Student();
            student.SetName("Robert");
            student.SetRollNo("10");
            return student;
        }
    }
}