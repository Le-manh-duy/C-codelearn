using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp52
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int answer = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    answer++;
                }
            }
            Console.Write(answer);
        }
    }
}
