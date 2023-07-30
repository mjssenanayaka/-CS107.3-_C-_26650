using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace ConsoleApplication
{
    public class Employee
    {
        private int empID;
        private string empName;
        private string empDesignation;

        public int EmpID
        {
            get { return empID; }
            set { empID = value; }
        }

        public string EmpName
        {
            get { return empName; }
            set { empName = value; }
        }

        public string EmpDesignation
        {
            get { return empDesignation; }
            set { empDesignation = value; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Employee ID:");
            int empID = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Employee Name:");
            string empName = Console.ReadLine();

            Console.WriteLine("Enter Employee Designation:");
            string empDesignation = Console.ReadLine();

            Employee employee = new Employee();
            employee.EmpID = empID;
            employee.EmpName = empName;
            employee.EmpDesignation = empDesignation;

            Console.WriteLine($"Hello {employee.EmpName}, Your Employee ID is - {employee.EmpID} and You are a {employee.EmpDesignation}.");
            Console.ReadLine();
        }
    }
}
