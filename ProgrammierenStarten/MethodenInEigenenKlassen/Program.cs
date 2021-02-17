using System;

namespace MethodenInEigenenKlassen
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Mensch peter = new Mensch();
            Mensch manfred = new Mensch();
            manfred.Name = "Manni";
            manfred.Begrüßung();
            peter.Name = "Peter";
            peter.Begrüßung();
        }
    }

    class Mensch
    {
        //Eigenschaften
        public string Name { get; set; }

        //Methode
        public void Begrüßung()
        {
            Console.WriteLine(Name + " sagt hallo!");
        }
    }
}
