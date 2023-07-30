using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace ArrayHandling
{
    public class ArrayHandler
    {
        public void ProcessArray(int size)
        {
            int[] userArray = new int[size * 2]; 

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"Enter value {i + 1}:");
                userArray[i * 2] = Convert.ToInt32(Console.ReadLine());
                userArray[i * 2 + 1] = 0; 
            }

            Console.WriteLine("Array Values:");
            foreach (int value in userArray)
            {
                Console.Write($"{value} ");
            }
            Console.WriteLine();
        }
    }

    class MainClass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the array:");
            int size = Convert.ToInt32(Console.ReadLine());

            ArrayHandler arrayHandler = new ArrayHandler();
            arrayHandler.ProcessArray(size);

            Console.ReadLine(); 
        }
    }
}
