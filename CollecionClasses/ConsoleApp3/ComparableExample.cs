using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Students : IComparable <Students>
    {
        public int StuId { get; set; }
        public string StuName { get; set; }
        public double StuMarks { get; set; }

        public int CompareTo(Students other)
        {
            if (this.StuId > other.StuId)
                return 1;
            else if (this.StuId < other.StuId)
                return -1;
            else
                return 0;
        }
    }
    // implementing Comparer interface
    class CompareStudents : IComparer<Students>
    {
        public int Compare(Students x, Students y)
        {
            if (x.StuMarks > y.StuMarks)
                return 1;
            else if (x.StuMarks < y.StuMarks)
                return -1;
            else
                return 0;
        }
    }

    class ComparableExample
        {
            static void Main()
            {
                Students s1 = new Students() { StuId = 1, StuName = "laxman", StuMarks = 100.1 };
                Students s2 = new Students() { StuId = 3, StuName = "shukla", StuMarks = 90.2 };
                Students s3 = new Students() { StuId = 5, StuName = "anil", StuMarks = 1000.3 };
                Students s4 = new Students() { StuId = 2, StuName = "ved", StuMarks = 99.3 };

                List<Students> ls = new List<Students>() { s1, s2, s3, s4 };
            CompareStudents obj = new CompareStudents();
            ls.Sort(obj);
            List<int> ls1 = new List<int>() { 10, 40, 5, 200, 3 };
                ls1.Sort();//by applying sort method over integer list the items are get sorted 

                //but while applying sort method on students type list, we getting an exception 
                // so sort method will not work n complex type list , we need to go for Icomparable and Icomparer
               // ls.Sort();
           // ls.Reverse();

                // printing the first List of student type
                foreach (Students s in ls)
                {
                    Console.WriteLine(s.StuId + "  " + s.StuName + "  " + s.StuMarks);
                }
                Console.WriteLine("\n From second list of integer type");
                //printing the second list of Interger type
                foreach (int i in ls1)
                {
                    Console.WriteLine(i);
                }
                Console.ReadKey();
            }
        }
    }

