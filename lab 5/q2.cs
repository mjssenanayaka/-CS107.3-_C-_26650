using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace ArithmeticOperations
{
    public class GetNumbers
    {
        protected double num1;
        protected double num2;

        public GetNumbers()
        {
            Console.WriteLine("Enter Number 1:");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Number 2:");
            num2 = Convert.ToDouble(Console.ReadLine());
        }
    }

    public class Summation : GetNumbers
    {
        public double CalculateSum()
        {
            return num1 + num2;
        }
    }

    public class Substraction : GetNumbers
    {
        public double CalculateDifference()
        {
            return num1 - num2;
        }
    }

    public class Multiplication : GetNumbers
    {
        public double CalculateProduct()
        {
            return num1 * num2;
        }
    }

    public class Division : GetNumbers
    {
        public double CalculateQuotient()
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
            Summation sum = new Summation();
            double sumResult = sum.CalculateSum();

            Substraction sub = new Substraction();
            double differenceResult = sub.CalculateDifference();

            Multiplication mul = new Multiplication();
            double productResult = mul.CalculateProduct();

            Division div = new Division();
            double quotientResult = div.CalculateQuotient();

            Console.WriteLine($"Sum: {sumResult}");
            Console.WriteLine($"Difference: {differenceResult}");
            Console.WriteLine($"Product: {productResult}");
            Console.WriteLine($"Quotient: {quotientResult}");

            Console.ReadLine(); 
        }
    }
}
