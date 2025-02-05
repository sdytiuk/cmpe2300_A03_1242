using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ComparisonDemo.People;

namespace ComparisonDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<People> persons = new List<People>();
            Random r = new Random();

            for (int i=10; i<100; i+=10)
            {
                persons.Add(new People(150 + i / 10, 240 - i, r.Next(25,45), ((char)('A' + r.Next(5))).ToString()));
            }

            Console.WriteLine("Original People");
            foreach (People p in persons)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine("\n------------------------------------------------");
            Console.WriteLine("ICompare (height) of People");
            //persons.Sort();
            foreach (People p in persons)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine("\n------------------------------------------------");
            Console.WriteLine("Comparison (weight) of People");
            persons.Sort(CompareWeight);
            foreach (People p in persons)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine("\n------------------------------------------------");
            Console.WriteLine("Comparison (waist) of People");
            persons.Sort(CompareWaists);
            foreach (People p in persons)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine("\n------------------------------------------------");
            Console.WriteLine("Comparison (GPA) of People");
            persons.Sort(CompareGPA);
            foreach (People p in persons)
            {
                Console.WriteLine(p);
            }

            Console.WriteLine("\n------------------------------------------------");
            PeopleCompare pc = new PeopleCompare();
            Console.WriteLine("ICompare (height) of People");
            persons.Sort(pc);
            foreach (People p in persons)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine("\n------------------------------------------------");
            Console.WriteLine("ICompare (height DESC) of People");
            pc.SortType = PeopleCompare.ESortType.HeightD;
            persons.Sort(pc);
            foreach (People p in persons)
            {
                Console.WriteLine(p);
            }


            Console.ReadLine();
        }
    }
}
