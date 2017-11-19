using System;
using System.ComponentModel;

namespace S04_L39_Using_Constructors
{
    public class AddConstructor
    {
        // explicit default constructor:
        public AddConstructor()
        {
            Console.WriteLine("The default constructor has been called...");
            // Calling a method from within the constructor
            this.DoThat();
        }

        //public AddConstructor()
        //{

        //}

        public void DoThat()
        {
            Console.WriteLine("DoThat() has executed...\n");
        }
    }
}