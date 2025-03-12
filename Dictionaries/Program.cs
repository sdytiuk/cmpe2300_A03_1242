using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionaries
{
    internal class Program
    {
        internal static bool StartsWithH(KeyValuePair<string, double>kvp)
        {
            return kvp.Key.ToLower().StartsWith("h");
        }
        static void Main(string[] args)
        {
            Dictionary<string, double> StudentGrades = 
                new Dictionary<string, double>();
            StudentGrades["Hajay"] = 0;
            StudentGrades["Huy"] = 99;
            StudentGrades["Huy"] += 99;
            StudentGrades["Feruz"] = 5;
            StudentGrades["Lucas"] = 27;
            StudentGrades["Ken"] = 50;

            try
            {
                StudentGrades.Add("Hajay", 50);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Cannnot have two students with the same name!");
            }

            if (StudentGrades.ContainsKey("Hajay"))
                StudentGrades["Hajay"] += 10;
            else
                StudentGrades["Hajay"] = 0;
            Console.WriteLine(StudentGrades["Hajay"]);

            Console.WriteLine(StudentGrades); //inutil

            foreach (KeyValuePair<string, double> kvp in StudentGrades)
                Console.WriteLine($"{kvp.Key} has grade: {kvp.Value}");

            //just print student names?
            foreach (string s in StudentGrades.Keys)
                Console.WriteLine(s);

            //just print values?
            foreach (double d in StudentGrades.Values)
                Console.WriteLine(d);

            //put all the keys in a list
            List<string> names = StudentGrades.Keys.ToList();

            //extension methods... Predicate...
            //only print students starting with H
            foreach (KeyValuePair<string, double> kvp in
                //StudentGrades.Where(x => x.Key[0] == 'H'))
                StudentGrades.Where(StartsWithH))
                Console.Write($"Starts with H: {kvp.Key}: {kvp.Value}");
            Console.Read();
        }
    }
}
