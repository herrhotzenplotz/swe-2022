using System;

namespace aufgabe2
{
    public enum Kategorie { THERMO, ELEKTRO, NONE }

    public class Energiewesen
    {
	public Energiewesen()
	{
	    m_Bezeichnung = "Unbenanntes Wesen";
	    m_RegNummer   = 0;
	    m_Kateg       = Kategorie.NONE;
	    m_Leistung    = Double.NaN;
	}

	public Energiewesen(string Bezeichnung, int RegNummer, Kategorie Kateg, double Leistung)
	{
	    m_Bezeichnung = Bezeichnung;
	    m_RegNummer   = RegNummer;
	    m_Kateg       = Kateg;
	    m_Leistung    = Leistung;
	}

	/* Private interne Datenfelder der Klasse */
	private string    m_Bezeichnung;
	private int       m_RegNummer;
	private Kategorie m_Kateg;
	private double    m_Leistung;

	/* Jeweils Getter- und Setter-Methoden für die Datenfelder */
	public void SetBezeichnung(string Bezeichnung) { m_Bezeichnung = Bezeichnung; }
	public string GetBezeichnung() { return m_Bezeichnung; }

	public void SetRegNummer(int RegNummer) { m_RegNummer = RegNummer; }
	public int GetRegNummer() { return m_RegNummer; }

	public void SetKategorie(Kategorie Kat) { m_Kateg = Kat; }
	public Kategorie GetKategorie() { return m_Kateg; }

	public void SetLeistung(double Leistung) { m_Leistung = Leistung; }
	public double GetLeistung() { return m_Leistung; }

	public void Print()
	{
	    Console.WriteLine("Wesen {{ Bezeichnung = {0}, RegNummer = {1}, Kategorie = {2}, Leistung = {3} }}",
			      m_Bezeichnung, m_RegNummer, m_Kateg, m_Leistung);
	}
    }
}
