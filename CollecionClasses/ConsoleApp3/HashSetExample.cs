using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class HashSetExample
    {
        static void Main()
        {
            HashSet<string> hs = new HashSet<string>(new string[] { "abc","def","ghi","jkl","mno","rahul"});
            HashSet<string> students = new HashSet<string>(new string[] { "laxman", "amreen", "rahul" });
            //populate the hashSet 
            HashSet<int> hs1 = new HashSet<int>();
            hs1.Add(10);
            hs1.Add(20);
            hs1.Add(30);
            hs1.Add(40);
            Console.WriteLine("Display data from hashSet");
            foreach(string s in hs)
            {
                Console.WriteLine(s + " " );
            }
            Console.WriteLine("numeric data display");
            foreach(int i in hs1)
            {
                Console.WriteLine(i);
            }
            foreach (string name in students)
            {
                Console.WriteLine(name);
            }
            students.IntersectWith(hs);
            Console.WriteLine("student who also be hs");
            foreach (string name in students)
            {
                Console.WriteLine(name);
            }

            Console.ReadKey();
        }
    }
}
