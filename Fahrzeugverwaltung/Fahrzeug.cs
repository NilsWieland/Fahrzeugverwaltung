using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrzeugverwaltung
{
    public abstract class Fahrzeug
    {
        // Typ des Fahrzeugs (PKW, LKW, Motorrad)
        public virtual string Typ { get; }

        // Hersteller (VW, Ford, ...)
        public string Hersteller { get; }

        // Modell (Golf, Passat, ...)
        public string Modell { get; }

        // Jahr der Erstzulassung
        public int Erstzulassung { get; }

        // Anschaffungspreis 
        public float Anschaffungspreis { get; }

        // Fahrzeugkennzeichen
        public string Kennzeichen { get; }

        // Parkhausnummer 
        // 1 .... Anzahl Parkhäuer
        // 0 kein Parkhaus zugewiesen
        public int ParkhausNummer { get; set; }

        // Stellplatznummer 
        // 1 .... Anzahl Stellplätze 
        // 0 kein Stellplatz zugewiesen
        public int StellplatzNummer { get; set; }

        // Konstruktor der Elternklasse
        // Wird nur von den Konstruktoren der abgeleiteten Klassen aufgerufen
        protected Fahrzeug(
            string pHersteller, 
            string pModell, 
            int pErstzulassung, 
            float pAnschaffungspreis, 
            string pKennzeichen,
            int pParkhausNummer,
            int pStellplatzNummer)
        {
            Hersteller = pHersteller;
            Modell = pModell;
            Erstzulassung = pErstzulassung;
            Anschaffungspreis = pAnschaffungspreis;
            Kennzeichen = pKennzeichen;
            ParkhausNummer = pParkhausNummer;
            StellplatzNummer = pStellplatzNummer;
        }

        // Gibt einen String zurück, der alle Daten des Fahreug Objektes in einer Textzeile enthält. 
        // Die einzelnen Datenelemente sind durch das Zeichen ";" coneinander getrennt
        public override String ToString()
        {
            return
                Typ + "; " +
                Hersteller + "; " +
                Modell + "; " +
                Erstzulassung.ToString() + "; " +
                Anschaffungspreis.ToString() + "; " +
                Kennzeichen + "; " +
                ParkhausNummer.ToString() + "; " +
                StellplatzNummer.ToString();
        }

        // Prüfe und kopiere Hersteller
        public static bool TextToHersteller(string Text, out string Hersteller)
        {
            bool DatenOk = true;

            // Entferne Leerzeichen
            Text = Text.Trim();

            // Prüfe Textlänge
            if ((Text.Length > 1) && (Text.Length < 100))
            {
                // Textlänge ist OK
                Hersteller = Text;
            }
            else
            {
                // Daten sind nicht OK
                DatenOk = false;
                Hersteller = "";
            }
            return DatenOk;
        }

        // Prüfe und kopiere Modell
        public static bool TextToModell(string Text, out string Modell)
        {
            bool DatenOk = true;
            
            // Entferne Leerzeichen
            Text = Text.Trim();

            // Prüfe Textlänge
            if ((Text.Length > 1) && (Text.Length < 100))
            {
                // Textlänge ist OK
                Modell = Text;
            }
            else
            {
                // Daten sind nicht OK
                DatenOk = false;
                Modell = "";
            }
            return DatenOk;
        }

        // Prüfe und kopiere Erstzulassung
        public static bool TextToErstzulassung(string Text, out int Erstzulassung)
        {
            return PruefeInteger(Text, 1900, 2100, out Erstzulassung);
        }

        // Prüfe und kopiere Anschaffungspreis
        public static bool TextToAnschaffungspreis(string Text, out float Anschaffungspreis)
        {
            // Annschaffungspreiss soll zwischen 0 (geschenkt) und € 1000000.-
            return PruefeFloat(Text, 0, 1000000, out Anschaffungspreis);
        }

        // Prüfe und kopiere Kennzeichen
        // Prüfe und kopiere Modell
        public static bool TextToKennzeichen(string Text, out string Kennzeichen)
        {
            bool DatenOk = true;

            // Entferne Leerzeichen
            Text = Text.Trim();

            // Kenzeichen muss länger all "X-X-X" (5) und kürzer als "XXX-XX-XXXX" (11) sein
            if ((Text.Length >= 5) && (Text.Length <= 11))
            {
                Kennzeichen = Text;
            }
            else
            {
                // Daten sind nicht OK
                DatenOk = false;
                Kennzeichen = "";
            }
            return DatenOk;
        }

        // Prüfe und kopiere Parkhausnummer
        public static bool TextToParkhausNummer(string Text, out int ParkhausNummer)
        {
            // ParkhausNummer muss 0 (kein Parkhaus zugewiesen) oder zwichen 1 bis 100 liegen (100 Parkhäuser maximal)
            return PruefeInteger(Text, 0, 100, out ParkhausNummer);
        }

        // Prüfe und kopiere Stellplatznummer
        public static bool TextToStellplatzNummer(string Text, out int StellplatzNummer)
        {
            // StellplatzNummer muss 0 (kein Stellplatz zugewiesen) oder zwichen 1 bis 100 liegen (1000 Stellplätze maximal)
            return PruefeInteger(Text, 0, 1000, out StellplatzNummer);
        }

        // Prüft und kopiert die gemeinsamen Daten aller Fahrzeugtypen aus einem String in einzelnen Datenelemente
        // Funktion ist protected weil sie nur von den abgeleiteten Klassen verwendet wird
        protected static bool TextToFahrzeugDaten(
            string TextZeile, 
            out string Hersteller, 
            out string Modell, 
            out int Erstzulassung, 
            out float Anschaffungspreis, 
            out string Kennzeichen,
            out int ParkhausNummer,
            out int StellplatzNummer)
        {
            bool DatenOk = true;
            Hersteller = "";
            Modell = "";
            Erstzulassung = 0;
            Anschaffungspreis = 0;
            Kennzeichen = "";
            ParkhausNummer = 0;
            StellplatzNummer = 0;

            // Kopieren der durch ; getrennten Datenelement aus einer Textzeile in ein Array
            string[] DataArray = TextZeile.Split(';');

            // Prüfe und kopiere Hersteller
            if (DatenOk)
            {
                DatenOk = TextToHersteller(DataArray[1], out Hersteller);
            }

            // Prüfe und kopiere Modell
            if (DatenOk)
            {
                DatenOk = TextToModell(DataArray[2], out Modell);
            }

            // Prüfe und kopiere Jahr der Erstzulassung
            if (DatenOk)
            {
                DatenOk = TextToErstzulassung(DataArray[3], out Erstzulassung);
            }

            // Prüfe und kopiere Anschaffungspreis
            if (DatenOk)
            {
                DatenOk = TextToAnschaffungspreis(DataArray[4], out Anschaffungspreis);
            }

            // Prüfe und kopiere Kennzeichen
            if (DatenOk)
            {
                DatenOk = TextToKennzeichen(DataArray[5], out Kennzeichen);
            }

            // Prüfe und kopiere ParkhausNummer
            if (DatenOk)
            {
                DatenOk = TextToParkhausNummer(DataArray[6], out ParkhausNummer);
            }

            // Prüfe und kopiere StellplatzNummer
            if (DatenOk)
            {
                DatenOk = TextToStellplatzNummer(DataArray[7], out StellplatzNummer);
            }

            // Gibt true zurück, wenn Datenprüfung OK, sonst false
            return DatenOk;
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

        // Wandelt String in float-Wert um und prüft Wertebereich.
        // Die Funktion gibt true zurück, wenn der Wert OK ist, sonst false.
        static public bool PruefeFloat(string InputString, float Untergrenze, float Obergrenze, out float Wert)
        {
            bool DatenOk = float.TryParse(InputString, out Wert);
            if ((DatenOk == false) || (Wert < Untergrenze) || (Wert > Obergrenze))
            {
                DatenOk = false;
            }
            return DatenOk;
        }

        // KFZ Steuerberechnung. 
        // Die Funktion ist in den abgeleiteten Klassen (PKW, LKW, Motorrad) realisiert
        public virtual float Steuer { get; }
    }
}
