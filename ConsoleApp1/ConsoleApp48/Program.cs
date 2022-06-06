using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp48
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int answer = 1;
            for(int i =1; i<=n; i++)
            {
                answer*=i;
            }
            Console.WriteLine(answer);
        }
    }
}
