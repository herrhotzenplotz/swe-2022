using System;

namespace aufgabe2
{
    class Program
    {
	static void Main(string[] args)
	{
	    Energiewesen Wesen1 = new Energiewesen(
		"Wesen 1", 42, Kategorie.THERMO, 3.14);
	    Energiewesen Wesen2 = new Energiewesen();

	    Wesen2.Leistung = 2.72;
	    Wesen2.Kateg = Kategorie.ELEKTRO;

	    Wesen1.Print();
	    Wesen2.Print();
	}
    }
}
