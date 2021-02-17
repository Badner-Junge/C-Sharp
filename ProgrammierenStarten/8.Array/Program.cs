using System;

namespace Array
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //1D-Arrays
            int[] integerListe = new int[4];

            integerListe[0] = 10;
            integerListe[1] = 20;
            integerListe[2] = 30;
            integerListe[3] = 40;

            Console.WriteLine(integerListe[2]);
            Console.ReadKey();
        }
    }
}
