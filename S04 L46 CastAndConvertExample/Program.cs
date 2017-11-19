using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S04_L46_CastAndConvertExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Passt gerade noch in einen integer:
            int num = 2147483647;

            // Implicit Conversion:
            long bigNum = num;

            int i = 5;
            double d = 10.5;
            // Kann nicht implicit converted werden, daher explicit casting inklusive Datenverlust:
            i = (int)d;
            Console.WriteLine("The double variable d converted to int: " + i);

            // explizit casting
            int x = 7;
            double y = 12.6;
            x = (int)y;

            Console.WriteLine("Double casted to int: " + x);


            // explizit Converting mittels Convert Klasse
            int xx = 7;
            double yy = 12.6;
            xx = Convert.ToInt32(yy);

            Console.WriteLine("Double casted to int: " + xx);

            // Convert Klasse kann sogar strings to int konvertieren:
            string str = "123";
            int r;

            r = Convert.ToInt32(str);

            Console.WriteLine("Convert string to int: " + r);
        }
    }
}
