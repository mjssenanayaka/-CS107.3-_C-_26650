using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the size of the arrays:");
        int size = int.Parse(Console.ReadLine());

        int[] array1 = new int[size];
        int[] array2 = new int[size];
        int[] resultArray = new int[size];

        Console.WriteLine("Enter values for the first array:");
        for (int i = 0; i < size; i++)
        {
            array1[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Enter values for the second array:");
        for (int i = 0; i < size; i++)
        {
            array2[i] = int.Parse(Console.ReadLine());
        }

        
        int scalarSum = 0;
        for (int i = 0; i < size; i++)
        {
            scalarSum += array1[i] + array2[i];
        }
        Console.WriteLine("Scalar Sum: " + scalarSum);

        for (int i = 0; i < size; i++)
        {
            resultArray[i] = array1[i] + array2[i];
        }
        Console.WriteLine("Vector Sum:");
        DisplayArray(resultArray);

       
        for (int i = 0; i < size; i++)
        {
            resultArray[i] = array1[i] * array2[i];
        }
        Console.WriteLine("Vector Product:");
        DisplayArray(resultArray);

        
        int scalarProduct = 0;
        for (int i = 0; i < size; i++)
        {
            scalarProduct += array1[i] * array2[i];
        }
        Console.WriteLine("Scalar Product: " + scalarProduct);
    }

    static void DisplayArray(int[] array)
    {
        foreach (int num in array)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}
