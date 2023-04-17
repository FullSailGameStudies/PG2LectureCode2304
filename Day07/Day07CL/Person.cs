using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07CL
{
    public class Person
    {
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
        }

        public Person(int age, string name)//use the params to assign values to fields/properties
        {
            Age = age;
            Name = name;
        }
        #endregion
    }
}
