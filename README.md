Raw:
[AllesAufgaben1bis7.txt](https://github.com/bleach4171/PrivateIgri/files/15059823/AllesAufgaben1bis7.txt)

Willkommen beim 4. Block den Grundlagen der objektorientierten Programmierung.

Sie haben diese Woche 7 Programmieraufgaben zu erledigen. Die ersten 4 Aufgaben sind in erster Linie Klassen-Programmierungen, welche über eine automatische Abgabe bewertet werden. Deswegen halten Sie sich sehr genau an die Angaben! Die letzten 3 Aufgaben lassen dann mehr Freiheiten, da sie auch individuell bewertet werden.

Sie können die ersten 4 Aufgaben in Java oder C# programmieren. Die Abgabe ist leider nur in Java möglich. Falls es Probleme gibt, bitte übers Forum melden! Die letzten 3 Beispiele sind in C# zu programmieren!


Bewertung
       Aufgaben      	    Programmieren   	    Gesamt   
1. Aufgabe	 9%	 6,3%
2. Aufgabe
 9%	 6,3%
3. Aufgabe	 10%	 7%
4. Aufgabe	 15%	 10,5%
5. Aufgabe	 19%	 13,3%
6. Aufgabe	 19%	 13,3%
7. Aufgabe	 19%	 13,3%
Gesamt:	100%	70%
Jedes Beispiel, welches Sie lösen, soll als dokumentierter Source-Code in Ihrem Portfolio landen. Für die letzten 3 Beispiele soll ebenfalls eine genaue Bedienungsanleitung Ihres Programmes sowie die Testfälle dort zu finden sein.

Zusammenfassung:

70% Programmieren 
30% Portfolio
Höchste	Niedrigste	Note
100,00 %	87,50 %	1
87,49 %	75,00 %	2
74,99 %	62,50 %	3
61,99 %	50,00 %	4
49,99 %	0,00 %	5



Hier ist die genaue Aufgabenstellung für die Klasse "Buch".

Programmieren Sie eine Klasse namens "Buch" für die Speicherung von Büchern. Die Klasse muss folgende Felder haben:

Titel
Author
ISBN
Genre
Verlag
Erscheinungsjahr
Kommentar
Definieren Sie die Felder mit den passenden Formaten, wie zum Beispiel private String Titel;
Die Klasse soll folgende Konstruktoren enthalten:

Konstruktor der Titel und Author übergeben bekommt, alles anderes wird leer initialisiert
Konstruktor der Titel, Author, ISBN und Erscheinungsjahr übergeben bekommt, alles anderes wird leer initialisiert
Konstruktor der alle Felder übergeben bekommt
Konstruktor der nichts übergeben bekommt und alles leer initialisiert
Jedes Feld soll eine get- und set-Methode namens get_<Name des Feldes> bzw. set_<Name des Feldes> haben, wie zum Beispiel public String get_Titel()

Achten Sie auf die Namensgebung und die Reihenfolge der Übergabewerte bei den Konstruktoren!




Hier ist die genaue Aufgabenstellung für die Klasse "Schauspieler".

Programmieren Sie eine Klasse namens "Schauspieler" für die Speicherung von Schaupielern. Die Klasse muss folgende Felder haben:

Vorname
Nachname
Spitzname
Geburtsort
Geburtsdatum
Nationalitaet
Groesse(in Meter)
Definieren Sie die Felder mit den passenden Formaten, wie zum Beispiel private String Vorname;
Die Klasse soll folgende Konstruktoren enthalten:

Konstruktor der Vorname und Nachname übergeben bekommt, alles anderes wird leer initialisiert
Konstruktor der Vorname, Nachname, Spitzname und Groesse übergeben bekommt, alles anderes wird leer initialisiert
Konstruktor der alle Felder übergeben bekommt
Konstruktor der nichts übergeben bekommt und alles leer initialisiert
Jedes Feld soll eine get- und set-Methode namens get_<Name des Feldes> bzw. set_<Name des Feldes> haben, wie zum Beispiel public String get_Vorname()

Achten Sie auf die Namensgebung und die Reihenfolge der Übergabewerte bei den Konstruktoren!



Hier ist die genaue Aufgabenstellung für die Klasse "Film".

Programmieren Sie eine Klasse namens "Film" für die Speicherung von Filmen. Die Klasse muss folgende Felder haben:

Titel
Erscheinungsjahr
Genre
Laufzeit(in ganzen Minuten)
Cast(Schauspieler)
Sprache
FSK
Definieren Sie die Felder mit den passenden Formaten, wie zum Beispiel private String Titel;
Der Cast ist eine Liste von Schauspielern(Klasse der vorherigen Aufgabe)!

Die Klasse soll folgende Konstruktoren enthalten:

Konstruktor der Titel und Erscheinungsjahr übergeben bekommt, alles anderes wird leer initialisiert
Konstruktor der Titel, Erscheinungsjahr, Genre und Laufzeit übergeben bekommt, alles anderes wird leer initialisiert
Konstruktor der alle Felder übergeben bekommt
Konstruktor der nichts übergeben bekommt und alles leer initialisiert
Jedes Feld soll eine get- und set-Methode namens get_<Name des Feldes> bzw. set_<Name des Feldes> haben, wie zum Beispiel public String get_Titel()

Achten Sie auf die Namensgebung und die Reihenfolge der Übergabewerte bei den Konstruktoren!




1.Aufgabe
Programmieren Sie eine Klasse namens "Held" für die Speicherung von Helden. Die Klasse muss folgende Felder haben:

Name
Level
Kosten
Trefferpunkte
Regenerationszeit
Schaden (Pro Schlag)
Spezialfähigkeit
Definieren Sie die Felder mit den passenden Formaten, wie zum Beispiel private String Name;

Die Klasse soll folgende Konstruktoren enthalten:

Konstruktor der Name und Level übergeben bekommt, alles anderes wird leer initialisiert
Konstruktor der Name, Level, Kosten und Trefferpunkte übergeben bekommt, alles anderes wird leer initialisiert
Konstruktor der alle Felder übergeben bekommt
Konstruktor der nichts übergeben bekommt und alles leer initialisiert
Jedes Feld soll eine get- und set-Methode namens get_<Name des Feldes> bzw. set_<Name des Feldes> haben, wie zum Beispiel public String get_Name()


2.Aufgabe

Programmieren Sie eine Klasse namens "Trupp" für die Speicherung von Truppen. Die Klasse muss folgende Felder haben:Level

Name
Level
Entwicklungskosten
Baukosten
Elixier (0= dunkles Elixier und 1 = normales Elixier)
Trefferpunkte
Schaden (Pro Schlag)
Bewegungsgeschwindigkeit
Angriffsgeschwindigkeit
Reichweite
Wohnraum
Einzel (Schadensart 0 = mehrere Ziele, 1 = einzelne Ziele)
Definieren Sie die Felder mit den passenden Formaten, wie zum Beispiel private Integer Level;

Die Klasse soll folgende Konstruktoren enthalten:

Konstruktor der Name, Level, Entwicklungskosten und Baukosten übergeben bekommt, alles anderes wird leer initialisiert
Konstruktor der Name, Level, Entwicklungskosten, Baukosten, Elixier und Reichweite übergeben bekommt, alles anderes wird leer initialisiert
Konstruktor der alle Felder übergeben bekommt
Konstruktor der nichts übergeben bekommt und alles leer initialisiert
Jedes Feld soll eine get- und set-Methode namens get_<Name des Feldes> bzw. set_<Name des Feldes> haben, wie zum Beispiel public Integer get_Level()

Achten Sie auf die Namensgebung und die Reihenfolge der Übergabewerte bei den Konstruktoren! Recherchieren Sie ausführlich im Fan-Wiki damit die Datenformate passen!



Hier ist die genaue Aufgabenstellung für den Taschenrechner.

Programmieren Sie einen Taschenrechner mit Klassen in einer Konsolen-Anwendung. Es bleibt Ihnen selber überlassen wie Sie es lösen. Folgende Rechenoperationen sollen mit Kommazahlen möglich sein und als Methoden realisiert werden:

Addition
Subtraction
Multiplikation
Division
Potenzieren
Wurzel ziehen
Logarithmus
Fakultät
Sinus, Cosinus und Tangens


Überlegen Sie sich mindestens 9 gute Testfälle und dokumentieren Sie diese im Portfolio.

Der Taschenrechner muss sich immer das letzte Ergebnis merken. Wie sie die Eingaben des Users regeln überlasse ich auch Ihrer Kreativität!



Hier ist die genaue Aufgabenstellung für den Bruchrechner.

Programmieren Sie einen Bruchrechner mit Klassen in einer Konsolen-Anwendung. Es bleibt Ihnen selber überlassen wie Sie es lösen. Folgende Rechenoperationen sollen mit Brüchen(teilweise mit Operatorüberladung) möglich sein und als Methoden realisiert werden:

Addition
Subtraction
Multiplikation
Division
Potenzieren
Wurzel ziehen
Überlegen Sie sich mindestens 12 gute Testfälle und dokumentieren Sie diese im Portfolio.

Das Ergebnis muss immer soweit wie möglich gekürzt sein! Der Bruchrechner muss sich immer das letzte Ergebnis merken. Wie sie die Eingaben des Users regeln überlasse ich auch Ihrer Kreativität!



Hier ist die genaue Aufgabenstellung für den Zahlensystemumrechner.

Programmieren Sie einen Zahlenumrechner mit Klassen in einer Konsolen-Anwendung. Es bleibt Ihnen selber überlassen wie Sie es lösen. Folgende Rechenoperationen sollen in allen Zahlensystemen(teilweise mit Operatorüberladung) möglich sein und als Methoden realisiert werden:

Addition
Subtraction
Multiplikation
Division
Die folgenden Zahlensysteme sollen in die jeweils anderen umrechenbar sein und als Methoden realisiert werden:

Binär
Oktal
Dezimal
Hexadezimal
Überlegen Sie sich mindestens 12 gute Testfälle und dokumentieren Sie diese im Portfolio.

Wie sie die Eingaben des Users regeln überlasse ich auch Ihrer Kreativität!
