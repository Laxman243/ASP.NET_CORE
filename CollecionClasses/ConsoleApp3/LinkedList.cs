using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class LinkedList
    {
        static void Main()
        {

            // declaring an LinkedList
            LinkedList<int> obj = new LinkedList<int>();

            //Adding Elements to the LinkedList
            foreach (int number in new int[] { 1, 2, 3, 4, 4 })
            {
                obj.AddFirst(number);
            }
            //reading elements from the LinkedList
            foreach(int i in obj)
            {
                Console.WriteLine(i);
            }
            // iterating list in forword direction
            Console.WriteLine("Iterating in forword direction");
            for (LinkedListNode<int> node = obj.First; node != null; node = node.Next)
            {
                int number = node.Value;
                Console.WriteLine(number);
            }

            // reading items in Reverse order
            Console.WriteLine("in Reverse order");
            for (LinkedListNode<int> node = obj.Last; node != null; node = node.Previous)
            {
                int number = node.Value;
                Console.WriteLine(number);
            }
            Console.WriteLine("======================");
            LinkedList<int> l2 = new LinkedList<int>();
            l2.AddFirst(10);
            l2.AddFirst(10);
            l2.AddFirst(20);
            
            foreach (int i in l2)
            {
                Console.WriteLine(i);
            }
                Console.ReadKey();    
        }
    }
}
