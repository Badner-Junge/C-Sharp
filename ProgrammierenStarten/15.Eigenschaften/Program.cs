using System;

namespace Eigenschaften
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Auto car = new Auto();

            car.Farbe = "Grün";
            Console.WriteLine(car.Farbe);
        }
    }

    class Auto
    {
        //Variablen
        private bool motorAn;
        private bool scheibenwischerAn;

        //Eigenschagten
        public string Farbe { get; set; }
        public int PS { get; set; }
        public int AnzahlTüren { get; set; }
    }
}
