using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S03_L28_String_Builder_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            // In Zeile 15 wird ein ganz neues Stringobjekt kreiert, auch wenn es für uns so ausschaut, dass einfach Text an den ursprünglichen string angehängt wird.
            string s1 = "This is an example of ";
            s1 = s1 + "string concatenation.";
            Console.WriteLine(s1);

            // String concatenation mittels eines StringBuilder Objekts. Hier wird tatsächlich nur ein string angehängt an den bestehenden und kein ganz neues string Objekt kreiert.
            // Verwendung des StringBuilder Objekts ist daher viel ressourcenschonender.
            var sb2 = new StringBuilder("This is an example of");
            sb2.Append(" string concatenation.");
            Console.WriteLine(sb2);
        }
    }
}
