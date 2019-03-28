using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrzeugverwaltung
{
    // Klasse zur Verwaltung von Parkhäusern und Fahrzeugen
    public class Verwaltung
    {
        // Liste Parkhäuser
        private List<Parkhaus> Parkhaeuser;

        // Liste Fahrzeuge
        private List<Fahrzeug> Fahrzeuge;

        // Konstruktor
        public Verwaltung()
        {
            // Erzeuge leere Fahrzeugliste
            Fahrzeuge = new List<Fahrzeug>();

            // Erzeuge leere Parkhausliste
            Parkhaeuser = new List<Parkhaus>();
        }

        // Gibt Anzahl der Parkhäuser in der Liste zurück
        public int AnzahlParkhaeuser
        {
            get
            {
                return Parkhaeuser.Count;
            }
        }

        // Gibt Anzahl der Fahrzeuge in der Liste zurück
        public int AnzahlFahrzeuge
        {
            get
            {
                return Fahrzeuge.Count;
            }
        }

        // Fügt ein Parkhaus zur Liste hinzu
        public void ParkhausHinzufuegen(Parkhaus value)
        {
            Parkhaeuser.Add(value);
        }

        // Fügt ein Fahrzeug zur Liste hinzu
        public void FahrzeugHinzufuegen(Fahrzeug value)
        {
            Fahrzeuge.Add(value);
            StellplaetzeZuordnen();
        }
        
        // Löscht das Parkhaus mit der Nummer id
        public void ParkhausLoeschen(int id)
        {
            // Parkhaus nur dann löschen wenn der Index kleiner als die Anzahl der Parkhäuser ist
            if ((id >= 0) && (id < AnzahlParkhaeuser))
            {
                Parkhaeuser.RemoveAt(id);
                StellplaetzeZuordnen();
            }
        }

        // Löscht das Fahrzeug mit der Nummer id
        public void FahrzeugLoeschen(int id)
        {
            // Fahrzeug nur dann löschen wenn der Index kleiner als die Anzahl der Fahrzeuge ist
            if ((id >= 0) && (id < AnzahlFahrzeuge))
            {
                Fahrzeuge.RemoveAt(id);
                StellplaetzeZuordnen();
            }
        }

        // Gibt das Parkhaus mit der Nummer id zurück
        public Parkhaus ParkhausGet(int id)
        {
            // Parkhaus nur dann zurückgeben, wenn der Index kleiner als die Anzahl der Parkhäuser ist
            if ((id >= 0) && (id < AnzahlParkhaeuser))
            {
                return Parkhaeuser[id];
            }
            else
            {
                return null;
            }
        }

        // Gibt das Fahrzeug mit der Nummer id zurück
        public Fahrzeug FahrzeugGet(int id)
        {
            // Fahrzeug nur dann zurückgeben, wenn der Index kleiner als die Anzahl der Fahrzeuge ist
            if ((id >= 0) && (id < AnzahlFahrzeuge))
            {
                return Fahrzeuge[id];
            }
            else
            {
                return null;
            }
        }

        // Lädt die Daten aller Parkhäuser aus einer Datei
        private void LadenParkhaueser()
        {
            // Laden der Parkhäuser aus einer Datei ist noch nicht implementiert.
            // Parkhaus wird einfach erzeugt und zur Liste hinzugefügt.

            Parkhaeuser.Add(new Parkhaus(1, 320, "51105", "Köln", "Westerwaldstr. 99"));

            // Hach dem Erzeugen des Parkhaus sind alle Stellplätze als PKW-Stellplätze voreingestellt
            // Erzeuge 5 Motorradstellplätze
            Parkhaus ph = Parkhaeuser[0];
            ph.StellPlaetze[199].Typ = "Motorrad";
            ph.StellPlaetze[200].Typ = "Motorrad";
            ph.StellPlaetze[201].Typ = "Motorrad";
            ph.StellPlaetze[202].Typ = "Motorrad";
            ph.StellPlaetze[203].Typ = "Motorrad";

            // Erzeuge 5 LKW-Stellplätze
            ph.StellPlaetze[299].Typ = "LKW";
            ph.StellPlaetze[300].Typ = "LKW";
            ph.StellPlaetze[301].Typ = "LKW";
            ph.StellPlaetze[302].Typ = "LKW";
            ph.StellPlaetze[303].Typ = "LKW";
        }

        // Speichert die Daten aller Parkhäuser in einer Datei
        private void SpeichernParkhaueser()
        {
            // Speichern der Parkhäuser ist noch nicht implementiert
        }

        // Speichert die Daten aller Fahrzeug in einer Datei
        // Die Daten jedes Fahrzeugs sind in einer Zeile gespeichert
        // Die einzelnen Daten eines Fahrzeuges sind durch das Zeichen ; getrennt
        // z.B "PKW; VW; Käfer; 1965; 9999; K-GS-01; 1; 11; 1000; 30; 1"
        private void SpeichernFahrzeuge()
        {
            // Öffne Datei zum Schreiben der Fahrzeugdaten
            System.IO.StreamWriter file = new System.IO.StreamWriter("Fahrzeuge.txt");

            // Füge die Daten aller Fahrzeuge zum Listview hinzu 
            for (int ii = 0; ii < AnzahlFahrzeuge; ii++)
            {
                // Hole Fahrzeugobjekt aus der Fahrzeugliste
                Fahrzeug fz = FahrzeugGet(ii);

                // Wandle Fahrzeugobjekt in String und speichere diesen als Textzeile in Datei
                file.WriteLine(fz.ToString());
            }

            // Schliesse Datei nachdem alle Daten geschrieben wurden
            file.Close();
        }

        // Lädt die Daten aller Fahrzeuge aus einer Datei
        // Die Daten jedes Fahrzeugs sind in einer Zeile gespeichert
        // Die einzelnen Daten eines Fahrzeuges sind durch das Zeichen ; getrennt
        // Der Fahrzeugtyp ist das erste Datum in der Zeile
        // z.B "PKW; VW; Käfer; 1965; 9999; K-GS-01; 1; 11; 1000; 30; 1"
        private void LadenFahrzeuge()
        {
            string Textzeile;

            // Öffne Textdatei zum Lesen
            // Hier fehlt noch die Fehlerbehandlung, falls Datei nicht geöffnet werden kann
            System.IO.StreamReader file = new System.IO.StreamReader(@"Fahrzeuge.txt"); 

            // Schleife bis alle Textzeilen gelesen wurden
            while ((Textzeile = file.ReadLine()) != null)
            {
                // Zerlege Textzeile und kopiere alle Datenelemente eines Fahrzeugs in ein String-Array
                string[] DatenArray = Textzeile.Split(';');

                // Erstes Datenelement gibt an, dass ein PKW erzeugt werden soll
                if (DatenArray[0].Trim() == "PKW")
                {
                    // Prüfe Datenzeile und erzeuge PKW, wenn Datenzeile OK ist
                    // Die Funktion PKW.ErzeugeFahrzeug gibt ein PKW Objekt zurück, 
                    // wenn die Datenzeile Ok ist, sonst wird null zurückgegeben.
                    Fahrzeug fz = PKW.ErzeugeFahrzeug(Textzeile);
                    if (fz != null)
                    {
                        // Datenzeile war OK und Fahrzeug wurde erzeugt
                        // Füge Fahrzeug zur Fahrzeugliste hinzu
                        Fahrzeuge.Add(fz);
                    }
                }
                // Erstes Datenelement gibt an, dass ein LKW erzeugt werden soll
                else if (DatenArray[0].Trim() == "LKW")
                {
                    // Prüfe Datenzeile und erzeuge LKW, wenn Datenzeile OK ist.
                    // Die Funktion LKW.ErzeugeFahrzeug gibt ein LKW Objekt zurück, 
                    // wenn die Datenzeile Ok ist, sonst wird null zurückgegeben.
                    Fahrzeug fz = LKW.ErzeugeFahrzeug(Textzeile);
                    if (fz != null)
                    {
                        // Datenzeile war OK und Fahrzeug wurde erzeugt
                        // Füge Fahrzeug zur Fahrzeugliste hinzu
                        Fahrzeuge.Add(fz);
                    }
                }
                // Erstes Datenelement gibt an, dass ein Motorrad erzeugt werden soll
                else if (DatenArray[0].Trim() == "Motorrad")
                {
                    // Prüfe Datenzeile und erzeuge Motorrad, wenn Datenzeile OK ist.
                    // Die Funktion Motorad.ErzeugeFahrzeug gibt ein Motorad Objekt zurück, 
                    // wenn die Datenzeile Ok ist, sonst wird null zurückgegeben.
                    Fahrzeug fz = Motorrad.ErzeugeFahrzeug(Textzeile);
                    if (fz != null)
                    {
                        // Datenzeile war OK und Fahrzeug wurde erzeugt
                        // Füge Fahrzeug zur Fahrzeugliste hinzu
                        Fahrzeuge.Add(fz);
                    }
                }
                else
                {
                    // Unbekannter Fahrzeugtyp. Die Textzeile wird ignoriert
                }
            }

            // Schliesse Datei nachdem alle Daten gelesen wurden
            file.Close();
        }

        // Lädt alle Daten (Fahrzeuge und Parkhäuser)
        public void Laden()
        {
            LadenParkhaueser();
            LadenFahrzeuge();
            StellplaetzeZuordnen();
        }

        // Speichert alle Daten (Fahrzeuge und Parkhäuser)
        public void Speichern()
        {
            SpeichernParkhaueser();
            SpeichernFahrzeuge();
        }

        // Trägt das Kennzeichen jedes Fahrzeugs, das einen Stellplatzeintag besitzt, 
        // in den jeweiligen Stellplatz des jeweiligen Parkhauses ein.
        // Die Funktion muss nach folgenden Aktionen aufgerufen werden:
        //    - nach dem Laden der Parkhäuser und Fahrzeuge
        //    - nach dem Löschen eines Fahrzeuges
        //    - nach dem Hinzufügen eines Fahrzeuges
        //    - nach der Zuweisung eines Stellplatzes zu einem Parkhaus
        //    - nach dem Löschen eines Parkhauses
        private void StellplaetzeZuordnen()
        {
            // Alle Zuweisungen in allen Parkhäusern löschen
            for (int iParkhaus = 0; iParkhaus < AnzahlParkhaeuser; iParkhaus++)
            {
                Parkhaus ph = Parkhaeuser[iParkhaus];

                // Lösche alle Kennzeichen aus allen Stellplätzen
                for (int iStellplatz = 0; iStellplatz < ph.AnzahlStellplaetze; iStellplatz++)
                {
                    ph.StellPlaetze[iStellplatz].Kennzeichen = "";
                }
            }

            // Suche für alle Fahrzeuge den Stellplatz
            for (int iFahrzeug = 0; iFahrzeug < AnzahlFahrzeuge; iFahrzeug++)
            {
                Fahrzeug fz = Fahrzeuge[iFahrzeug];

                int ZugeordnetesParkhaus = fz.ParkhausNummer;
                int ZugeordneterStellplatz = fz.StellplatzNummer;

                if ((ZugeordnetesParkhaus > 0) && (ZugeordneterStellplatz > 0))
                {
                    // Wird auf true gesetzt, wenn Stellplatz gefunden wurde
                    bool StellplatzGefunden = false;

                    // Suche zugeordnetes Parkhause
                    for (int iParkhaus = 0; (iParkhaus < AnzahlParkhaeuser) && (StellplatzGefunden == false); iParkhaus++)
                    {
                        Parkhaus ph = Parkhaeuser[iParkhaus];
                        if (ph.ParkhausNummer == ZugeordnetesParkhaus)
                        {
                            // Suche zugeordneten Stellplatz
                            for (int iStellplatz = 0; (iStellplatz < ph.AnzahlStellplaetze) && (StellplatzGefunden == false); iStellplatz++)
                            {
                                Stellplatz sp = ph.StellPlaetze[iStellplatz];
                                // Zuweisung wenn 
                                //   - Stellplatznummer übereinstimmt und
                                //   - Stellplatztyp mit FAhrzeugtyp übereinstimmt und
                                //   - Stellplatz frei ist
                                if ((ZugeordneterStellplatz == sp.Nummer) && 
                                    (sp.Typ == fz.Typ) &&
                                    (sp.Kennzeichen.Length == 0))
                                {
                                    sp.Kennzeichen = fz.Kennzeichen;
                                    StellplatzGefunden = true;
                                }
                            }
                        }
                    }
                    // Lösche Stellplatzzuordnung im Fahrzeug, 
                    //  - wenn der Stellplatz nicht gefunden wurde oder 
                    //  - wenn der Stellplatz nicht frei ist
                    if (StellplatzGefunden == false)
                    {
                        fz.ParkhausNummer = 0;
                        fz.StellplatzNummer = 0;
                    }
                }
            }
        }
    }
}
