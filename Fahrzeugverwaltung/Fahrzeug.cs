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

        // Konstruktor der Elternklasse
        // Wird nur von den Konstruktoren der abgeleiteten Klassen aufgerufen
        protected Fahrzeug(string pHersteller, string pModell, int pErstzulassung, float pAnschaffungspreis, string pKennzeichen)
        {
            Hersteller = pHersteller;
            Modell = pModell;
            Erstzulassung = pErstzulassung;
            Anschaffungspreis = pAnschaffungspreis;
            Kennzeichen = pKennzeichen;
        }

        // Prüft und kopiert die gemeinsamen Daten aller Fahrzeugtypen aus einem String in einzelnen Datenelemente
        // Funktion ist protected weil sie nur von den abgeleiteten Klassen verwendet wird
        protected static bool PruefeDaten(
            string Daten, 
            out string Hersteller, 
            out string Modell, 
            out int Erstzulassung, 
            out float Anschaffungspreis, 
            out string Kennzeichen)
        {
            bool DatenOk = true;
            Hersteller = "";
            Modell = "";
            Erstzulassung = 0;
            Anschaffungspreis = 0;
            Kennzeichen = "";

            // Kopieren der durch ; getrennten Datenelement aus einer Textzeile in ein Array
            string[] DataArray = Daten.Split(';');

            // Prüfe und kopiere Hersteller
            if (DatenOk)
            {
                // Fast beliebige Länge größer 1
                if ((DataArray[1].Length > 1) && (DataArray[1].Length < 100))
                { 
                    Hersteller = DataArray[1];
                }
                else
                {
                    // Daten sind nicht OK
                    DatenOk = false;
                }
            }

            // Prüfe und kopiere Modell
            if (DatenOk)
            {
                // Fast beliebige Länge größer 1
                if ((DataArray[2].Length > 1) && (DataArray[2].Length < 100))
                {
                    Modell = DataArray[2];
                }
                else
                {
                    // Daten sind nicht OK
                    DatenOk = false;
                }
            }

            // Prüfe und kopiere Jahr der Erstzulassung
            if (DatenOk)
            {
                // Jahr der Erstzulassung muss zwischen 1900 und 2100 liegen
                DatenOk = PruefeInteger(DataArray[3], 1900, 2100, out Erstzulassung);
            }

            // Prüfe und kopiere Anschaffungspreis
            if (DatenOk)
            {
                // Annschaffungspreiss soll zwischen 0 (geschenkt) und € 1000000.-
                DatenOk = PruefeFloat(DataArray[4], 0, 1000000, out Anschaffungspreis);
            }

            // Prüfe und kopiere Kennzeichen
            if (DatenOk)
            {
                // Kenzeichen muss länger all "X-X-X" (5) und kürzer als "XXX-XX-XXXX" (11) sein
                if ((DataArray[5].Length >= 5) && (DataArray[5].Length <= 11))
                {
                    Kennzeichen = DataArray[5];
                }
                else
                {
                    // Daten sind nicht OK
                    DatenOk = false;
                }
            }

            // Gibt true zurück, wenn Datenprüfung OK, sonst false
            return DatenOk;
        }

        // Wandelt String in int-Wert um und prüft Wertebereich.
        // Die Funktion gibt true zurück, wenn der Wert OK ist, sonst false.
        // Funktion ist protected weil sie nur von den abgeleiteten Klassen verwendet wird
        static protected bool PruefeInteger(string InputString, int Untergrenze, int Obergrenze, out int Wert)
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
        // Funktion ist protected weil sie nur von den abgeleiteten Klassen verwendet wird
        static protected bool PruefeFloat(string InputString, float Untergrenze, float Obergrenze, out float Wert)
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
