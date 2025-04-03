using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace lambdas_and_inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            x = 5;
            y = 6;

            Func<int> addInside = () =>
            {
                return x + y;
            };

            Console.WriteLine(addInside());

            Me steven = new Me();

            ISimple Lucas = new Me();

            ISimple SimpleSteve = (ISimple)steven;
            Console.Read();
            
        }

        /*static int add ()
        {
            return x + y;
        }*/
    }

    interface ISimple
    {

    }

    class Me : ISimple
    {

    }
}
