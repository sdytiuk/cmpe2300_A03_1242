using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace equals
{
    class Box
    {
        static Random r = new Random();
        private int Width;
        private int Height;

        public Box(int w, int h)
        {
            Width = w;
            Height = h;
        }

        public override bool Equals(object obj)
        {
            //test for NULL and TYPE
            if (!(obj is Box arg)) return false;
            return (Width == arg.Width && Height == arg.Height);
        }

        public static bool operator ==(Box left, Box right)
        {
            if (ReferenceEquals(left, right)) return true;
            if (left == null ^ right == null) return false;
            return left.Equals(right);
        }

        public static bool operator != (Box left, Box right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return Height;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Box a, b, c;
            a = new Box(2, 2);
            b = new Box(3, 3);
            c = new Box(2, 2);

            Console.WriteLine(a.Equals(b));
            Console.WriteLine(a.Equals(null));
            Console.WriteLine(a.Equals(1));
            Console.WriteLine(a.Equals(c));

            Console.Read();
        }
    }
}
