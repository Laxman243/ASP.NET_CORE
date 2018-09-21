using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class SortedList
    {
        static void Main()
        {
            //creating sortedList 
            SortedList<int,string> ss = new SortedList<int,string>();
            Console.WriteLine("initial capacity is :"+ ss.Capacity);
            Console.WriteLine("==========================");
            //populating sorted list
            ss.Add(1, "laxman");
            ss.Add(2, "shukla");
            ss.Add(3, "bizruntime");

            foreach(KeyValuePair<int ,string> elements in ss)
            {
                int i = elements.Key;
                string s = elements.Value;
                Console.WriteLine("{0} : is key and {1} is value :", i, s);
            }
            Console.WriteLine("=========================");
            Console.WriteLine("final capacity is :" + ss.Capacity);
            Console.WriteLine("=========================");
            
            Console.ReadKey();
        }
    }
}
