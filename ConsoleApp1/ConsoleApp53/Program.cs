using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp53
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int .Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int answer = 1;
            while(b > 0)
            {
                answer *= a;
                b--;

            }
            Console.Write(answer);
        }
    }
}
