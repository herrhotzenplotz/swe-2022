using System;

/* Diese Aufgabe ist in zwei Dateien aufgeteilt:
 *
 *   - Program.cs
 *   - Energiewesen.cs
 *
 * Der interessante Teil ist in Letzterer zu finden. */

namespace aufgabe2
{
    class Program
    {
	static void Main(string[] args)
	{
	    /* Den alternativen Konstruktor aufrufen */
	    Energiewesen Wesen1 = new Energiewesen(
		"Wesen 1", 42, Kategorie.THERMO, 3.14);

	    /* Default-Konstruktor */
	    Energiewesen Wesen2 = new Energiewesen();

	    /* Beide Objekte ausgeben */
	    Wesen1.Print();
	    Wesen2.Print();
	}
    }
}
