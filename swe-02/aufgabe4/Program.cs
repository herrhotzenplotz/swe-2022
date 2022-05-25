using System;

namespace aufgabe4
{
    /* Funktionen
     *
     *   f(x, y) = x*y
     *
     *    Eingabeparameter - Datentyp
     *
     *    Rückgabewerte    - Datentyp
     *
     *
     *      double f(double x, double y)
     *      {
     *           return x * y;
     *      }
     */

    class Program
    {
	static double VolumeOfSphere(double d)
	{
	    /* V = 1/6 * π * d³ */
	    return Math.PI * d * d * d / 6.0;
	}

	/* void -> Kein Rückgabewert
	*
	*    Funktion hat mehrere Rückgabeparameter (out), da mehrere
	*    Werte nicht auf einmal zurückgegeben werden können. */
	static void CountNuts(double[] Nuts,
			      out int N_Hazelnuts, out int N_Walnuts,
			      out double V_Hazelnuts, out double V_Walnuts)
	{
	    N_Hazelnuts = 0;
	    N_Walnuts   = 0;
	    V_Hazelnuts = 0.0;
	    V_Walnuts   = 0.0;

	    /* Über alle Nüsse im Array iterieren */
	    for (int i = 0; i < Nuts.Length; ++i)
	    {
		/* Den Durchmesser aus dem Array lesen */
		double Diameter = Nuts[i];
		/* Volumen berechnen */
		double Volume   = VolumeOfSphere(Diameter);

		/* Wenn der Durchmesser kleiner als 2cm ist, dann ist
		 * es eine Haselnuss */
		if (Diameter < 2.0) {
		    N_Hazelnuts += 1;

		    V_Hazelnuts += Volume;
		} else { /* Andernfalls ist es eine Walnuss */
		    N_Walnuts += 1;

		    V_Walnuts += Volume;
		}
	    }

	    /* Um Division durch Null zu vermeiden */
	    if (N_Hazelnuts != 0)
		V_Hazelnuts = V_Hazelnuts / (double)N_Hazelnuts;

	    if (N_Walnuts != 0)
		V_Walnuts = V_Walnuts / (double)N_Walnuts;
	}

	static void Main(string[] args)
	{
	    /* Zufallsgenerator initialisieren */
	    Random Generator = new Random();

	    /* Anzahl an Nüssen ziehen (max. 500) */
	    int NumberOfNuts = Generator.Next(500);

	    /* Durchmesser generieren */
	    double[] Diameters = new double[NumberOfNuts];

	    for (int i = 0; i < NumberOfNuts; ++i) {
		Diameters[i] = Generator.NextDouble() * (4.0 - 0.75) + 0.75;
	    }

	    /* Nüsse zählen */
	    /*
	    static void CountNuts(double[] Nuts,
				  out int N_Hazelnuts, out int N_Walnuts,
				  out double V_Hazelnuts, out double V_Walnuts)
	    */

	    /* Variablen für die out-Parameter */
	    int Hazel, Wal;
	    double V_Hazel, V_Wal;

	    CountNuts(Diameters, out Hazel, out Wal, out V_Hazel, out V_Wal);

	    Console.WriteLine("Anzahl der Nüsse gesamt         : {0}", Diameters.Length);
	    Console.WriteLine("Anzahl der Haselnüsse gesamt    : {0}", Hazel);
	    Console.WriteLine("Anzahl der Walnüsse gesamt      : {0}", Wal);
	    Console.WriteLine("Durchschnittsvolumen Haselnüsse : {0}", V_Hazel);
	    Console.WriteLine("Durchschnittsvolumen Walnüsse   : {0}", V_Wal);
	}
    }
}
