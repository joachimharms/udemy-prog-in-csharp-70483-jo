using System;
using System.Dynamic;

namespace S04_L33_Using_Properties_and_Fields
{
    public class Person
    {
        //// simple field without properties - too easy to access it from the outside and fatfinger it (ie. set age to 120 instead of 12)
        //public int Age;

        //// instead we try a private field:
        private int age; // private members are allways lowercase!
        // Then we create some accessors to handle that field:
        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                // We check that value that is passed to set age is a value we like:
                if ((value > 0) && (value < 65))
                {
                    this.age = value;
                }
                else
                {
                    throw new Exception("Age cannot be negative and not greater than 65.");
                }
            }
        }

        // automatic property with a hidden field:
        public int Weight { get; set; }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        



    }
}