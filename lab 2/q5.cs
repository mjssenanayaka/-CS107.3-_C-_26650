using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace ArrayOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];

            // Input values to the array
            Console.WriteLine("Enter 10 integer values for the array:");
            for (int i = 0; i < 10; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Find minimum value
            int min = numbers[0];
            for (int i = 1; i < 10; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }

            // Find maximum value
            int max = numbers[0];
            for (int i = 1; i < 10; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }

            // Find average value
            int sum = 0;
            for (int i = 0; i < 10; i++)
            {
                sum += numbers[i];
            }
            double average = (double)sum / 10;

            // Reverse order of values
            int[] reversedNumbers = new int[10];
            for (int i = 0; i < 10; i++)
            {
                reversedNumbers[i] = numbers[9 - i];
            }

            // Display results
            Console.WriteLine("Minimum value: " + min);
            Console.WriteLine("Maximum value: " + max);
            Console.WriteLine("Average value: " + average);
            Console.WriteLine("Reverse order of values:");
            foreach (int number in reversedNumbers)
            {
                Console.Write(number + " ");
            }

            Console.ReadLine(); 
        }
    }
}
