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
        // Adresse Parkhaus
        public string Ort { get; }
        public string PLZ { get; }
        public string Strasse { get; }

        // Anzahl der Stellplaetze
        public int AnzahlStellplaetze { get; }
        
        // Array mit Stellplatzobjekten
        public Stellplatz[] StellPlaetze { get; }

        // Konstruktor
        public Parkhaus(int pAnzahlStellplaetze, string pPLZ, string pOrt, string pStrasse)
        {
            Ort = pOrt;
            PLZ = pPLZ;
            Strasse = pStrasse;

            AnzahlStellplaetze = pAnzahlStellplaetze;
            
            // Array mit Stellplaetzen erzeugen
            StellPlaetze = new Stellplatz[AnzahlStellplaetze];
            for (int idx = 0; idx < AnzahlStellplaetze; idx++)
            {
                StellPlaetze[idx] = new Stellplatz(idx + 1);
            }
        }

        // Gibt die Anzahl der Stellpätze eines Typs (PKW, LKW, Motorrad) zurück
        public int AnzahlStellplaetze_Typ(string typ)
        {
            int count = 0;
            for (int idx = 0; idx < AnzahlStellplaetze; idx++)
            {
                if (StellPlaetze[idx].Typ == typ)
                {
                    count++;
                }
            }
            return count;
        }

        // Gibt die Anzahl der belegten PKW, LKW oder Motorrad Stellpätze zurück
        public int AnzahlStellplaetze_Belegt_Typ(string typ)
        {
            int count = 0;
            for (int idx = 0; idx < AnzahlStellplaetze; idx++)
            {
                if ((StellPlaetze[idx].Typ == typ) && (StellPlaetze[idx].FreierStellplatz() == false))
                {
                    count++;
                }
            }
            return count;
        }
    }

}
