using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace BasicArithmeticOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first integer:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second integer:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int sum = num1 + num2;
            int subtraction = num1 - num2;
            int multiplication = num1 * num2;
            double division = (double)num1 / num2;

            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Subtraction: {subtraction}");
            Console.WriteLine($"Multiplication: {multiplication}");
            Console.WriteLine($"Division: {division}");

            Console.ReadLine(); // Optional: to keep the console window open until you press Enter.
        }
    }
}