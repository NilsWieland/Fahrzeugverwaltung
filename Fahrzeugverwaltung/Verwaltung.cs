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
        }
        
        // Löscht das Parkhaus mit der Nummer id
        public void ParkhausLoeschen(int id)
        {
            // Parkhaus nur dann löschen wenn der Index kleiner als die Anzahl der Parkhäuser ist
            if ((id >= 0) && (id < AnzahlParkhaeuser))
            {
                Parkhaeuser.RemoveAt(id);
            }
        }

        // Löscht das Fahrzeug mit der Nummer id
        public void FahrzeugLoeschen(int id)
        {
            // Fahrzeug nur dann löschen wenn der Index kleiner als die Anzahl der Fahrzeuge ist
            if ((id >= 0) && (id < AnzahlFahrzeuge))
            {
                Fahrzeuge.RemoveAt(id);
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
        private void LadeParkhaueser()
        {
            // Laden der Parkhäuser aus einer Datei ist noch nicht implementiert.
            // Parkhaus wird einfach erzeugt und zur Liste hinzugefügt.
            Parkhaeuser.Add(new Parkhaus(40, "51105", "Köln", "Westerwaldstr. 99"));
        }

        // Lädt die Daten aller Fahrzeuge aus einer Datei
        private void LadeFahrzeuge()
        {
            string Textzeile;

            // Lese Textdatei und erzeuge Fahrzeugobjekte 
            // Die Daten jedes Fahrzeugs sind in einer Zeile gespeichert
            // Die einzelnen Daten eines Fahrzeuges sind durch das Zeichen ; getrennt
            // Der Fahrzeugtyp ist das erste Datum in der Zeile
            // z.B "PKW; VW; Käfer; 1965; 9999; K-GS-01; 1000; 30; 1"
            System.IO.StreamReader file = new System.IO.StreamReader(@"Fahrzeuge.txt");

            // Schleife bis alle Textzeilen gelesen wurden
            while ((Textzeile = file.ReadLine()) != null)
            {
                // Zerlege Textzeile und kopiere alle Datenelemente eines Fahrzeugs in ein String-Array
                string[] DatenArray = Textzeile.Split(';');

                // Erstes Datenelement gibt an, dass ein PKW erzeugt werden soll
                if (DatenArray[0] == "PKW")
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
                else if (DatenArray[0] == "LKW")
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
                else if (DatenArray[0] == "Motorrad")
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

            file.Close();
        }

        // Lädt alle Daten (Fahrzeuge und Parkhäuser)
        public void Laden()
        {
            LadeParkhaueser();
            LadeFahrzeuge();
        }
    }
}
