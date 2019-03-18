using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrzeugverwaltung
{
    public class LKW : Fahrzeug
    {
        // Typ ist immer LKW
        public override string Typ
        {
            get
            {
                return "LKW";
            }
        }

        public override float Steuer
        {
            get
            {
                // Zuladung * 100
                return Zuladung * 100;
            }
        }

        // Anzahl der Achsen
        public int AnzahlAchsen { get; }

        // Zuladung in Tonnen
        public float Zuladung { get; }

        // Konstruktor
        // Ruft Konstruktor der Basisklasse auf
        public LKW(string pHersteller, string pModell, int pJahrErstzulassung, float pAnschaffungspreis, string pKennzeichen, int pAnzahlAchsen, float pZuladung) :
               base(pHersteller, pModell, pJahrErstzulassung, pAnschaffungspreis, pKennzeichen)
        {
            AnzahlAchsen = pAnzahlAchsen;
            Zuladung = pZuladung;
        }
        // Erzeugt ein LKW Objekt aus einer Datenzeile. 
        // Die Datenzeile wird geprüft. 
        // Sind die Daten OK wird ein LKW Objekt erzeugt und zurückgegeben.
        // Sind die Daten nicht OK wird kein LKW Objekt erzeugt und es wird null zurückgegeben.
        // Jede Datenzeile muss folgendermassen aufgebaut sein
        // <Fahrzeugtyp>;<Fahrzeugmodell>;<Jahr der Erstzulassung>;<Anschaffungspreis>;<Kennzeichen>;<AnzahlAchsen>;<Zuladung>
        // Beispiel: LKW; Mercedes; LG 315; 1960; 23000; K-GS-04; 2; 5,5
        public static LKW ErzeugeFahrzeug(
            string Datenzeile)
        {
            string Hersteller;
            string Modell;
            int Erstzulassung;
            float Anschaffungspreis;
            string Kennzeichen;
            int AnzahlAchsen = 0;
            float Zuladung = 0;

            string[] DataArray = Datenzeile.Split(';');

            // Prüfe, die für alle Fahrzeuge gemeinsamen Daten, durch Funktion der Elternklasse 
            bool DatenOk = Fahrzeug.PruefeDaten(Datenzeile, out Hersteller, out Modell, out Erstzulassung, out Anschaffungspreis, out Kennzeichen);

            // Prüfen der LKW Daten, wenn gemeinsame Daten OK sind
            if (DatenOk)
            {
                // Erstes Datenelement muss LKW sein
                if (DataArray[0] != "LKW")
                {
                    DatenOk = false;
                }
            }

             // Wandle String in int-Wert für Schadstoffklasse (0 - 2)
            if (DatenOk)
            {
                DatenOk = PruefeInteger(DataArray[6], 2, 16, out AnzahlAchsen);
            }

            // Wandle String in int-Wert für ZUöadung (0 - 50)
            if (DatenOk)
            {
                DatenOk = PruefeFloat(DataArray[7], 1, 50, out Zuladung);
            }

            // Erzeuge PKW Objekt, wenn die Daten OK sind. Sonst wird null zurückgegeben.
            if (DatenOk)
                return new LKW(Hersteller, Modell, Erstzulassung, Anschaffungspreis, Kennzeichen, AnzahlAchsen, Zuladung);
            else
                return null;
        }
    }
}
