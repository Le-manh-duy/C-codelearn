using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp39
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            if(10 <= a && a<= 100)
            {
                Console.WriteLine(a + " is in the range[10,100]");
            }
            else
            {
                Console.WriteLine(a + " is not in the range[10,100]");
            }
        }
    }
}
