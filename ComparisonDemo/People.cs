// Steven Dytiuk
//Comparison Demo
//2025-02-05

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparisonDemo
{
    internal class People :IComparable
    {
        int height;
        int weight;
        int waistsize;
        string gpa;

        public int Height { get { return height; } }
        public int Weight { get => weight; }

        public int Waist { get => waistsize; }

        public People (int h, int w, int waistsize, string g)
        {
            height = h;
            weight = w;
            this.waistsize = waistsize;
            gpa = g;
        }

        /// <summary>
        /// Compares two people's height
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public int CompareTo(object other)
        {
            if (!(other is People p))
            {
                throw new ArgumentException("Tried to compare people to a non-people!");
            }
            return height.CompareTo(p.height);
        }

        /// <summary>
        /// Compares two people by ascending weight
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static int CompareWeight(People a, People b)
        {
            return a.weight.CompareTo(b.weight);
        }

        /// <summary>
        /// Compare by Waist Size ASC
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static int CompareWaists(People a, People b)
        {
            return a.waistsize.CompareTo(b.waistsize);
        }

        /// <summary>
        /// Compare by GPA ASC
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static int CompareGPA(People a, People b)
        {
            return a.gpa.CompareTo(b.gpa);
        }

        public override string ToString()
        {
            return "Height: " + height + "; Weight: " + weight + "; Waist: " + waistsize + "; GPA: " + gpa;
        }
    }
}
