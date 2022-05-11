using System;

namespace aufgabe2
{
    class Program
    {
	static void Main(string[] args)
	{
	    int Jahr;

	    Console.Write("Jahr: ");
	    Jahr = Convert.ToInt32(Console.ReadLine());

	    /* Teilbarkeit über Division mit Rest:
	     *
	     *   N | B <==> N % B == 0
	     *
	     *   N ist durch B teilbar, genau dann wenn der Rest der
	     *   Division von N / B 0 ist:
	     *
	     *   Bsp.: ist 7 durch 3 teilbar?
	     *
	     *          Nein, weil 7 / 3 = 2 Rest 1
	     *                und der Rest ist 1 != 0. */

	    if (Jahr % 4 != 0) { /* Wenn nicht durch vier teilbar, dann kein Schaltjahr */
		Console.WriteLine("Kein Schaltjahr");
	    } else {
		/* Wenn durch 100 aber nicht durch 400 teilbar, dann kein Schaltjahr */
		if (Jahr % 100 == 0 && Jahr % 400 != 0) {
		    Console.WriteLine("Kein Schaltjahr");
		} else {
		    Console.WriteLine("Ein Schaltjahr");
		}
	    }
	}
    }
}
