using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car myCar;

            System.Console.WriteLine("Creating a Car object and assigning " + "its memory location to myCar");
            myCar = new Car();

            myCar.make = "Toyota";
            myCar.model = "MR2";
            myCar.color = "Black";
            myCar.yearBuilt = 1995;
            System.Console.WriteLine("myCar details :");
            System.Console.WriteLine("myCar.model= " + myCar.model);
            System.Console.WriteLine("myCar.color = " +myCar.color);

           System.Console.WriteLine("myCar.make= " + myCar.make);
            System.Console.WriteLine("myCar.yearBuilt= " + myCar.yearBuilt);
            // call the methods using myCar
            myCar.Start();
            myCar.Stop();
            // declare another Car object reference and
            // create another Car object
            System.Console.WriteLine("Creating another Car object and "+ "assigning its memory location to redPorsche");
            Car redPorscher = new Car();
            redPorscher.make = "Porscher";
            redPorscher.model = "Boxster";
            redPorscher.color = "red";
            redPorscher.yearBuilt = 2000;
            System.Console.WriteLine("redPoscher is a " + redPorscher.model);

            System.Console.WriteLine("Assigning redporscher to myCar");
            myCar = redPorscher;
            System.Console.WriteLine("myCar details");
            System.Console.WriteLine("myCar.make = " + myCar.make);
            System.Console.WriteLine("myCar.model = " + myCar.model);
            System.Console.WriteLine("myCar.color = " + myCar.color);
            System.Console.WriteLine("myCar.yearBuilt = " + myCar.yearBuilt);
            // assign null to myCar (myCar will no longer reference 
            //an object)
            myCar = null;
            Console.ReadLine();






        }
    }
}
