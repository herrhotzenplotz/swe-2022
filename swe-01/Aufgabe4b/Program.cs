using System;

namespace Aufgabe4b
{
    class Program
    {
	static void Main(string[] args)
	{
	    double x1, x2, y1, y2, x, y;

	    // Werte x1, x2 und x einlesen
	    Console.Write("x1: ");
	    x1 = Convert.ToDouble(Console.ReadLine());

	    Console.Write("x2: ");
	    x2 = Convert.ToDouble(Console.ReadLine());

	    Console.Write("x: ");
	    x = Convert.ToDouble(Console.ReadLine());

	    // Werte y1, y2 und y einlesen
	    Console.Write("y1: ");
	    y1 = Convert.ToDouble(Console.ReadLine());

	    Console.Write("y2: ");
	    y2 = Convert.ToDouble(Console.ReadLine());

	    Console.Write("y: ");
	    y = Convert.ToDouble(Console.ReadLine());

	    // ob der Punkt im Rechteck x1,y1 .. x2,y2 liegt
	    bool b2 = ((x1 <= x) && (x <= x2)) && ((y1 <= y) && (y <= y2));
	    Console.WriteLine("Der Punkt liegt im Rechteck : {0}", b2);

	    // ob mindestens eine der Bedingungen x1<=x<=x2 bzw. y1<=y<=y2 zutrifft.
	    bool b3 = ((x1 <= x) && (x <= x2)) || ((y1 <= y) && (y <= y2));
	    Console.WriteLine("x1<=x<=x2 oder y1<=y<=y2 : {0}", b3);
	}
    }
}
