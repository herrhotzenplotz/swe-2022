using System;

namespace aufgabe7
{
    class Program
    {
	static void Main(string[] args)
	{
	    /* Array (Liste) mit den Name */
	    string[] Names = {
		"Marte Olbu Röisland",
		"Elvira Öberg",
		"Lisa Theresa Hauser",
		"Hanna Öberg",
		"Anais Chevalier-Bouchet",
		"Denise Herrmann",
		"Dzinara Alimbekava",
		"Justine Braisaz-Bouchet",
		"Dorothea Wierer",
		"Marketa Davidova"
	    };

	    /* GitHub-flavoured Markdown Specification:
	     *
	     *   https://github.github.com/gfm/#tables-extension-
	     *
	     * Hier geben wir zuerst den Tabellenkopf aus */
	    Console.WriteLine("| Platzierung | Name |");
	    Console.WriteLine("| --- | --- |");

	    /* Counter für den Platz */
	    int Platz = 1;

	    /* Über alle Elemente des Arrays ›Names‹ von oben nach
	     * unten iterieren. Der jeweilige Name wird in der
	     * Variable ›Name‹ gespeichert. */
	    foreach (string Name in Names) {
		Console.WriteLine("| {0} | {1} |", Platz++, Name);
	    }

	    /* Endlosschleife */
	    for (;;)
	    {
		/* Entweder wirft Convert.ToInt32 oder Names[Index]
		 * eine Exception. Diese fangen wir dann explizit mit
		 * catch-Blöcken ab. */
		try
		{
		    int Index;

		    /* Den Benutzer nach dem Index fragen */
		    Console.Write("Index: ");
		    Index = Convert.ToInt32(Console.ReadLine());

		    /* Den Name im Array nachschlagen */
		    string RequestedName = Names[Index];

		    /* Die Platzierung und den zugehörigen Namen ausgeben */
		    Console.WriteLine("Platz {0}: {1}",
				      Index + 1, RequestedName);
		}
		catch (FormatException)
		{
		    Console.WriteLine("Fehler: Der eingegebene Index war keine Zahl.");
		}
		catch (IndexOutOfRangeException)
		{
		    Console.WriteLine("Fehler: Der eingegebene Index war zu groß oder zu klein.");
		}
		catch (Exception e) /* Alle anderen Fälle */
		{
		    Console.WriteLine("Fehler: {0}", e.Message);
		}
	    }
	}
    }
}
