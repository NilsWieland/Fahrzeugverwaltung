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
        public LKW(
            string pHersteller, 
            string pModell, 
            int pJahrErstzulassung, 
            float pAnschaffungspreis, 
            string pKennzeichen,
            int pParkhausNummer,
            int pStellplatzNummer,
            int pAnzahlAchsen, 
            float pZuladung) :
               base(pHersteller, pModell, pJahrErstzulassung, pAnschaffungspreis, pKennzeichen, pParkhausNummer, pStellplatzNummer)
        {
            AnzahlAchsen = pAnzahlAchsen;
            Zuladung = pZuladung;
        }

        // Gibt einen String zurück, der alle Daten des LKW Objektes in einer Textzeile enthält. 
        // Die einzelnen Datenelemente sind durch das Zeichen ";" coneinander getrennt
        public override String ToString()
        {
            return
                base.ToString() + "; " +             // Die Daten der Basisklasse in einen String ausgeben
                AnzahlAchsen.ToString() + "; " +     // Die LKW spezifischen Daten werden an die Daten der Basisklasse angehängt
                Zuladung.ToString();
        }

        // Prüfe und kopiere AnzahlAchsen (2 - 32)
        public static bool TextToAnzahlAchsen(string Text, out int AnzahlAchsen)
        {
            return PruefeInteger(Text, 2, 32, out AnzahlAchsen);
        }

        // Prüfe und kopiere Zuladung (1 t - 50 t)
        public static bool TextToZuladung(string Text, out float Zuladung)
        {
            return PruefeFloat(Text, 1, 100, out Zuladung);
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
            int ParkhausNummer;
            int StellplatzNummer;

            int AnzahlAchsen = 0;
            float Zuladung = 0;

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

            // Prüfen der LKW Daten, wenn gemeinsame Daten OK sind
            if (DatenOk)
            {
                string[] DataArray = Datenzeile.Split(';');

                // Erstes Datenelement muss LKW sein
                if (DataArray[0] != "LKW")
                {
                    DatenOk = false;
                }

                // Prüfe und kopiere Achsenanzahl
                if (DatenOk)
                {
                    DatenOk = TextToAnzahlAchsen(DataArray[8], out AnzahlAchsen);
                }

                // Prüfe und kopiere Zuladung
                if (DatenOk)
                {
                    DatenOk = TextToZuladung(DataArray[8], out Zuladung);
                }
            }

            // Erzeuge PKW Objekt, wenn die Daten OK sind. Sonst wird null zurückgegeben.
            if (DatenOk)
                return new LKW(Hersteller, Modell, Erstzulassung, Anschaffungspreis, Kennzeichen, ParkhausNummer, StellplatzNummer, AnzahlAchsen, Zuladung);
            else
                return null;
        }
    }
}
