using System;

namespace IfStatement
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int alter = 10;

            if (alter >= 18)
            {
                Console.WriteLine("Du bist alt genug!");
            }
            else
            {
                Console.WriteLine("Du bist zu jung!");
            }

            Console.ReadKey();
        }
    }
}
