﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp56
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int i=1; i<=100; i++)
            {
                if(i %2 != 0)
                {
                    continue;

                }
                Console.WriteLine(i);
            }
        }
    }
}
