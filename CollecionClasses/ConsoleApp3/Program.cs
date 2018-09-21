using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    //simple List example
    class List
    {
        static void Main(string[] args)
        {
            List<int> l = new List<int>();
            Console.WriteLine(l.Capacity);
            l.Add(10);
            l.Add(20);
            Console.WriteLine(l.Capacity);

            List<string> ls = new List<string>(10);
            ls.Add("Laxman");
            ls.Add("laxman");
            ls.Add(null);
            ls.Add("Amreen");
            ls.Add("Shukla");
            Console.WriteLine(ls.Capacity);

            List<double> ld = new List<double>();
            ld.Add(20);
            ld.Add(20.00);
            ld.Add(30);

            // print the itmes from the integer list 
            Console.WriteLine("Print From Integer List");
            foreach(int i in l)
            {
                Console.WriteLine(i);
            }

            //printing items from the String List
            ls.Sort();
            Console.WriteLine("Print From String List");
            foreach(string j in ls)
            {
                Console.WriteLine(j);
            }

            Console.WriteLine("Print from Double List");
            foreach(double i in ld)
            {
                Console.WriteLine(i);
            }

            // now delete / remove items from the list
            ls.Remove("Laxman");
            foreach (string j in ls)
            {
                Console.WriteLine(j);
            }

            // delete the itmes from the specific location
            l.RemoveAt(1);
            foreach(int i in l)
            {
                Console.WriteLine(i);
            }
            // iterarting list item in Forword direction
                Console.ReadKey();
        }
    }
    // class type data it considered
    class Sample1
    {
        public int StuId { get; set; }
        public string StuName { get; set; }
        public double StuPhone { get; set; }

    }
    class GenericsClass
    {
        static void Main()
        {
            List<Sample1> objs = new List<Sample1>(); // creating a list object
            // two new sample object with object type declarattion were added to list Object
            Sample1 obj1 = new Sample1 { StuId = 1010, StuName ="laxman", StuPhone=9907053931};
            Sample1 obj2 = new Sample1 { StuId = 1020, StuName = "Amreen", StuPhone = 9703681540 };
            objs.Add(obj1);
            objs.Add(obj2);
            //reading values from the object
            foreach(Sample1 obj in objs)
            {
                Console.WriteLine(obj.StuId + "," + obj.StuName + "," + obj.StuPhone);
            }
            
            Console.ReadLine();
        }
    }
}

