using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
//reference: https://dotnettutorials.net/lesson/interlocked-vs-lock-in-csharp/
namespace InterlockedDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int IncrementValue = 0;
            //for (int i = 0; i < 100000; i++)
            Parallel.For(0, 100000, _ => 
            {
                //IncrementValue++; NON THREAD SAFE
                Interlocked.Increment(ref IncrementValue);
            
            }
            );
                
            Console.WriteLine("Expected Result: 100000");
            Console.WriteLine($"Actual Result: {IncrementValue}");
            Console.ReadKey();
        }
    }
}
