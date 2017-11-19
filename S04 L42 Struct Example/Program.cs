using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S04_L42_Struct_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialisierung eines structs mit dem new keyword und mithilfe eines parameterisierten Konstruktors:
            var m = new Mark(7, 9);
            m.DoThis();

            // Initialisierung ohne new keyword:
            Mark m2;
            m2.y = 7;
            m2.x = 9;
            m2.DoThis();
        }
    }
}
