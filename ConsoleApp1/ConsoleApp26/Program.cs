using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (n >0) { 
                Console.WriteLine("n is a postive number");
            }
            else
            {
                Console.WriteLine("n is a negaive number");
            }
        }
    }
}
