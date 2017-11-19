using System;

namespace S04_L40_Static_Example
{
    public class Car
    {
        public static void Accelerate()
        {
            Console.WriteLine("Car is accelerating...");
        }

        public void SlowDown()
        {
            Console.WriteLine("Car is slowing down...");
        }
    }
}