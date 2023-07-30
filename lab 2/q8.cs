using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace AnimalApp
{
    class Animal
    {
        public void DisplayAnimal()
        {
            Console.WriteLine("I am an Animal");
        }
    }

    class Dog : Animal
    {
        public void DisplayDog()
        {
            Console.WriteLine("I have four legs");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dog dogObj = new Dog();
            dogObj.DisplayAnimal();
            dogObj.DisplayDog();

            Console.ReadLine(); 
        }
    }
}
