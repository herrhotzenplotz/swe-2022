using System;

/* Lösung für
 * https://github.com/ComputerScienceLecturesTUBAF/SoftwareentwicklungSoSe2022_Aufgabe_01#5-wiederholung */

class Program {
    static void Main(string[] args) {
	/* Kontobilanz */
	int balance = 0;

	/* Zufallsgenerator */
	Random gen = new Random();

	/* 1000 Versuche */
	for (int round = 0; round < 1000; ++round) {
	    sum = 0;

	    /* Einsatz */
	    balance -= 1;

	    /* Dreimal würfeln */
	    for (int i = 0; i < 3; ++i)
		sum += gen.Next(1, 6);

	    /* Je nach Augenzahl */
	    switch (sum) {
		case 18:
		    balance += 100;
		    break;
		case 17:
		    balance += 10;
		    break;
		case 16:
		    balance += 5;
		    break;
		default:
		    balance += 0;
		    break;
	    }

	    Console.WriteLine("{0}\t{1}", round, balance);
	}
    }
}
