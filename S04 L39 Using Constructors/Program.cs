using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S04_L39_Using_Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            // Calling the default constructor
            var dc = new DefConstructor();
            dc.DoThis();

           var ac = new AddConstructor();
        }
    }
}
