using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> aLinked = new LinkedList<string>();
            aLinked.AddFirst("Lucas");
            aLinked.AddLast("Alex");

            //how to add Ken after Lucas?
            //can return handle to the new node
            LinkedListNode<string> KenNode =
                aLinked.AddAfter(aLinked.First, "Ken");

            //how do we add Feruz after Ken?
            aLinked.AddAfter(KenNode, "Feruz");

            //how do we add Moy before Ken?
            aLinked.AddBefore(SearchForValue(aLinked, "Ken"), "Moy");

            PrintLinkedList(aLinked);
            Console.ReadKey();
        }

        static void PrintLinkedList(LinkedList<string> l)
        {
            for(LinkedListNode<string> i = l.First; i != null; i = i.Next)
            {
                Console.WriteLine(i.Value);
            }
        }

        static LinkedListNode<string> SearchForValue(LinkedList<string> l, string val)
        {
            for (LinkedListNode<string> i = l.First; i != null; i = i.Next)
            {
                if (i.Value.Equals(val)) return i;
            }
            return null;
        }
    }
}
