using System;

namespace aufgabe1
{
    class Program
    {
	static void Main(string[] args)
	{
	    /* Tatsächliche Gesprächsminuten im Monat */
	    int Minuten = 0;

	    /* Minuten vom Benutzer einlesen */
	    Console.Write("Minuten: ");
	    Minuten = Convert.ToInt32(Console.ReadLine());

	    /* Rechnungssumme für diesen Monat */
	    double Gebuehr = 0.0;

	    /* Name des Datentarif (s/m/l) */
	    char Tarif;

	    /* Tarif vom Benutzer einlesen */
	    Console.Write("Tarif [s,m,l]: ");
	    Tarif = Convert.ToChar(Console.ReadLine());

	    /* Grundgebühr ist immer 3.99€ */
	    Gebuehr += 3.99;

	    /* Wenn der Nutzer mehr als 100 Gesprächsminuten hat, muss
	     * er je weitere Minute 9.9ct bezahlen. Hier errechnen wir
	     * uns erst die Differenz.*/
	    int MinutenZuViel = Minuten - 100;
	    /* Und wenn die Differenz negativ ist, dann hat der
	     * Benutzer seine 100 freien Minuten nicht
	     * ausgeschöpft. Damit die Rechnung aufgeht setzen wir
	     * hier die Minuten, die er zu viel hat auf 0. */
	    if (MinutenZuViel < 0) {
		MinutenZuViel = 0;
	    }

	    /* Zusätzliche Kosten errechnen und auf die Rechnungssumme
	     * addieren */
	    Gebuehr += (double)MinutenZuViel * 0.099;

	    /* Datentarife:
	     *
	     *   s =>  5.0€
	     *   m =>  7.0€
	     *   l => 10.0€
	     *
	     * Je nachdem welchen Tarif der Nutzer eingegeben hat,
	     * addieren wir einfach nur den Betrag auf unsere
	     * Rechnungssumme.
	     */
	    switch (Tarif) {
	    case 's':
		Gebuehr += 5.0;
		break;
	    case 'm':
		Gebuehr += 7.0;
		break;
	    case 'l':
		Gebuehr += 10.0;
		break;
	    default:
		Console.WriteLine("Fehler: Ungültiger Tarif '{0}'", Tarif);
		break;
	    }

	    /* Zu guter Letzt die Summe ausgeben */
	    Console.WriteLine("Gebühr: {0}€", Gebuehr);
	}
    }
}
