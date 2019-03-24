using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrzeugverwaltung
{
    // Klasse Parkhaus
    public class Parkhaus
    {
        // Parkhausnummer
        public int ParkhausNummer { get; }

        // Adresse Parkhaus
        public string Ort { get; }
        public string PLZ { get; }
        public string Strasse { get; }

        // Anzahl der Stellplaetze
        public int AnzahlStellplaetze { get; }
        
        // Array mit Stellplatzobjekten
        public Stellplatz[] StellPlaetze { get; }

        // Konstruktor
        public Parkhaus(int pParkhausNummer, int pAnzahlStellplaetze, string pPLZ, string pOrt, string pStrasse)
        {
            ParkhausNummer = pParkhausNummer;

            // Addresse des Parkhauses abspeichern
            Ort = pOrt;
            PLZ = pPLZ;
            Strasse = pStrasse;

            // Anzahl der Stellplätze des Parkhauses abspeichern
            AnzahlStellplaetze = pAnzahlStellplaetze;
            
            // Array für Stellplatzobjekte erzeugen
            StellPlaetze = new Stellplatz[AnzahlStellplaetze];
            
            // Erzeuge Stellplatzobjekte und speichere sie im Array
            for (int index = 0; index < AnzahlStellplaetze; index++)
            {
                StellPlaetze[index] = new Stellplatz(index + 1);
            }
        }

        // Gibt die Anzahl der Stellpätze eines Typs (PKW, LKW, Motorrad) zurück
        public int AnzahlStellplaetze_Typ(string typ)
        {
            int StellplatzZaehler = 0;

            // Schleife über alle Stellplätze
            for (int index = 0; index < AnzahlStellplaetze; index++)
            {
                // Erhöhe den Zähler wenn der Stellplatz vom übergebenen Typ ist
                if (StellPlaetze[index].Typ == typ)
                {
                    StellplatzZaehler++;
                }
            }
            return StellplatzZaehler;
        }

        // Gibt die Anzahl der belegten PKW, LKW oder Motorrad Stellpätze zurück
        public int AnzahlStellplaetze_Belegt_Typ(string typ)
        {
            int StellplatzZaehler = 0;
            
            // Schleife über alle Stellplätze
            for (int index = 0; index < AnzahlStellplaetze; index++)
            {
                // Erhöhe den Zähler wenn der Stellplatz vom übergebenen Typ ist und wenn der Stellplatz belegt
                if ((StellPlaetze[index].Typ == typ) && (StellPlaetze[index].FreierStellplatz() == false))
                {
                    StellplatzZaehler++;
                }
            }
            return StellplatzZaehler;
        }
    }
}
