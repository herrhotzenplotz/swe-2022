using System;

namespace Aufgabe4
{
    class Program
    {
	static void Main(string[] args)
	{
	    int a = 1, b = 2, c = 3, r = 4;
	    double y = 4.0;

	    // d = a / b
	    {
		double d = (double)a / (double)b;
		Console.WriteLine("{0}", d);
	    }

	    // f = (a * b / (c - y)) - a / b
	    {
		double f = ((double)(a * b) / ((double)c - y)) - ((double)a / (double)b);
		Console.WriteLine("{0}", f);
	    }

	    // Pow = Power (Potenzieren), Sqrt = Square Root (Quadratwurzel)
	    //       Math.Pow(b, exp)
	    //       Math.Sqrt(rad)
	    // n-te Wurzel aus b = b ^ (1/n)
	    // f = -b * sqrt(b^2 - 4 * a * c) / (2 * a)
	    {
		// Explizite Variante
		/*
		  double f =
		  (-1.0 * (double)b *
		  Math.Sqrt(
		  Math.Pow((double)b, 2.0) - 4.0 * (double) a * (double)c))
		  / (2.0 * (double)a);
		*/

		// Vereinfachte Variante
		double f = ((-1.0 * (double)b) * Math.Sqrt((double)(b * b - 4 * a * c)))
		    / (2.0 * (double)a);

		Console.WriteLine("{0}", f);
	    }

	    // A = pi * r^2, pi = Math.PI
	    {
		// r^2 ist auch eine Ganzzahl, wenn r eine Ganzzahl ist.
		double A = Math.PI * (double)(r * r);
		Console.WriteLine("${0}", A);
	    }
	}
    }
}
