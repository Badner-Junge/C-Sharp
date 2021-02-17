using System;

namespace Klassen
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Person janek = new Person();
            Person hendrik = new Person();

            janek.Name = "Janek";
            janek.SageHallo();

            hendrik.Name = "Hendrik";
            hendrik.SageHallo();
        }
    }

    class Person
    {
        //Eigenschafteb
        public string Name { get; set; }
        public int Alter { get; set; }

        //Methoden
        public void SageHallo()
        {
            Console.WriteLine(Name + " sagt: Hallo");
        }
    }
}
