using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S04_L40_Static_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            // Zugriff auf die statische Methode Round() der statischen Klasse Math:
            double r = Math.Round(7.3);
            Console.WriteLine(r);

            // Aufruf der statischen Methode Accelerate() der nicht statischen Klasse car:
            Car.Accelerate();

            // Instanziierung eines Car Objekts und Aufruf der nicht statischen Methode SlowDown():
            var c = new Car();
            c.SlowDown();




        }
    }
}
