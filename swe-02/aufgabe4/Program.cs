using System;

namespace aufgabe4
{
    class Program
    {
	static void Main(string[] args)
	{
	    Random Generator = new Random();

	    int NumberOfNuts = Generator.Next(500);

	    double[] Diameters = new double[NumberOfNuts];

	    for (int i = 0; i < NumberOfNuts; ++i) {
		Diameters[i] = Generator.NextDouble() * (4.0 - 0.75) + 0.75;
	    }
	}
    }
}
