using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace CircleCalculator
{
    class FindValues
    {
        public double FindArea(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        public double FindCircumference(double radius)
        {
            return 2 * Math.PI * radius;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the radius of the circle:");
            double radius = Convert.ToDouble(Console.ReadLine());

            FindValues circleCalculator = new FindValues();

            double area = circleCalculator.FindArea(radius);
            double circumference = circleCalculator.FindCircumference(radius);

            Console.WriteLine($"Area of the circle: {area}");
            Console.WriteLine($"Circumference of the circle: {circumference}");

            Console.ReadLine(); 
        }
    }
}