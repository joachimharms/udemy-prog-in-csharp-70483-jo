using System;

namespace S04_L42_Struct_Example
{
    public struct Mark
    {
        // Du kannst keine Felder und Properties direkt in einem struct initialisieren:
        //public int x = 7;
        //public int y = 9;

        public int x;

        public int y;

        // Structs erlauben nur parameterisierte Konstruktoren:
        public Mark(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void DoThis()
        {
            Console.WriteLine(x + y);
        }
    }
}