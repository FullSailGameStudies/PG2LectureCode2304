using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day08CL
{
    public class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void Eat(string food)
        {
            Console.WriteLine($"Time to eat some {food}! nom nom.");
        }
    }

    public class Employee : Person
    {
        public double Salary { get; set; }

        
        public Employee(double salary, string name, int age) : base(name, age)
        {
            Salary = salary;
        }
    }
}
