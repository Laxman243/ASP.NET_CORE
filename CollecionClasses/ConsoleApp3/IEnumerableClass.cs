using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Employee
    {
        public int EId { get; set; }
        public string EName { get; set; }
        public string EJob { get; set; }
        public double EPhone { get; set; }

     }
    // now i want to add elements in organization class and iterate the list
    class Organization : IEnumerable
    {
        List<Employee> ls3 = new List<Employee>();
        public void Add(Employee Emps)
        {
            ls3.Add(Emps);
        }
        public IEnumerator GetEnumerator()
        {
            return ls3.GetEnumerator();
        }
    }
    // MY OWN ENUMERATED CLASS

    /*class OrganizationEnumerator : IEnumerator
    {
        OrganizationEnumerator OrgColl;
        int CurrentIndex;
        Employee CurrentEmployee;

        public OrganizationEnumerator(Organization org)
        {
           // OrgColl = org;
            CurrentIndex = -1;
        }
        public object Current => throw new NotImplementedException();

        public bool MoveNext()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }*/
    class IEnumerableClass
    {
        static void Main()
        {
            Employee Emp = new Employee() { EId = 9923, EName = "Sehwag", EJob = "Cricketer", EPhone = 9703681540 };
            Employee Emp1 = new Employee() { EId = 231, EName = "Sachine", EJob = "SoftwareEngineer", EPhone = 987654334 };
            Employee Emp2 = new Employee() { EId = 432, EName = "Laxman", EJob = "Actor", EPhone = 09876543 };
            Employee Emp3 = new Employee() { EId = 444, EName = "Anil", EJob = "Bussinesman", EPhone = 989876767 };

            Organization org = new Organization();
            org.Add(Emp);org.Add(Emp1); org.Add(Emp2); org.Add(Emp3);
            List<Employee> ls = new List<Employee>() { Emp, Emp1, Emp2, Emp3 };
            foreach (Employee i in org)
            {
                Console.WriteLine(i.EId + " " + i.EName + " " + i.EJob + " " + i.EPhone);
            }
            Console.ReadKey();
        }

    }
}
