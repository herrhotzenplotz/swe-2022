using System;

namespace Aufgabe2
{
    class Program
    {
        static void Main(string[] args)
        {
            string Bezeichnung = "Leere Bezeichnung";
            int    RegNummer   = 0;
            char   Kategorie   = 'z';
            double Leuchtkraft = Double.NaN;

            // Den Benutzer nach Eingabe fragen
            Console.Write("Bezeichnung: ");
            Bezeichnung = Console.ReadLine();

            // Nach RegNummer fragen
            Console.Write("Registriernummer: ");
            RegNummer = Convert.ToInt32(Console.ReadLine());

            // Nach Kategorie fragen
            Console.Write("Kategorie: ");
            Kategorie = Convert.ToChar(Console.ReadLine());

            // Nach Leuchtkraft fragen
            Console.Write("Leuchtkraft: ");
            Leuchtkraft = Convert.ToDouble(Console.ReadLine());

            Console.Write("Bezeichnung      : {0}\nRegistriernummer : {1}\nKategorie        : {2}\nLeuchtkraft      : {3}\n",
                          Bezeichnung, RegNummer, Kategorie, Leuchtkraft);
        }
    }
}
