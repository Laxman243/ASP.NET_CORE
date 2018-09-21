using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class QueueExample
    {
        static void Main()
        {
            Queue<int> numbers = new Queue<int>();

            // fill the queue
            Console.WriteLine("populating the queue");
            foreach(int number in new int[] { 10,20,30,40,50})
            {
                numbers.Enqueue(number);
                Console.WriteLine("{0} has joined the queue", number);
            }
            Console.WriteLine("====================");
            // second time populating queue with for loop
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            //empty the queue
            Console.WriteLine("\nDraining the queue:");
            Console.WriteLine("====================");
            Console.WriteLine("first element :" + numbers.Peek());
            Console.WriteLine("Max Element :" + numbers.Max());
            Console.WriteLine("====================");
            while (numbers.Count > 0)
            {
                int number = numbers.Dequeue();
               Console.WriteLine("{0} has left the queue", number);
            }
            Console.WriteLine("====================");
            Console.WriteLine("capacity:" + numbers.Count);

            //Another queue 
            Queue<string> str1 = new Queue<string>();
            str1.Enqueue("laxman");
            str1.Enqueue("laxman");
            str1.Enqueue(null);
            str1.Enqueue("Shukla");

            foreach(string str in str1)
            {
                Console.WriteLine(str);
            }
            Console.WriteLine(str1.GetHashCode());
            Console.ReadKey();
        }
    }
}
