using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07CL
{
    public class Person
    {
        //shared across ALL instances of Person
        //only ONE NumberOfPersons variable.
        public static int NumberOfPersons = 0;

        #region Fields
        private int _age = 0;
        #endregion

        #region Properties
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value >= 0 && value < 120)
                    _age = value;
            }
        }

        public string Name { get; set; } = string.Empty;

        #endregion

        #region Constructors
        //If no constructor, the compiler will give us a default

        //a default constructor (ctor with no parameters)
        public Person()
        {
            _age = 0;
            Name = string.Empty;
            NumberOfPersons++;
        }

        public Person(int age, string name)//use the params to assign values to fields/properties
        {
            Age = age;
            Name = name;
            NumberOfPersons++;
        }
        #endregion

        #region Methods
        public void ItsMyBirthday()//hidden param called Person 'this'. points to the instance that was used when calling the method.
        {
            this.Age++;//will call the set on Age
            Console.WriteLine($"Happy birthday to me ({this.Name})! I'm now {Age} years old. Time to eat cake!!");//calls get on Age
        }

        //static methods can only access static members
        public static void PersonReport()//there is no 'this' for static methods
        {
            //Console.WriteLine($"Happy birthday to me ({this.Name})! I'm now {Age} years old. Time to eat cake!!");//calls get on Age

            Console.WriteLine($"We've made {NumberOfPersons} persons.");
        }
        #endregion
    }
}
