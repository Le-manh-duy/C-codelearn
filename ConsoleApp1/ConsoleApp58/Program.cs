using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp58
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            do
            {
                if(i %10 == 0)
                {
                    Console.WriteLine(i + " ");
                }
                i++;
            } while (i <= 1000);
        }
    }
}
