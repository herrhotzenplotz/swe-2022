using System;

namespace aufgabe2
{
    /* Enumerations-Datentyp:
     *
     * Diese Datentypen sind für Kategorien besonders geeignet.
     */
    public enum Kategorie { THERMO, ELEKTRO, NONE }

    /* Die Klasse Energiewesen.
     *
     * Eine Klasse ist eine Vorlage für ein Objekt. So erzeugen wir in
     * Program.Main() zwei Objekte Wesen1 und Wesen2 der Klasse
     * Energiewesen. Sie haben also die gleichen Methoden (Funktionen)
     * und Eigenschaften.
     *
     * Ein Objekt einer Klasse wird mit dem Konstruktor (constructor)
     * erstellt. Dieser ist eine Funktion, die auch Argumente annehmen
     * kann. */
    public class Energiewesen
    {
	/* Der Default-Konstruktor. Er nimmt keine Argumente an und
	 * weist dem Energiewesen sinnvolle Default-Werte zu. */
	public Energiewesen()
	{
	    m_Bezeichnung = "Unbenanntes Wesen";
	    m_RegNummer   = 0;
	    m_Kateg       = Kategorie.NONE;
	    m_Leistung    = Double.NaN;
	}

	/* Ein alternativer Konstruktor, der 4 Argumente annimmt und
	 * diese verarbeitet, um das Objekt zu initialisieren. */
	public Energiewesen(string Bezeichnung, int RegNummer, Kategorie Kateg, double Leistung)
	{
	    m_Bezeichnung = Bezeichnung;
	    m_RegNummer   = RegNummer;
	    m_Kateg       = Kateg;
	    m_Leistung    = Leistung;
	}

	/* Private interne Datenfelder der Klasse.
	 *
	 * Diese sind privat, sodass wir von außerhalb der Klasse
	 * (z.B. in der Main-Methode) nicht auf den internen Zustand
	 * zugreifen können und diesen modifizieren können. */
	private string    m_Bezeichnung;
	private int       m_RegNummer;
	private Kategorie m_Kateg;
	private double    m_Leistung;

	/* Jeweils Getter- und Setter-Methoden für die Datenfelder
	 *
	 * - Setter-Methoden setzen das internen Datenfeld auf den übergebenen Wert.
	 * - Getter-Methoden geben den aktuellen Wert des internen Datenfelds zurück. */
	public void SetBezeichnung(string Bezeichnung) { m_Bezeichnung = Bezeichnung; }
	public string GetBezeichnung() { return m_Bezeichnung; }

	public void SetRegNummer(int RegNummer) { m_RegNummer = RegNummer; }
	public int GetRegNummer() { return m_RegNummer; }

	public void SetKategorie(Kategorie Kat) { m_Kateg = Kat; }
	public Kategorie GetKategorie() { return m_Kateg; }

	public void SetLeistung(double Leistung) { m_Leistung = Leistung; }
	public double GetLeistung() { return m_Leistung; }

	/* Nur eine Ausgaberoutine */
	public void Print()
	{
	    Console.WriteLine("Wesen {{ Bezeichnung = {0}, RegNummer = {1}, Kategorie = {2}, Leistung = {3} }}",
			      m_Bezeichnung, m_RegNummer, m_Kateg, m_Leistung);
	}
    }
}
