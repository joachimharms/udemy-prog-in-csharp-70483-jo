using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace S04_L43_Generics_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            // Showing Problems with non generics types:
            System.Collections.ArrayList list1 = new System.Collections.ArrayList();
            list1.Add(3);
            list1.Add(5);
            list1.Add(12);
            // Der Compiler erlaubt uns auch einen String hinzuzufügen:
            //list1.Add("Hello World");

            // Das Problem ist der String wird implicit geboxed, aber kann nicht
            // implizit unboxed werden bei der ausgabe. Das Problem ist, dass es
            // uns erlaubt wurde den falschen Datentypen überhaupt zur Liste hinzuzufügen.
            // Schmeißt eine InvalidCastException:

            Console.WriteLine("Non-generic list results...");
            foreach (int x in list1)
            {
                Console.WriteLine(x);
            }

            // Bessere Implementation mit generics:
            var list2 = new List<int>();
            list2.Add(34);
            list2.Add(7);
            list2.Add(21);

            // Wir versuchen wieder einen string zur Liste hinzuzufügen:
            //list2.Add("Hello World");

            Console.WriteLine("\nGeneric list results...");
            foreach (int x in list2)
            {
                Console.WriteLine(x); 
            }
        }
    }
}
