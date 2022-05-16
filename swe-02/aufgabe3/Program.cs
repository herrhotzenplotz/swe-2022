using System;

namespace aufgabe3
{
    class Program
    {
	static void Main(string[] args)
	{
	    double a, e, s;

	    /* Anfang des Intervalls einlesen */
	    Console.Write("Anfang: ");
	    a = Convert.ToDouble(Console.ReadLine());

	    /* Dito, nur Ende */
	    Console.Write("Ende: ");
	    e = Convert.ToDouble(Console.ReadLine());

	    /* Dito, nur Schrittweite */
	    Console.Write("Schrittweite: ");
	    s = Convert.ToDouble(Console.ReadLine());

	    /* Über das gesamte Intervall von a bis e mit Schrittweite
	     * s iterieren: */
	    for (double x = a; x < e; x += s)
	    {
		/* Polstellen (Division durch Null abfangen)
		 *
		 * Wir können nicht die double Werte direkt
		 * vergleichen! Siehe ../README.org. */
		if (Math.Abs(x + 2.0) < 5e-5 || Math.Abs(x - 1.0) < 5e-5)
		    continue;

		double Zaehler = 3.0 * x - 6.0;
		double Nenner  = (x + 2.0) * (x - 1.0) * (x - 1.0);
		double fx      = Zaehler / Nenner;

		Console.WriteLine("{0}\t{1}", x, fx);
	    }
	}
    }
}
