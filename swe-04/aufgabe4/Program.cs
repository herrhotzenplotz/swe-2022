using System;

namespace Program
{
	class Program
	{
		static void Main(string[] args)
		{
			Computer myComputer = new Computer();

			/* IP Tests */
			Console.WriteLine("My IP Address is {0}", myComputer.IPAddress);
			myComputer.IPAddress = "10.0.0.1";
			Console.WriteLine("However, now IP Address is {0}", myComputer.IPAddress);

			/* File Tests */
			for (int i = 0; i < 20; ++i) { /* this ought to be an infinite loop */
				try {
					myComputer.SaveFile("foo.txt");
				} catch (InvalidOperationException e) {
					Console.WriteLine(e.Message);
					myComputer.Reboot();
				}
			}

			/* Archive tests */
			{
				Archive myArchive1, myArchive2;
				myComputer.Archive("Eggs",  "SPAMSPAMSPAM", out myArchive1);
				Console.WriteLine("[{0}] \"{1}\" (\"{2}\")", myArchive1.ID, myArchive1.Label, myArchive1.Content);

				myComputer.Archive("Bacon", "Sausages, Spam, Baked beans", out myArchive2);
				Console.WriteLine("[{0}] \"{1}\" (\"{2}\")", myArchive2.ID, myArchive2.Label, myArchive2.Content);
			}

			/* Print computer state */
			myComputer.Print();
		}
	}
}
