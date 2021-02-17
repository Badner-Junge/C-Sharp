using System;

namespace Methoden
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Bergrüßung("Peter");
            Bergrüßung("Janek");
        }

        static void Bergrüßung(string name)
        {
            Console.WriteLine("Hallo " + name);
        }
    }
}
