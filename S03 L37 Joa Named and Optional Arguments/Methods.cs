using System;

namespace S03_L37_Joa_Named_and_Optional_Arguments
{
    public class Methods
    {
        public void NewInfo(string fname, int age)
        {
            Console.WriteLine("Name: " + fname + " Alter: " + age);
        }

        //public void NewInfo(string fname, int age = 12, string gender = "weiblich")
        //{
        //    Console.WriteLine("Name: " + fname + " Alter: " + age + " Geschlecht: " + gender);
        //}

        public void NewInfo(string fname, int age = 10, string gender = "weiblich", double height = 1.40)
        {
            Console.WriteLine("Name: " + fname + " Alter: " + age + " Geschlecht: " + gender + " Körpergröße: " + height);
        }

    }
}