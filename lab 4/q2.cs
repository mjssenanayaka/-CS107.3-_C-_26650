using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace ArithmeticOperations
{
    public class ArithmeticCalculator
    {
        private double num1;
        private double num2;

        public double Num1
        {
            get { return num1; }
            set { num1 = value; }
        }

        public double Num2
        {
            get { return num2; }
            set { num2 = value; }
        }

        public double Summation()
        {
            return num1 + num2;
        }

        public double Subtraction()
        {
            return num1 - num2;
        }

        public double Multiplication()
        {
            return num1 * num2;
        }

        public double Division()
        {
            if (num2 != 0)
            {
                return num1 / num2;
            }
            else
            {
                Console.WriteLine("Division by zero is not allowed.");
                return 0;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ArithmeticCalculator calculator = new ArithmeticCalculator();

            Console.WriteLine("Enter Number 1:");
            calculator.Num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Number 2:");
            calculator.Num2 = Convert.ToDouble(Console.ReadLine());

            double sum = calculator.Summation();
            double difference = calculator.Subtraction();
            double product = calculator.Multiplication();
            double quotient = calculator.Division();

            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Difference: {difference}");
            Console.WriteLine($"Product: {product}");
            Console.WriteLine($"Quotient: {quotient}");

            Console.ReadLine(); 
        }
    }
}
