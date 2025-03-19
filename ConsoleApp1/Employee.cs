using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Employee : Person
    {
        public string pred { get; set; }
        public string dol {  get; set; }

        public Employee(string name, string family, int age, string pred, string dol) 
            : base(name, family, age)
        {
           this.pred = pred;
           this.dol = dol;
        }
        public override void Print()
        {
            Console.WriteLine($" name:{name}\t family:{family}\t age: {age}\t company:{pred}\t doljnost:{dol}");
        }

    }
}
