using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace NumberOperations
{
    public class GetNumbers
    {
        protected double num1;
        protected double num2;

        public GetNumbers(double num1, double num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }
    }

    public class Summation : GetNumbers
    {
        public Summation(double num1, double num2) : base(num1, num2)
        {
        }

        public void CalculateSum()
        {
            double result = num1 + num2;
            Console.WriteLine($"Sum: {result}");
        }
    }

    public class Substraction : GetNumbers
    {
        public Substraction(double num1, double num2) : base(num1, num2)
        {
        }

        public void CalculateDifference()
        {
            double result = num1 - num2;
            Console.WriteLine($"Difference: {result}");
        }
    }

    public class Multiplication : GetNumbers
    {
        public Multiplication(double num1, double num2) : base(num1, num2)
        {
        }

        public void CalculateProduct()
        {
            double result = num1 * num2;
            Console.WriteLine($"Product: {result}");
        }
    }

    public class Division : GetNumbers
    {
        public Division(double num1, double num2) : base(num1, num2)
        {
        }

        public void CalculateQuotient()
        {
            if (num2 != 0)
            {
                double result = num1 / num2;
                Console.WriteLine($"Quotient: {result}");
            }
            else
            {
                Console.WriteLine("Division by zero is not allowed.");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Number Operations!");

            Console.WriteLine("Enter the first number:");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Summation sum = new Summation(num1, num2);
            sum.CalculateSum();

            Substraction sub = new Substraction(num1, num2);
            sub.CalculateDifference();

            Multiplication mul = new Multiplication(num1, num2);
            mul.CalculateProduct();

            Division div = new Division(num1, num2);
            div.CalculateQuotient();

            Console.ReadLine(); 
        }
    }
}
