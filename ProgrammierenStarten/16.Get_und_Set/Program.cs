using System;

namespace Get_und_Set
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Person peter = new Person();
            peter.Alter = 10;
            Console.WriteLine(peter.Alter);
        }
    }

    class Person
    {
        //Private Variablen
        private int alter;

        //Eigenschaften
        public string Name { get; set; }

        public int Alter
        {
            get
            {
                Console.WriteLine("Alter wurde gelesen");
                return alter;
            }
            set
            {
                Console.WriteLine("Alter wurde überschrieben");
                alter = value;
            }
        }
    }
}
