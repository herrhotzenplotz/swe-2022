# Lösung für Aufgabe 4

Dies ist lediglich eine Musterlösung.

## Hinweise

- Teilaufgabe 3 fehlt die Implementierung für IPv6.
- Alle Klassen sind in einer eigenen Datei.
- Zum Kompilieren entweder das Makefile benutzen oder den Compiler
  manuell aufrufen:

		csc -out:Program.exe *.cs

## Aufgabenstellung

1. Um den Benutzername festhalten zu können wird ein Property
   (z. B. *UserName*) benötigt. Der Benutzername soll nach außen hin
   zwar les- aber nicht schreibbar sein. Bitte fügen Sie Ihrer Klasse
   ein solches Property hinzu und initialisieren Sie es in einem
   eigens erstellten Konstruktor mit dem Startwert "Administrator".

   Um den aktuellen Benutzer zu wechseln, soll eine Methode
   implementiert werden, die den neuen Benutzernamen als Zeichenkette
   übernimmt. Dazu wartet die Methode einen kurzen Moment und gibt
   passende Ausgaben auf der Konsole aus, bevor der neue Name
   zugewiesen wird:

   *Logging out ...*

   *Logging in as root*

2. Zum Speichern der Dateien implementieren Sie bitte eine Methode,
   die einen Pfad zu einem Verzeichnis sowie einen Dateinamen
   übernimmt. Verwenden Sie zur Erstellung des zusammengesetzten
   Dateipfades die *Combine(...)*-Methoden der Klasse
   `System.IO.Path`. Der eigentliche Speichervorgang wird als
   Konsolenausgabe realisiert, z. B.:

	  *Saving file: C:\Users\root\Desktop\Dissertation.tex*

   Überladen Sie Ihre Methode zum Speichern mit einer zweiten Version,
   die nur einen Dateinamen übernimmt und als Verzeichnis den Desktop
   des aktuellen Benutzers wählt. Die eigentliche Programmlogik soll
   nicht doppelt implementiert werden, d.h. realisieren Sie die
   Funktionalität der zweiten Methode über den Aufruf der ersten.

   Beim Speichern wichtiger Dateien stürzen Computer erfahrungsgemäß
   gern ab. Implementieren Sie dazu eine zufällige Abfrage in der
   Speichermethode. In einem von vier Fällen findet ein Absturz statt
   und eine `InvalidOperationException` wird geworfen.

   Sobald ein Absturz einmal aufgetreten ist, funktioniert das
   Speichern von Dateien bis zum nächsten Neustart des Computers nicht
   mehr und wirft immer eine
   `InvalidOperationException`. Implementieren Sie dieses Verhalten
   mittels einer automatischen Boolean-Property und einer
   *Reboot()*-Methode. Nach außen hin soll die Property nur lesbar
   sein.

   Lassen Sie Ihren Computer in der Main(...)-Methode in einer
   Endlosschleife Dateien speichern. Starten Sie ihn neu, sobald er
   abstürzt.

3. Implementieren Sie die IP-Adresse in der Computer-Klasse als
   privates byte-Array-Feld. Als initialer Wert soll *LocalHost*
   gesetzt sein. Nach außen wird die IP-Adresse über eine Property vom
   Typ `String` angesprochen. Verwenden Sie in den set- und get-Teilen
   der Property die statischen Methoden der Klasse **IPTools**.

   Erstellen Sie die `static` Klasse **IPTools**, die über die
   Methoden zum Konvertieren zwischen den IP-Adressen als `byte`-Array
   und `string` verfügt und die Verarbeitung sowohl IPv4- als auch
   IPv6-Adressen unterstützt.

   Die IPv4-Adressen bestehen aus 4 Blocken, die durch einen Punkt
   getrennt sind. Die IPv6-Adressen bestehen aus 16 Bytes und werden
   in hexadezimaler Form als 8 Blöcke (je 2 Bytes) notiert, z. B.:
   ffee:ddcc:bbaa:9988:7766:5544:3322:1100

   Erstellen Sie außerdem in der Klasse ein `static readonly
   byte`-Feld, das LocalHost (127.0.0.0) representiert und zum
   Initialisieren der IP-Adresse in der Klasse Computer verwendet
   wird.

4. Um die Archivierung zu ermöglichen, legen Sie bitte zunächst eine
   Archiv-Klasse an. Die Klasse soll über eine ID, eine Beschriftung
   (Zeichenkette) und einen Inhalt (ebenfalls Zeichenkette)
   verfügen. Implementieren Sie alle drei Elemente als
   nicht-schreibbare, automatische Properties.

   Implementieren Sie einen Konstruktor, der die Bezeichnung und den
   Inhalt als Parameter übernimmt. Die ID soll mit jedem neu erzeugten
   Archiv hochgezählt, und nicht als Konstruktor-Parameter übergeben
   werden.

   Fügen Sie Ihrer Computer-Klasse eine Methode zum Archivieren
   hinzu. Übergeben werden an die Methode die Bezeichnung und der
   Inhalt, die zum Erstellen eines Archiveintrags benötigt werden. Der
   eigentliche Archivierungsvorgang wird als Konsolenausgabe
   realisiert, z. B.:

		*Archiving data ...*

   Erstellen Sie in der Main(...)-Methode zwei Archive und geben Sie
   die Bezeichner, den Inhalt und die IDs aus, z. B.:

		[0] "Absatz von Smartphones" ("173.5, 304.7, 494.5, 725.3, 1019.4, 1301.7, 1437.6, 1469, 1465.5, 1402.6, 1372.6, 1280")
		[1] "Impfbereitschaft" ("7, 6, 11, 75")

5. Implementieren Sie außerdem in der Computerklasse eine
   Print()-Methode, die die relevanten Eigenschaften des Computers
   ausgibt (Benutzername, IP-Adresse, Absturzzustand).
