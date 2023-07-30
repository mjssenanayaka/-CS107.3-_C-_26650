using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace HelloWorldNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            HelloWorld helloObj = new HelloWorld();
            helloObj.SayHello(); // This line will give a compilation error since "SayHello" is a private method.
            Console.ReadLine(); // Optional: to keep the console window open until you press Enter.
        }
    }
}