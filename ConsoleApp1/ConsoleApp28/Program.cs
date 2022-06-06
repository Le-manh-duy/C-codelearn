using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            a += b;
            b = a - b;
            a -= b;
            Console.WriteLine("After swapping , a :" + a + "\nb :" + b);
        }
    }
}
