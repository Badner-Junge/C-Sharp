using System;

namespace StatischeKlassen
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int ergebnis = Mathematik.Multiplikation(10, 3);
            Console.WriteLine(ergebnis);
        }
    }

    static class Mathematik
    {
        public static int Addition(int wert1, int wert2)
        {
            return wert1 + wert2;
        }
        public static int Subtraktion(int wert1, int wert2)
        {
            return wert1 - wert2;
        }
        public static int Division(int wert1, int wert2)
        {
            return wert1 / wert2;
        }
        public static int Multiplikation(int wert1, int wert2)
        {
            return wert1 * wert2;
        }
        public static int Modulo(int wert1, int wert2)
        {
            return wert1 % wert2;
        }
    }
}
