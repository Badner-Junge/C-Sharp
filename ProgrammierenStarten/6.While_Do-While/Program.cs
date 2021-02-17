using System;

namespace While_DoWhile
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //While-Schleifen
            int zahl = 1;

            while(zahl <= 5)
            {
                Console.WriteLine(zahl);
                zahl += 1;
            }

            //Do-While-Schleife
            int zahl2 = 7;

            do
            {
                Console.WriteLine(zahl2);
                zahl2 += 1;
            }
            while (zahl2 <= 5);

            Console.ReadKey();
        }
    }
}
