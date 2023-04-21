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

        public void Eat(string food, string drink) 
        {
            Eat(food);
            Console.WriteLine($"Slurping {drink}!");
        }
    }

    public class Employee : Person
    {
        public double Salary { get; set; }

        
        public Employee(double salary, string name, int age) : base(name, age)
        {
            Salary = salary;
        }

        public virtual void DoWork(int numberOfHours)
        {
            Console.WriteLine($"Off to do some work! I'll be busy for {numberOfHours} hours.");
        }
    }

    public class Manager : Employee
    {
        public Manager(double salary, string name, int age) : base(salary, name, age)
        {
        }

        public override void DoWork(int numberOfHours)
        {
            Eat("sushi");
            //base.DoWork(numberOfHours);//when calling the base, you are EXTENDING the method
            //if you do NOT call the base, you are FULLY OVERRIDING the method
            Console.WriteLine($"Off to meetings for {numberOfHours-2}. Then I'll work for 2 hours.");
        }
    }
}
