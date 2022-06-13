using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add("a", "A");
            ht.Add("b", "B");
            ht.Add("c", "C");
            ht.Add("d", "D");
            ht.Add("e", "E");
            ht["f"] = "F";
            ICollection c = ht.Keys;
            foreach(string str in c)
                Console.WriteLine(str + " :" + ht[str]);
        }
    }
}
