using System;

namespace Aufgabe4c
{
    class Program
    {
	static void Main(string[] args)
	{
	    /*
	     * Der Mono C# Compiler unterstützt binäre Literale nicht,
	     * deshalb hier die hexadezimale Darstellung.
	     */
	    int x = 0x11; // 0b0001_0001;
	    int y = 0x88; // 0b1000_1000;
	    int z = 0x0F; // 0b0000_1111

	    /*
	     * Einmal die Rechnung hier for x & y & z:
	     *
	     *    x | 0b0001_0001| 0x11
	     *    y | 0b1000_1000| 0x88
	     *  ====+============+=====
	     *  x&y | 0b0000_0000| 0x00
	     *    z | 0b0000_1111| 0x0F
	     *  ====+============+=====
	     *  & z | 0b0000_0000| 0x00
	     */
	    Console.WriteLine("0x{0:x2}", (byte)(x & y & z));

	    /*
	     * Für (x | y) & z:
	     *
	     *    x | 0b0001_0001| 0x11
	     *    y | 0b1000_1000| 0x88
	     *  ====+============+=====
	     *  x|y | 0b1001_1001| 0x99
	     *    z | 0b0000_1111| 0x0F
	     *  ====+============+=====
	     *  & z | 0b0000_1001| 0x09
	     */
	    Console.WriteLine("0x{0:x2}", (byte)((x | y) & z));

	    /*
	     * Für ~(x ^ y):
	     *
	     *   Hinweis: ^ ... Exklusiv-Oder (ungleich / entweder-oder)
	     *            ~ ... Nicht (Bitflip / Bit-Inverse)
	     *
	     *    x | 0b0001_0001| 0x11
	     *    y | 0b1000_1000| 0x88
	     *  ====+============+=====
	     *  x^y | 0b1001_1001| 0x99
	     *  ====+============+=====
	     *    ~ | 0b0110_0110| 0x66
	     */
	    Console.WriteLine("0x{0:x2}", (byte)(~(x ^ y)));

	    /*
	     * Für ~(x ^ y) & byte.MaxValue:
	     *
	     *    x | 0b0001_0001| 0x11
	     *    y | 0b1000_1000| 0x88
	     *  ====+============+=====
	     *  x^y | 0b1001_1001| 0x99
	     *  ====+============+=====
	     *    ~ | 0b0110_0110| 0x66
	     *      | 0b1111_1111| 0xFF
	     *  ====+============+=====
	     *   &  | 0b0110_0110| 0x66
	     */
	    Console.WriteLine("0x{0:x2}", (byte)(~(x ^ y) & byte.MaxValue));
	}
    }
}
