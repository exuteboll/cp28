using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Person
    {
        public string name { get; set; }
        public string family { get; set; }  
        public int age { get; set; }

        public Person(string name, string family, int age)
        {
            this.name = name;
            this.family = family;    
            this.age = age;
        }
        public virtual void Print()
        {
            Console.WriteLine($"Имя: {name}\t фамилия: {family}\t возраст: {age}");
        }
    }
}
