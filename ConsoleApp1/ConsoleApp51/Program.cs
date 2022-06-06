using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp51
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
           
            while (n <= 100)
            {
                if (n % 2 == 0)
                {
                    Console.Write(n + " ");
                }
                n += 1;
            }

        }
    }
}

