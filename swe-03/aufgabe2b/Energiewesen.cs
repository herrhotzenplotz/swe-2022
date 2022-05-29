using System;

namespace aufgabe2
{
    public enum Kategorie { THERMO, ELEKTRO, NONE }

    public class Energiewesen
    {
	public Energiewesen()
	{
	    this.Bezeichnung = "Unbenanntes Wesen";
	    this.RegNummer   = 0;
	    this.Kateg       = Kategorie.NONE;
	    this.Leistung    = Double.NaN;
	}

	public Energiewesen(string Bezeichnung, int RegNummer, Kategorie Kateg, double Leistung)
	{
	    this.Bezeichnung = Bezeichnung;
	    this.RegNummer   = RegNummer;
	    this.Kateg       = Kateg;
	    this.Leistung    = Leistung;
	}

	/* Automatic Properties */
	public string    Bezeichnung { get; set; }
	public int       RegNummer   { get; set; }
	public Kategorie Kateg       { get; set; }
	public double    Leistung    { get; set; }

	public void Print()
	{
	    Console.WriteLine("Wesen {{ Bezeichnung = {0}, RegNummer = {1}, Kategorie = {2}, Leistung = {3} }}",
			      this.Bezeichnung,
			      this.RegNummer,
			      this.Kateg,
			      this.Leistung);
	}
    }
}
