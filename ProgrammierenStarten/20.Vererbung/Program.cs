using System;

namespace Vererbung
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Hund dog = new Hund();

            dog.Name = "Coco";
            dog.Bellen();
            dog.Geschlecht = "Rüde";
            dog.Bewegen();
        }
    }

    class Tier
    {
        //Eigenschaften
        public string Geschlecht { get; set; }

        //Methoden
        public void Bewegen()
        {
            Console.WriteLine("Bewegen...");
        }
    }

    class Hund : Tier
    {
        //Eigenschaften
        public string Name { get; set; }

        //Methoden
        public void Schnüffeln()
        {
            Console.WriteLine(Name + " schnüffelt.");
        }
        public void Bellen()
        {
            Console.WriteLine(Name + " bellt.");
        }
    }
}
