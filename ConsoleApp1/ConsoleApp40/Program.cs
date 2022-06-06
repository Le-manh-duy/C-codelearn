using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp40
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int score = int.Parse(Console.ReadLine());
            if(score < 0 || score > 10)
            {
                Console.WriteLine("the score is not valid");

            }
            else
            {
                Console.WriteLine("the score is valid");
            }
        }
    }
}
