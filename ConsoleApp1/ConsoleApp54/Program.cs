using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp54
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            for(int i = a; i <= b; i++)
            {
                if(i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
