using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace ArithmeticCalculator
{
    class CalculateValues
    {
        public double Addition(double num1, double num2)
        {
            return num1 + num2;
        }

        public double Subtraction(double num1, double num2)
        {
            return num1 - num2;
        }

        public double Multiplication(double num1, double num2)
        {
            return num1 * num2;
        }

        public double Division(double num1, double num2)
        {
            return num1 / num2;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1 for Addition");
            Console.WriteLine("Enter 2 for Subtraction");
            Console.WriteLine("Enter 3 for Multiplication");
            Console.WriteLine("Enter 4 for Division");

            Console.WriteLine("Enter Your Choice:");
            int choice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Number 1:");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Number 2:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            CalculateValues calculator = new CalculateValues();

            double result = 0;
            switch (choice)
            {
                case 1:
                    result = calculator.Addition(num1, num2);
                    break;
                case 2:
                    result = calculator.Subtraction(num1, num2);
                    break;
                case 3:
                    result = calculator.Multiplication(num1, num2);
                    break;
                case 4:
                    result = calculator.Division(num1, num2);
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }

            Console.WriteLine($"Your Answer is : {result}");
            Console.ReadLine(); 
        }
    }
}