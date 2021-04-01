using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Truppenrechner_Konsole
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Variablen
            int TotalInfanterie = 0;
            int TotalFahrer = 0;
            int TotalJäger = 0;
            int Truppen = 0;
            int TruppenstärkeEinzel = 0;
            int Marschstärke = 0;
            int Marschkapazität = 0;
            int Marschanzahl = 3;
            int Marschnummer = 1;
            int eigenschaftenCheck = 1;
            int truppenanzahlCheck = 3;
            int marscheigenschaftenCheck = 3;

            //Truppenliste + Truppenstärke
            string[,] Truppenstärke = new string[16, 2]
            {
                { "T1", "3" },
                { "T2", "4" },
                { "T3", "6" },
                { "T4", "9" },
                { "T5", "13" },
                { "T6", "20" },
                { "T7", "28" },
                { "T8", "38" },
                { "T9", "50" },
                { "T10", "66" },
                { "1*", "71" },
                { "2*", "76" },
                { "3*", "83" },
                { "4*", "88" },
                { "5*", "94" },
                { "T11", "114" },
            };

            //Eingabewere Formation
            string[] Formation = new string[3];
            int[] Formation_int = new int[3];

            //Truppeneigenschaften
            Farbig.GrünZeile("Truppenrechner");
            Console.WriteLine();

            while (eigenschaftenCheck == 1)
            {
                Farbig.RotZeile("Beste Truppe auswählen");
                Truppenauswahl();
                Console.WriteLine();
                Farbig.Grün("Auswahl: ");
                Truppen = Convert.ToInt32(Console.ReadLine()) - 1;
                if (Truppen >= 16 || Truppen < 0)
                {
                    Farbig.RotZeile("Ungültige Auswahl");
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    TruppenstärkeEinzel = Convert.ToInt16(Truppenstärke[Truppen, 1]);
                    eigenschaftenCheck = 0;
                    Console.Clear();
                }
            }

            //Truppenanzahl
            Farbig.GrünZeile("Truppenrechner");
            Console.WriteLine();

            Farbig.Rot("Ausgebildete Einheiten (");
            Farbig.Gelb(Truppenstärke[Truppen, 0]);
            Farbig.RotZeile(")");
            while (truppenanzahlCheck != 0)
            {
                try
                {
                    switch(truppenanzahlCheck)
                    {
                        case 3:
                            Farbig.Gelb("Infanterie: ");
                            TotalInfanterie = Convert.ToInt32(Console.ReadLine());
                            truppenanzahlCheck -= 1;
                            break;

                        case 2:
                            aktuelleZeile();
                            Farbig.Gelb("Fahrer: ");
                            TotalFahrer = Convert.ToInt32(Console.ReadLine());
                            truppenanzahlCheck -= 1;
                            break;

                        case 1:
                            aktuelleZeile();
                            Farbig.Gelb("Jäger: ");
                            TotalJäger = Convert.ToInt32(Console.ReadLine());
                            truppenanzahlCheck -= 1;
                            Console.WriteLine("                           ");
                            break;
                    }
                }
                catch
                {
                    Farbig.RotZeile("Ungültige Auswahl");
                    zweiletztenZeilen();
                }

            }

            //Marscheigenschaften
            Farbig.RotZeile("Marscheigenschaften:");
            while (marscheigenschaftenCheck != 0)
            {
                try
                {
                    switch (marscheigenschaftenCheck)
                    {
                        case 3:
                            Farbig.Gelb("Marschstärke: ");
                            Marschstärke = Convert.ToInt32(Console.ReadLine());
                            marscheigenschaftenCheck -= 1;
                            break;

                        case 2:
                            aktuelleZeile();
                            Farbig.Gelb("Marschkapazität: ");
                            Marschkapazität = Convert.ToInt32(Console.ReadLine());
                            marscheigenschaftenCheck -= 1;
                            break;

                        case 1:
                            aktuelleZeile();
                            Farbig.Gelb("Formation: ");
                            string Prozent = Console.ReadLine();
                            Formation = Prozent.Split(' ');
                            Formation_int = Array.ConvertAll<string, int>(Formation, int.Parse);
                            möglicherMarsch(Formation_int[0], Formation_int[1], Formation_int[2],
                                TotalInfanterie, TotalFahrer, TotalJäger,
                                TruppenstärkeEinzel, Marschstärke);
                            marscheigenschaftenCheck -= 1;
                            aktuelleZeile();
                            Console.WriteLine();
                            break;
                    }
                }
                catch
                {
                    Farbig.RotZeile("Ungültige Auswahl");
                    zweiletztenZeilen();
                }
            }

            //Marschanzahl
            Farbig.Rot("Marschanzahl (");
            Farbig.Gelb("Möglich ");
            möglicherMarsch(Formation_int[0], Formation_int[1], Formation_int[2],
                TotalInfanterie, TotalFahrer, TotalJäger,
                TruppenstärkeEinzel, Marschstärke);
            Farbig.Gelb(" volle Märsche");
            Farbig.RotZeile(")");
            Farbig.Gelb("Anzahl: ");
            Marschanzahl = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            //Märsche erzeugen
            for (int i = Marschanzahl; i > 0; i--)
            {
                Farbig.RotZeile(Marschnummer + ". Marsch");

                Einzelmarsch(Formation_int[0], Formation_int[1], Formation_int[2],
                    TruppenstärkeEinzel, Marschstärke, Marschnummer);

                Marschnummer += 1;

            }
            Console.ReadKey();
        }

        //Darstellung der Truppenauswahl
        static void Truppenauswahl()
        {
            Farbig.Gelb("1: ");
            Console.Write("T1     ");
            Farbig.Gelb("11: ");
            Console.WriteLine("1*");

            Farbig.Gelb("2: ");
            Console.Write("T2     ");
            Farbig.Gelb("12: ");
            Console.WriteLine("2*");

            Farbig.Gelb("3: ");
            Console.Write("T3     ");
            Farbig.Gelb("13: ");
            Console.WriteLine("3*");

            Farbig.Gelb("4: ");
            Console.Write("T4     ");
            Farbig.Gelb("14: ");
            Console.WriteLine("4*");

            Farbig.Gelb("5: ");
            Console.Write("T5     ");
            Farbig.Gelb("15: ");
            Console.WriteLine("5*");

            Farbig.Gelb("6: ");
            Console.WriteLine("T6");
            Farbig.Gelb("7: ");
            Console.Write("T7     ");

            Farbig.Gelb("16: ");
            Console.WriteLine("T11");
            Farbig.Gelb("8: ");
            Console.WriteLine("T8");

            Farbig.Gelb("9: ");
            Console.WriteLine("T9");
            Farbig.Gelb("10: ");
            Console.WriteLine("T10");
        }

        //Berechnung der maximal vollen Märsche
        static void möglicherMarsch(float PI, float PF, float PJ, float I, float F, float J, float Tr, float Ms)
        {
            float ProzentInfanterie = PI;
            float ProzentFahrer = PF;
            float ProzentJäger = PJ;
            float Infanterie = I;
            float Fahrer = F;
            float Jäger = J;
            float Truppenkampfkraft = Tr;
            float Marschstärke = Ms;

            if (ProzentInfanterie >= ProzentFahrer)
            {
                if (ProzentInfanterie >= ProzentJäger)
                {
                    Console.Write((int)Math.Floor(Infanterie / ((Marschstärke * (ProzentInfanterie / 100)) / Truppenkampfkraft)));
                }
                else
                {
                    Console.Write((int)Math.Floor(Jäger / ((Marschstärke * (ProzentJäger / 100)) / Truppenkampfkraft)));
                }
            }
            else if (ProzentFahrer > ProzentJäger)
            {
                Console.Write((int)Math.Floor(Fahrer / ((Marschstärke * (ProzentFahrer / 100)) / Truppenkampfkraft)));
            }
            else
            {
                Console.Write((int)Math.Floor(Jäger / ((Marschstärke * (ProzentJäger / 100)) / Truppenkampfkraft)));
            }
        }

        //Berechnung einzelner Marsch
        static void Einzelmarsch(float PI, float PF, float PJ, float Tr, float Ms, int Mn)
        {
            float ProzentInfanterie = PI;
            float ProzentFahrer = PF;
            float ProzentJäger = PJ;
            float Truppenkampfkraft = Tr;
            float Marschstärke = Ms;
            int Marschnummer = Mn;

            //Erster Marsch
            if (Marschnummer == 1)
            {
                Farbig.Gelb("Infanterie: ");
                Console.WriteLine(Convert.ToInt32((Marschstärke * (ProzentInfanterie / 100)) / Truppenkampfkraft));
                Farbig.Gelb("Fahrer: ");
                Console.WriteLine(Convert.ToInt32((Marschstärke * (ProzentFahrer / 100)) / Truppenkampfkraft));
                Farbig.Gelb("Jäger: ");
                Console.WriteLine(Convert.ToInt32((Marschstärke * (ProzentJäger / 100)) / Truppenkampfkraft));
                Console.WriteLine();
            }
            //Weitere Märsche
            else
            {
                //Marschstärke aktualisieren
                Farbig.Gelb("Marschstärke: ");
                Marschstärke = Convert.ToInt32(Console.ReadLine());

                //letzte Zeile löschen
                letzteZeile();

                //Truppenanzahl mit neuer Marschstärke
                Farbig.Gelb("Infanterie: ");
                Console.WriteLine(Convert.ToInt32((Marschstärke * (ProzentInfanterie / 100)) / Truppenkampfkraft));
                Farbig.Gelb("Fahrer: ");
                Console.WriteLine(Convert.ToInt32((Marschstärke * (ProzentFahrer / 100)) / Truppenkampfkraft));
                Farbig.Gelb("Jäger: ");
                Console.WriteLine(Convert.ToInt32((Marschstärke * (ProzentJäger / 100)) / Truppenkampfkraft));
                Console.WriteLine();
            }
        }

        //Aktuelle Zeile löschen
        static void aktuelleZeile()
        {
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.WriteLine("                            ");
            Console.SetCursorPosition(0, Console.CursorTop - 1);
        }

        //Letzte Zeile löschen
        static void letzteZeile()
        {
            Console.SetCursorPosition(0, Console.CursorTop - 1);
            Console.WriteLine("                            ");
            Console.SetCursorPosition(0, Console.CursorTop - 1);
        }

        //Letzten 2 Zeilen löschen
        static void zweiletztenZeilen()
        {
            Console.SetCursorPosition(0, Console.CursorTop - 2);
            Console.WriteLine("                            ");
            Console.SetCursorPosition(0, Console.CursorTop - 1);
        }
    }

    //Klasse farbige Schrift
    class Farbig
    {
        //Zeile einfärben
        public static void GrünZeile(string text)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(text);
            Console.ResetColor();
        }
        public static void RotZeile(string text)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(text);
            Console.ResetColor();
        }
        public static void BlauZeile(string text)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(text);
            Console.ResetColor();
        }
        public static void GelbZeile(string text)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(text);
            Console.ResetColor();
        }

        //Text einfärben
        public static void Grün(string text)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(text);
            Console.ResetColor();
        }
        public static void Rot(string text)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(text);
            Console.ResetColor();
        }
        public static void Blau(string text)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(text);
            Console.ResetColor();
        }
        public static void Gelb(string text)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(text);
            Console.ResetColor();
        }
    }

}
