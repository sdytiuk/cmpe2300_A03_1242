using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryAdvanced
{
    //A class to use for advanced dictionary operations
    class Package : IComparable
    {
        public string Company { get; set; }
        public double Weight { get; set; }
        public long TrackingNumber { get; set; }
        public Package(string co, double w, long tn)
        {
            Company = co;
            Weight = w;
            TrackingNumber = tn;
        }

        public override string ToString()
        {
            return Company + ": " + Weight + " [" + TrackingNumber + "]";
        }

        public int CompareTo(object obj)
        {
            if (!(obj is Package p)) throw new ArgumentException("Wrong type");

            return TrackingNumber.CompareTo(p.TrackingNumber);
        }

        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (obj is Package p)
            {
                return TrackingNumber.Equals(p.TrackingNumber);
            }
            return false;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //create a list of packages
            List<Package> packages = new List<Package>();
            packages.Add(new Package("Feruz Freezies", 5.3, 99L));
            packages.Add(new Package("Connor McDavids", 50, 97L));
            packages.Add(new Package("Vitos Vidas", 100, 338493L));
            packages.Add(new Package("Lucas Skywalkers", 555, 314314314L));
            packages.Add(new Package("Alex Sorpresas", 2, 2L));
            packages.Add(new Package("Huy Vanilli", 0, 2L));

            //print out the list of packages
            foreach(Package package in packages)
            {
                Console.WriteLine(package);
            }

            //Create a dictionary of package objects from the List of packages
            //how do you pick the key?
            //what happens if there becomes duplicate keys?
            Dictionary<string, Package> dictPackages =
                packages.ToDictionary(p => p.Company);

            foreach (KeyValuePair<string, Package> kvp in dictPackages)
                Console.WriteLine($"{kvp.Key} {kvp.Value}");

            // Dictionary<long, Package> dictPackagesTN =
            //    packages.ToDictionary(p => p.TrackingNumber);

            //how do you get unique packages based on TrackingNumber??
            //TODO??? Why it's not working??
            /*Dictionary<long, Package> dictPackagesTN = 
                packages.Distinct().ToDictionary(p => p.TrackingNumber);*/

            foreach (KeyValuePair<string, Package> kvp in dictPackages)
                Console.WriteLine($"{kvp.Key} {kvp.Value}");

            //what if we want a different key?
            Dictionary<Package, Package> dictPackagesP =
                packages.ToDictionary(p => p);

            foreach (KeyValuePair<Package, Package> kvp in dictPackagesP)
                Console.WriteLine($"{kvp.Key} {kvp.Value}");

            //<package,string>??
            Dictionary<Package, string> dictPackagesPS =
                packages.ToDictionary(p => p, v => v.Company);

            foreach (KeyValuePair<Package, string> kvp in dictPackagesPS)
                Console.WriteLine($"{kvp.Key} {kvp.Value}");

            //can you access a dictionary like it's a list?? [0]??
            Console.WriteLine(dictPackages["Feruz Freezies"]);

            Console.Read();
        }
    }
}
