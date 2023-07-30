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

        public GetNumbers()
        {
            Console.WriteLine("Enter the first number:");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            num2 = Convert.ToDouble(Console.ReadLine());
        }
    }

    public class Summation : GetNumbers
    {
        public void CalculateSum()
        {
            double result = num1 + num2;
            Console.WriteLine($"Sum: {result}");
        }
    }

    public class Substraction : GetNumbers
    {
        public void CalculateDifference()
        {
            double result = num1 - num2;
            Console.WriteLine($"Difference: {result}");
        }
    }

    public class Multiplication : GetNumbers
    {
        public void CalculateProduct()
        {
            double result = num1 * num2;
            Console.WriteLine($"Product: {result}");
        }
    }

    public class Division : GetNumbers
    {
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

            Summation sum = new Summation();
            sum.CalculateSum();

            Substraction sub = new Substraction();
            sub.CalculateDifference();

            Multiplication mul = new Multiplication();
            mul.CalculateProduct();

            Division div = new Division();
            div.CalculateQuotient();

            Console.ReadLine(); 
        }
    }
}
