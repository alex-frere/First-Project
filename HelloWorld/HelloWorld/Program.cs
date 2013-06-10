using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name.");
            var name = Console.ReadLine();
            Console.WriteLine("Hello World! It's a pleasure to meet you " + name);
            Console.ReadLine();
        }
    }
}
