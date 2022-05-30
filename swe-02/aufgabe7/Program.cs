using System;

namespace aufgabe7
{
    class Program
    {
	static void Main(string[] args)
	{
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

	    Console.WriteLine("| Platzierung | Name |");
	    Console.WriteLine("| --- | --- |");

	    int Platz = 1;

	    foreach (string Name in Names) {
		Console.WriteLine("| {0} | {1} |", Platz++, Name);
	    }

	    for (;;)
	    {
		try
		{
		    int Index;

		    Console.Write("Index: ");
		    Index = Convert.ToInt32(Console.ReadLine());

		    string RequestedName = Names[Index];

		    Console.WriteLine("Platz {0}: {1}",
				      Index + 1, RequestedName);
		}
		catch (Exception e)
		{
		    Console.WriteLine("Fehler: {0}", e.Message);
		}
	    }
	}
    }
}
