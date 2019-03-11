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

        // Gibt Anzahl der Parkhäuser zurück
        public int AnzahlParkhaeuser
        {
            get
            {
                return Parkhaeuser.Count;
            }
        }

        // Gibt Anzahl der Fahrzeuge zurück
        public int AnzahlFahrzeuge
        {
            get
            {
                return Fahrzeuge.Count;
            }
        }

        // Fügt ein Parkhaus hinzu
        public void ParkhausHinzufuegen(Parkhaus value)
        {
            Parkhaeuser.Add(value);
        }

        // Fügt ein Fahrzeug hinzu
        public void FahrzeugHinzufuegen(Fahrzeug value)
        {
            Fahrzeuge.Add(value);
        }
        
        // Löscht das Parkhaus mit der Nummer id
        public void ParkhausLoeschen(int id)
        {
            if ((id >= 0) && (id <= AnzahlParkhaeuser))
            {
                Parkhaeuser.RemoveAt(id);
            }
        }

        // Löscht das Fahrzeug mit der Nummer id
        public void FahrzeugLoeschen(int id)
        {
            if ((id >= 0) && (id <= AnzahlFahrzeuge))
            {
                Fahrzeuge.RemoveAt(id);
            }
        }

        // Gibt das Parkhaus mit der Nummer id zurück
        public Parkhaus ParkhausGet(int id)
        {
            return Parkhaeuser[id];
        }

        // Gibt das Fahrzeug mit der Nummer id zurück
        public Fahrzeug FahrzeugGet(int id)
        {
            return Fahrzeuge[id];
        }

        // Lädt die Daten aller Parkhäuser aus einer Datei
        public void LadeParkhaueser()
        {
            Parkhaeuser.Add(new Parkhaus(40, "51105", "Köln", "Westerwaldstr. 99"));
        }

        // Lädt die Daten aller Fahrzeuge aus einer Datei
        public void LadeFahrzeuge()
        {
            Fahrzeuge.Add(new PKW("VW", "Käfer", 1965, 9999, "K-GS-01", 1000, 30, 1));
            Fahrzeuge.Add(new PKW("Opel", "Kadett", 1964, 12000, "K-GS-02", 1600, 60, 2));
            Fahrzeuge.Add(new LKW("Mercedes", "LG 315", 1960, 23000, "K-GS-04", 2, 5.5f));
            Fahrzeuge.Add(new Motorrad("BMW", "R1200R", 1999, 6000, "K-GS-03", 1170));
        }

        // Lädt alle Daten (Fahrzeuge und Parkhäuser)
        public void Load()
        {
            LadeParkhaueser();
            LadeFahrzeuge();
        }
    }
}
