using System;

/*
 * 6. Array
 *
 * CO2-Ausstoß zweier Inselstaate, karibischer „St. Kitts und Nevis“
 * und pazifischer „Niue“ in den letzten 10 Jahre soll in einem
 * Programm vergleichend betrachtet werden.
 *
 * Erstellen Sie dazu zwei Arrays und Initialisieren Sie diese mit
 * Werten. Vergleichen Sie die Werte paarweise miteinander und geben
 * sie die Meldung aus, welcher der Staaten den größeren Ausstoß im
 * jeweiligen Jahr hatte. Zu bestimmen ist weiterhin, welcher der
 * Staaten den größten jährlichen Ausstoß hatte, betrachtet über alle
 * Jahre.
 */

class Program
{
    static void Main(string[] args)
    {
	const int Years = 10;                       /* Number of years */
	double[] EmissionKitts = new double[Years]; /* Per year Emission of St. Kitts and Nevis */
	double[] EmissionNiue  = new double[Years]; /* Per year Emission of Niue */

	Random Gen = new Random();                  /* (Pseudo-) Random number generator */


	/* Initialize both arrays with the emission values:
	 *
	 *   First iteration:
	 *   =============================================================
	 *
	 *   Index    0   1   2   3   4   5   6   7   8   9
	 *          +---------------------------------------+
	 *   Kitts  |   |   |   |   |   |   |   |   |   |   |
	 *          +---------------------------------------+
	 *
	 *    i = 0   ^
	 *
	 *   Second iteration:
	 *   =============================================================
	 *
	 *          +---------------------------------------+
	 *   Kitts  |N_1|   |   |   |   |   |   |   |   |   |
	 *          +---------------------------------------+
	 *
	 *    i = 1       ^
	 *
	 *   =============================================================
	 *
	 *   etc...
	 *
	 * */
	for (int i = 0; i < Years; ++i) {
	    EmissionKitts[i] = Gen.NextDouble();
	    EmissionNiue[i]  = Gen.NextDouble();
	}

	/* Pair-wise comparison of the data elements
	 *
	 * two counters:
	 *
	 *   - HigherKitts - times that Kitts had higher emissions
	 *   - HigherNiue  - likewise for Niue
	 *
	 * For the second part, we sum up the emissions to calculate
	 * the country that had the largest emissions over the entire
	 * decade. */
	int HigherKitts = 0, HigherNiue = 0;
	double SumKitts = 0.0, SumNiue = 0;

	/* Iterate over all years again */
	for (int i = 0; i < Years; ++i) {
	    /* Compare emission per year and bump the counters
	     * accordingly */
	    if (EmissionKitts[i] > EmissionNiue[i]) {
		HigherKitts++;
		Console.WriteLine("Year {0}: Kitts had the higher emission", i);
	    } else if (EmissionKitts[i] < EmissionNiue[i]) {
		HigherNiue++;
		Console.WriteLine("Year {0}: Niue had the higher emission", i);
	    } else {
		/* Nothing, both had the same emissions. With
		 * doubles this is very unlikely. */
	    }

	    SumKitts += EmissionKitts[i];
	    SumNiue  += EmissionNiue[i];
	}

	/* Dump out results */
	Console.WriteLine("Kitts had higher emissions {0} times", HigherKitts);
	Console.WriteLine("Niue  had higher emissions {0} times", HigherNiue);

	if (SumKitts > SumNiue)
	    Console.WriteLine("With {0} Kitts had more emissions over the entire decade", SumKitts);
	else
	    Console.WriteLine("With {0} Niue had more emissions over the entire decade", SumNiue);
    }
}
