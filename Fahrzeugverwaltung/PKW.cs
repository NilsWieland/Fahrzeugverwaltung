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
        public PKW(
            string pHersteller, 
            string pModell, 
            int pJahrErstzulassung, 
            float pAnschaffungspreis, 
            string pKennzeichen,
            int pParkhausNummer,
            int pStellplatzNummer,
            int pHubraum, 
            int pLeistung, 
            int pSchadstoffklasse) :
               base(pHersteller, pModell, pJahrErstzulassung, pAnschaffungspreis, pKennzeichen, pParkhausNummer, pStellplatzNummer)
        {
            Hubraum = pHubraum;
            Leistung = pLeistung;
            Schadstoffklasse = pSchadstoffklasse;
        }

        // Gibt einen String zurück, der alle Daten des PKW Objektes in einer Textzeile enthält. 
        // Die einzelnen Datenelemente sind durch das Zeichen ";" coneinander getrennt
        public override String ToString()
        {
            return
                base.ToString() + "; " +        // Die Daten der Basisklasse in einen String ausgeben
                Hubraum.ToString() + "; " +     // Die PKW spezifischen Daten werden an die Daten der Basisklasse angehängt
                Leistung.ToString() + "; " +
                Schadstoffklasse.ToString();
        }

        // Prüfe und kopiere Hubraum (500 ccm - 10000 ccm)
        public static bool TextToHubraum(string Text, out int Hubraum)
        {
            return PruefeInteger(Text, 500, 10000, out Hubraum);
        }

        // Prüfe und kopiere Leistung (20 kW - 1000 kW)
        public static bool TextToLeistung(string Text, out int Leistung)
        {
            return PruefeInteger(Text, 20, 800, out Leistung);
        }

        // Prüfe und kopiere Schadstoffklasse (0 - 2)
        public static bool TextToSchadstoffklasse(string Text, out int Schadstoffklasse)
        {
            return PruefeInteger(Text, 0, 2, out Schadstoffklasse);
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
            int ParkhausNummer;
            int StellplatzNummer;

            int Hubraum = 0;
            int Leistung = 0;
            int Schadstoffklasse = 0;

            // Prüfe, die für alle Fahrzeuge gemeinsamen Daten, durch Funktion der Elternklasse 
            // Prüfe, die für alle Fahrzeuge gemeinsamen Daten, durch Funktion der Elternklasse 
            bool DatenOk = Fahrzeug.TextToFahrzeugDaten(
                Datenzeile,
                out Hersteller,
                out Modell,
                out Erstzulassung,
                out Anschaffungspreis,
                out Kennzeichen,
                out ParkhausNummer,
                out StellplatzNummer);


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

                // Prüfe und kopiere Hubraum
                if (DatenOk)
                {
                    DatenOk = TextToHubraum(DataArray[8], out Hubraum);
                }

                // Prüfe und kopiere Leistung
                if (DatenOk)
                {
                    DatenOk = TextToLeistung(DataArray[9], out Leistung);
                }

                // Prüfe und kopiere Schadstoffklasse
                if (DatenOk)
                {
                    DatenOk = TextToSchadstoffklasse(DataArray[10], out Schadstoffklasse);
                }
            }

            // Erzeuge PKW Objekt, wenn die Daten OK sind. Sonst wird null zurückgegeben.
            if (DatenOk)
                return new PKW(Hersteller, Modell, Erstzulassung, Anschaffungspreis, Kennzeichen, ParkhausNummer, StellplatzNummer, Hubraum, Leistung, Schadstoffklasse);
            else
                return null;
        }
    }
}
