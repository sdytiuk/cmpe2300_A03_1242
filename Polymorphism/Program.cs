using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Animal //this might be better as an abstract class...!
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("burp");
        }

    }

    public class Dog : Animal
    {
        public override void MakeSound()
        {
            //base.MakeSound();
            Console.WriteLine("WOOF WOOF");
        }
    }

    public class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("MEOW purrrrrrrrr MEOW");
            base.MakeSound();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            animals.Add(new Animal());
            animals.Add(new Dog());
            animals.Add(new Cat());

            animals.ForEach(x => x.MakeSound());

            Console.Read();
        }
    }
}
