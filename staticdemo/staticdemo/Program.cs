using System;
using System.Collections.Generic;
using System.Deployment.Internal;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace staticdemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("FIRST LINE");
            List<Person> people = new List<Person>();
            Console.WriteLine("MADE LIST.");

            people.Add(new Person());
            Console.WriteLine("MADE FIRST PERSON");

            for (int i = 0; i < 1000; i++)
            {
                people.Add(new Person());
            }
                

            for (int i = 0; i < people.Count; i++)
                Console.Write(people[i].ID + "; ");
            Console.Read();
        }
    }

    class Person
    {
        int? id;

        public int? ID
        {
            get
            {
                return id;
            }
        }
        static Random r = null;
        public Person()
        {
            Console.WriteLine("Instance Constructor");
            id = r?.Next();
        }

        //static constructor
        static Person()
        {
            r = new Random();
            Console.WriteLine("STATIC CONSTRUCTOR!");
        }
    }
}
