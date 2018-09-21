using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class DictionaryExample
    {
        static void Main()
        {
            // create a dictionary 
            Dictionary<string, int> Records = new Dictionary<string, int>();
            //populate the dictionary
            Records.Add("laxman", 1010);
            Records.Add("laxan", 1010);
            Records.Add("Abc", 2020);
            Records.Add("shukla", 3030);

            // read the itmes from the dictionary in key/value pair using iterator
            foreach (KeyValuePair<string, int> elements in Records)
            {
                String name = elements.Key;
                int age = elements.Value;
                Console.WriteLine("{0} : is key and {1} : is value ", name, age);
            }

            Console.ReadKey();
        }
    }
}
