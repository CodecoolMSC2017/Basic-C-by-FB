using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("Józsi", 22, Genders.Female);
            Console.WriteLine(p.ToString());
            Employee em = new Employee("Jóska", 23, Genders.Male, 2000, "Hegesztő", new Room(20));
            Console.WriteLine(em.ToString());
            Console.ReadLine();
        }
    }
}
