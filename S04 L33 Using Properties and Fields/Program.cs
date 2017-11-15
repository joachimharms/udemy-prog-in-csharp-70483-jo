using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S04_L33_Using_Properties_and_Fields
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Person();
            p.Age = 92;
            p.Weight = 35;
            p.Name = "Piona";
            Console.WriteLine("The person is " + p.Age + " years old.");
        }
    }
}
