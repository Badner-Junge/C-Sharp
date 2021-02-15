using System;

namespace If
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int alter = 19;

            if (alter >= 18)
            {
                Console.WriteLine("Du bist alt genug!");
            }
            else
            {
                Console.WriteLine("Du bist nicht alt genug!");
            }

            Console.ReadKey();
        }
    }
}
