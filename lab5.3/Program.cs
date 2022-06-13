using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5._3
{
    internal class Program
    {
        private static object objSL;

        static void Main(string[] args)
        {
            SortedList objSl = new SortedList();
            objSl.Add("4", "!");
            objSl.Add("3", "Brilliant");
            objSl.Add("2", "am");
            objSl.Add("1", "I");
            Console.WriteLine("Number of Element in objSl  : {0}", objSl.Count);
            Console.WriteLine("\t-KEY - \t-Value-");
            for (int i = 0; i < objSl.Count; i++)
            {
                Console.WriteLine("\t{0}:\t{1}", objSl.GetKey(i),objSl.GetByIndex(i));
            }
            Console.ReadLine();
        }
    }
}
