using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Box b = new Box(5,"Dark Roast Coffee");

            b.Width = 10;
            //b.boxName = "Coffee";
            Console.WriteLine(b.Width + b.boxName);
            Console.Read();
        }


    }
}
