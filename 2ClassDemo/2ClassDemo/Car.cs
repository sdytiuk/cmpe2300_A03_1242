using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ClassDemo
{
    internal class Car
    {
        private string CarType;
        private int YearBuilt;
        Random rand = new Random();

        //constructor with params
        public Car(string t, int y)
        {
            CarType = t;
            YearBuilt = y;
        }

        //leverage your constructor with params
        public Car(string t) : this(t, 2023)
        {
        }

        //default constructor (no params)
        public Car()
        {
            List<string> cartypes = new List<string>();
            cartypes.Add("Mazda");
            cartypes.Add("Ford");
            cartypes.Add("Chevy");
            CarType = cartypes[rand.Next(cartypes.Count)];
            YearBuilt = rand.Next(1980, 2026);
        }

        public override string ToString()
        {
            return YearBuilt + " " + CarType;
        }

        public void RenovateCar()
        {
            YearBuilt++;
        }

        public void ShowYourself()
        {
            Console.WriteLine(this);
        }

        
    }
}
