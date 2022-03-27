using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public class StudentView
    {
        public void printStudentDetails(String studentName, String studentRollNo)
        {
            Console.WriteLine("Student: ");
            Console.WriteLine("Name: " + studentName);
            Console.WriteLine("Roll No: " + studentRollNo);
        }
    }
}
