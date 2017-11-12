using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S03_L30_StringWriter_and_StringReader
{
    public class StringReadWrite
    {
        StringBuilder sb = new StringBuilder();

        #region "Write Data using StringWriter"

        public StringReadWrite()
        {
            WriteData();
            ReadData();
        }

        private void WriteData()
        {
            StringWriter sw = new StringWriter(sb);

            Console.WriteLine("Please enter your first and last name: ");
            string name = Console.ReadLine();

            // StringWriter Objekt schreibt es an die Konsole und in das String-
            // Builder Objekt!
            sw.WriteLine("Name: " + name);
            sw.Flush();
            sw.Close();
        }

        #endregion

        #region "Read data with StringReader"

        private void ReadData()
        {
            StringReader sr = new StringReader(sb.ToString());
            Console.WriteLine("Reading Data...");

            while (sr.Peek() > -1)
            {
                Console.WriteLine(sr.ReadLine());
            }

            Console.WriteLine();
            Console.WriteLine("Thank you.");
        }

        #endregion
    }
}