using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            double gpa = double.Parse(Console.ReadLine());
            Console.WriteLine("Name " + name);
            Console.WriteLine("Age " + age);
            Console.WriteLine("Grade Point Average: " + gpa);
        }
    }
}
