using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());
            double pi = 3.14;
            Console.WriteLine("Circumference = " + (2 * pi * r));
        }
    }
}
