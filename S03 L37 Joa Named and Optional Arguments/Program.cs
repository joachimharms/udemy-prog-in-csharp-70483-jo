using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace S03_L37_Joa_Named_and_Optional_Arguments
{
    class Program
    {
        static void Main(string[] args)
        {
            var myMeth01 = new Methods();
            var myMeth02 = new Methods();

            myMeth01.NewInfo("Pfanni", 22);


            // Named parameters example:
            myMeth01.NewInfo(age: 12, fname:"Holly");
            myMeth01.NewInfo(fname: "Justin", age: 32);

            // Optional Parameters example:
            myMeth02.NewInfo("Tanja");

            // Named and optional parameters example combined:
            myMeth02.NewInfo(age: 9, fname: "Sonja", gender: "weiblich");
        }
    }
}
