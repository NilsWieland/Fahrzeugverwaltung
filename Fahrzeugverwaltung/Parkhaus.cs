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

        // Gibt einen String zurück, der alle Daten des Parkhaus-Objektes in einer Textzeile enthält. 
        // Die einzelnen Datenelemente sind durch das Zeichen ";" voneinander getrennt
        public override String ToString()
        {
            string ParkhausDaten = ParkhausNummer + ";" + Ort + ";" + PLZ + ";" + Strasse;

            for (int index = 0; index < AnzahlStellplaetze; index++)
            {
                if (StellPlaetze[index].Typ == "LKW")
                {
                    ParkhausDaten += ";L";
                }
                else if (StellPlaetze[index].Typ == "Motorrad")
                {
                    ParkhausDaten += ";M";
                }
                else
                {
                    ParkhausDaten += ";P";
                }
            }

            return ParkhausDaten;
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

        // Prüfe und kopiere Parkhausnummer
        public static bool TextToParkhausnummer(string Text, out int Parkhausnummer)
        {
            // Parkhausnummer muss zwischen 1 und 100 liegen
            return PruefeInteger(Text, 1, 100, out Parkhausnummer);
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

        // Erzeugt ein Parkhaus Objekt aus einer Datenzeile. 
        // Die Datenzeile wird geprüft. 
        // Sind die Daten OK wird ein Parkhausobjekt erzeugt und zurückgegeben.
        // Sind die Daten nicht OK wird kein Parkhausobjekt erzeugt und es wird null zurückgegeben.
        // Jede Datenzeile muss folgendermassen aufgebaut sein
        // <Parkhausnummer>;<Ort>;<PLZ>;<Strasse>;<Typ Stellplatz 1>;<Typ Stellplatz 2>; .... <Typ Stellplatz N>
        // Beispiel: 1;Köln;51105;Westerwaldstr. 99;P;P;P;P;P;P;P
        public static Parkhaus ErzeugeParkhaus(
            string Datenzeile)
        {
            Parkhaus ph = null;

            int Parkhausnummer = 0;
            string Ort = "";
            string PLZ = "";
            string Strasse = "";
            int AnzahlStellplaetze = 0;

            bool DatenOk = true;

            string[] DataArray = Datenzeile.Split(';');

            // 4 Datenelemente (Nummer, Ort, PLZ, Strasse), dann nur noch Stellplatztypen
            AnzahlStellplaetze = DataArray.Length - 4;

            // Prüfe und kopiere Parkhausnummer
            if (DatenOk)
            {
                DatenOk = TextToParkhausnummer(DataArray[0], out Parkhausnummer);
            }

            // Prüfe und kopiere Ort
            if (DatenOk)
            {
                DatenOk = TextToOrt(DataArray[1], out Ort);
            }

            // Prüfe und kopiere PLZ
            if (DatenOk)
            {
                DatenOk = TextToPLZ(DataArray[2], out PLZ);
            }

            // Prüfe und kopiere Strasse
            if (DatenOk)
            {
                DatenOk = TextToStrasse(DataArray[3], out Strasse);
            }

            if (DatenOk)
            {
                // Erzeuge Parkhaus mit Stellplätzen
                ph = new Parkhaus(Parkhausnummer, AnzahlStellplaetze, PLZ, Ort, Strasse);

                // Setze Stellplatztyp für alle Stellplätze
                // In der Datenzeile steht 
                //   L für LKW
                //   M für Motorrad
                //   alle anderen Werte für PKW
                for (int iStellplatz = 0; iStellplatz < ph.AnzahlStellplaetze; iStellplatz++)
                {
                    Stellplatz sp = ph.StellPlaetze[iStellplatz];
                    if (DataArray[4 + iStellplatz] == "L")
                    {
                        ph.StellPlaetze[iStellplatz].Typ = "LKW";
                    }
                    else if (DataArray[4 + iStellplatz] == "M")
                    {
                        ph.StellPlaetze[iStellplatz].Typ = "Motorrad";
                    }
                    else
                    {
                        ph.StellPlaetze[iStellplatz].Typ = "PKW";
                    }
                }
            }

            return ph;
        }

    }
}
