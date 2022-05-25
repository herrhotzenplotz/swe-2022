using System;
using System.Threading;


/* Lösung für :
 * https://github.com/ComputerScienceLecturesTUBAF/SoftwareentwicklungSoSe2022_Aufgabe_02#1-statische-methoden-for-each-schleifen-console-sleep */
namespace aufgabe1
{
    class Program
    {
	/**
	 * Program.Flash(): Flash the console screen in red for the
	 * given duration in milliseconds.
	 */
	static void Flash(int Duration)
	{
	    Console.BackgroundColor = ConsoleColor.Red;
	    Console.Clear();
	    Thread.Sleep(Duration);

	    Console.BackgroundColor = ConsoleColor.Black;
	    Console.Clear();
	    Thread.Sleep(Duration);
	}

	static void Main(string[] args)
	{
	    string Message;

	    Console.Write("Please enter a message: ");
	    Message = Console.ReadLine();

	    /* Jeden Buchstaben der Nachricht in Morse Code übersetzen */
	    foreach (char Character in Message) {
		/* MorseTable ist in MorseTable.cs definiert */
		string MorseCode = MorseTable.GetMorseCode(Character);

		foreach (char Code in MorseCode) {
		    if (Code == '.')
			Flash(200); /* Kurzes Signal: 200ms */
		    else if (Code == '-')
			Flash(400); /* Langes Signal: 400ms */
		    else
			Thread.Sleep(500);
		}
	    }
	}
    }
}
