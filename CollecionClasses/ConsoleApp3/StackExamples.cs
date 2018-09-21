using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class StackExamples
    {
        static void Main()
        {
            Stack<string> st = new Stack<string>();
            // populating stack 
            st.Push("laxman");
            st.Push("laxman");
            st.Push(null);
            st.Push("working in bizruntime");
            st.Push("bangalore");

            //reading items from the stack
            foreach(string s in st)
            {
                Console.WriteLine(s);
            }
            st.Pop();
            foreach (string s in st)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("==================");

            Stack<int> number = new Stack<int>();
            //populating the stack
             foreach(int num in new int[] {10,20,30,40,50})
            {
                number.Push(num);
                Console.WriteLine("{0} elements is pushed ", num);
            }
            Console.WriteLine("==================");
            Console.WriteLine("elememts constaints");
            foreach(int i in number)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("==================");
            //Console.WriteLine("poping the elements from the stack");
            while (number.Count > 0)
            {
                int num = number.Pop();
                Console.WriteLine("{0} element poped",num);
            }
            Console.ReadKey();
        }
    }
}
