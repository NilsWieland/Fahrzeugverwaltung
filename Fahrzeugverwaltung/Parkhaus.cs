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

        // Prüfe und kopiere Ort
        public static bool TextToOrt(string Text, out string Ort)
        {
            bool DatenOk = true;

            // Entferne Leerzeichen am Anfang und am Ende
            Text = Text.Trim();

            // Prüfe Textlänge
            if ((Text.Length > 1) && (Text.Length < 100))
            {
                // Textlänge ist OK
                Ort = Text;
            }
            else
            {
                // Daten sind nicht OK
                DatenOk = false;
                Ort = "";
            }
            return DatenOk;
        }

        // Prüfe und kopiere Strasse
        public static bool TextToStrasse(string Text, out string Strasse)
        {
            bool DatenOk = true;

            // Entferne Leerzeichen am Anfang und am Ende
            Text = Text.Trim();

            // Prüfe Textlänge
            if ((Text.Length > 1) && (Text.Length < 100))
            {
                // Textlänge ist OK
                Strasse = Text;
            }
            else
            {
                // Daten sind nicht OK
                DatenOk = false;
                Strasse = "";
            }
            return DatenOk;
        }

        // Prüfe und kopiere PLZ
        public static bool TextToPLZ(string Text, out string PLZ)
        {
            bool DatenOk = true;

            // Entferne Leerzeichen am Anfang und am Ende
            Text = Text.Trim();

            // Prüfe Textlänge
            if ((Text.Length > 4) && (Text.Length < 10))
            {
                // Textlänge ist OK
                PLZ = Text;
            }
            else
            {
                // Daten sind nicht OK
                DatenOk = false;
                PLZ = "";
            }
            return DatenOk;

        }

        // Prüfe und kopiere Anzahl der Stellplätze
        public static bool TextToAnzahlStellplaetze(string Text, out int AnzahlStellplaetze)
        {
            // PLZ muss zwischen 10000 und 99999 liegen
            return PruefeInteger(Text, 1, 1000, out AnzahlStellplaetze);
        }

        // Wandelt String in int-Wert um und prüft Wertebereich.
        // Die Funktion gibt true zurück, wenn der Wert OK ist, sonst false.
        static public bool PruefeInteger(string InputString, int Untergrenze, int Obergrenze, out int Wert)
        {
            bool DatenOk = Int32.TryParse(InputString, out Wert);
            if ((DatenOk == false) || (Wert < Untergrenze) || (Wert > Obergrenze))
            {
                DatenOk = false;
            }
            return DatenOk;
        }

    }
}
