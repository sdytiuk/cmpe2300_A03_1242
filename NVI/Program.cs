using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NVI
{
    abstract class Shape
    {
        public double Area()
        {
            return vArea();
        }

        protected virtual double vArea()
        {
            return 0;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Shape s)) return false;
            return Area().Equals(s.Area());
        }

        public override int GetHashCode()
        {
            return 1;
        }
    }

    class Circle : Shape
    {
        double radius;
        int identifier;

        protected override double vArea()
        {
            return radius * radius * Math.PI;
        }

        public Circle(double r, int id)
        {
            radius = r;
            identifier = id;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Circle c)) return false;
            if (identifier.Equals(c.identifier))
                return base.Equals(c);
            else
                return identifier.Equals(c.identifier);
        }

        public override int GetHashCode()
        {
            return 1;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Shape> s = new List<Shape>();
            s.Add(new Circle(5, 0));
            s.Add(new Circle(5, 1));
            s.Add(new Circle(3, 2));
            //Shape s4 = new Shape();

            s.Remove(s[1]);
            Console.ReadLine();
        }
    }
}
