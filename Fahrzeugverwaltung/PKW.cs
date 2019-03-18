using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrzeugverwaltung
{
    public class PKW : Fahrzeug
    {
        // Typ ist immer PKW
        public override string Typ
        {
            get
            {
                return "PKW";
            }
        }

        // Steuer für PKW berechnen
        public override float Steuer
        {
            get
            {
                // (Hubraum + 99) / 100 * 10 Euro * (Schadstoffklasse+1)
                return ((Hubraum + 99) / 100) * (10 * (Schadstoffklasse + 1));
            }
        }

        // Hubraum in Kubikcentimeter
        public int Hubraum { get; }

        // Leistung in kW
        public int Leistung { get; }

        // Schadstoffklasse (0-schadstoffarm, 1-normal, 2-Diesel)
        public int Schadstoffklasse { get; }

        // Konstruktor
        // Ruft Konstruktor der Elternklasse auf
        public PKW(string pHersteller, string pModell, int pJahrErstzulassung, float pAnschaffungspreis, string pKennzeichen, int pHubraum, int pLeistung, int pSchadstoffklasse) :
               base(pHersteller, pModell, pJahrErstzulassung, pAnschaffungspreis, pKennzeichen)
        {
            Hubraum = pHubraum;
            Leistung = pLeistung;
            Schadstoffklasse = pSchadstoffklasse;
        }

        // Erzeugt ein PKW Objekt aus einer Datenzeile. 
        // Die Datenzeile wird geprüft. 
        // Sind die Daten OK wird ein PKW Objekt erzeugt und zurückgegeben.
        // Sind die Daten nicht OK wird kein PKW Objekt erzeugt und es wird null zurückgegeben.
        // Jede Datenzeile muss folgendermassen aufgebaut sein
        // <Fahrzeugtyp>;<Fahrzeugmodell>;<Jahr der Erstzulassung>;<Anschaffungspreis>;<Kennzeichen>;<Hubraum>;<Leistung>;<Schadstoffklasse>
        // Beispiel: PKW; VW; Käfer; 1965; 9999; K-GS-01; 1000; 30; 1
        public static PKW ErzeugeFahrzeug(
            string Datenzeile)
        {
            string Hersteller;
            string Modell;
            int Erstzulassung;
            float Anschaffungspreis;
            string Kennzeichen;
            int Hubraum = 0;
            int Leistung = 0;
            int Schadstoffklasse = 0;

            // Prüfe, die für alle Fahrzeuge gemeinsamen Daten, durch Funktion der Elternklasse 
            bool DatenOk = Fahrzeug.PruefeDaten(Datenzeile, out Hersteller, out Modell, out Erstzulassung, out Anschaffungspreis, out Kennzeichen);

            // Prüfen der PKW Daten, wenn gemeinsame Daten OK sind
            if (DatenOk)
            {
                // Kopieren der durch ; getrennten Datenelement aus einer Textzeile in ein Array
                string[] DataArray = Datenzeile.Split(';');

                // Erstes Datenelement muss PKW sein
                if (DataArray[0] != "PKW")
                {
                    DatenOk = false;
                }

                // Wandle String in int um für Hubraum (50 ccm - 10000 ccm)
                if (DatenOk)
                {
                    DatenOk = PruefeInteger(DataArray[6], 50, 10000, out Hubraum);
                }

                // Wandle String in int-Wert für Leistung (1 KW - 1000 KW)
                if (DatenOk)
                {
                    DatenOk = PruefeInteger(DataArray[7], 1, 1000, out Leistung);
                }

                // Wandle String in int-Wert für Schadstoffklasse (0 - 2)
                if (DatenOk)
                {
                    DatenOk = PruefeInteger(DataArray[8], 0, 2, out Schadstoffklasse);
                }
            }

            // Erzeuge PKW Objekt, wenn die Daten OK sind. Sonst wird null zurückgegeben.
            if (DatenOk)
                return new PKW(Hersteller, Modell, Erstzulassung, Anschaffungspreis, Kennzeichen, Hubraum, Leistung, Schadstoffklasse);
            else
                return null;
        }
    }
}
