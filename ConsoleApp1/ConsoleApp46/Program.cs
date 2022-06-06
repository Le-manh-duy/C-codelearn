using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp46
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int answer = 0;
            for(int i = 0; i <= a; i++)
            {
                if(i % 2 != 0)
                {
                    answer+=i;
                }
            }
            Console.WriteLine(answer);
        }
    }
}
