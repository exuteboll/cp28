using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("asd","Asdf",54);
            person.Print();

            Employee employee = new Employee("asd", "asdf", 35, "asd", "sdf");
            employee.Print();

            Person personRef = employee;
            personRef.Print();

            Console.ReadKey();
        }
        
    }
}
