using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp32
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (n % 2 ==0)
            {
                Console.WriteLine("n is an even number");
            }
            else
            {
                Console.WriteLine("n is an odd number");
            }
        }
    }
}
