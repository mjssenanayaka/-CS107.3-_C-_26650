using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StudentGradeProgram
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter the student's name: ");
            string studentName = Console.ReadLine();

            Console.Write("Enter the student's marks: ");
            int studentMarks = int.Parse(Console.ReadLine());

            string grade;

            if (studentMarks >= 75 && studentMarks <= 100)
                grade = "A";
            else if (studentMarks >= 60 && studentMarks < 75)
                grade = "B";
            else if (studentMarks >= 50 && studentMarks < 60)
                grade = "C";
            else if (studentMarks >= 40 && studentMarks < 50)
                grade = "D";
            else
                grade = "Fail";

            Console.WriteLine($"{studentName} got Grade {grade}.");
        }
    }
}


