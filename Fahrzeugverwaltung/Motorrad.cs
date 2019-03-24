using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrzeugverwaltung
{
    // Motorradklasse
    public class Motorrad : Fahrzeug
    {
        // Typ ist immer Motorrad
        public override string Typ
        {
            get
            {
                return "Motorrad";
            }
        }

        public override float Steuer
        {
            get
            {
                //  (Hubraum+99) / 100 * 20 Euro
                return ((Hubraum + 99) / 100) * 20;
            }
        }

        // Hubraum in Kubikcentimeter
        public int Hubraum { get; }

        // Konstruktor
        // Ruft Konstruktor der Elternklasse auf
        public Motorrad(
            string pHersteller,
            string pModell,
            int pJahrErstzulassung,
            float pAnschaffungspreis,
            string pKennzeichen,
            int pParkhausNummer,
            int pStellplatzNummer,
            int pHubraum) :
               base(pHersteller, pModell, pJahrErstzulassung, pAnschaffungspreis, pKennzeichen, pParkhausNummer, pStellplatzNummer)
        {
            Hubraum = pHubraum;
        }

        // Gibt einen String zurück, der alle Daten des Motorad Objektes in einer Textzeile enthält. 
        // Die einzelnen Datenelemente sind durch das Zeichen ";" coneinander getrennt
        public override String ToString()
        {
            return
                base.ToString() + "; " +            // Die Daten der Basisklasse in einen String ausgeben
                Hubraum.ToString();                 // Die LKW spezifischen Daten werden an die Daten der Basisklasse angehängt
        }

        // Prüfe und kopiere Hubraum (50 ccm - 2000 ccm)
        public static bool TextToHubraum(string Text, out int Hubraum)
        {
            return PruefeInteger(Text, 50, 2000, out Hubraum);
        }

        // Erzeugt ein Motorad Objekt aus einer Datenzeile. 
        // Die Datenzeile wird geprüft. 
        // Sind die Daten OK wird ein Motorad Objekt erzeugt und zurückgegeben.
        // Sind die Daten nicht OK wird kein Motorad Objekt erzeugt und es wird null zurückgegeben.
        // Jede Datenzeile muss folgendermassen aufgebaut sein
        // <Fahrzeugtyp>;<Fahrzeugmodell>;<Jahr der Erstzulassung>;<Anschaffungspreis>;<Kennzeichen>;<Hubraum>
        // Beispiel: Motorrad; BMW; R1200R; 1999; 6000; K-GS-03; 1170
        public static Motorrad ErzeugeFahrzeug(
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

            // Prüfen der Motorad Daten, wenn gemeinsame Daten OK sind
            if (DatenOk)
            {
                string[] DataArray = Datenzeile.Split(';');

                if (DatenOk)
                {
                    if (DataArray[0] != "Motorrad")
                    {
                        DatenOk = false;
                    }
                }

                // Wandle String in int um für Hubraum (50 ccm - 2000 ccm)
                if (DatenOk)
                {
                    DatenOk = PruefeInteger(DataArray[8], 50, 2000, out Hubraum);
                }
            }
            
            // Erzeuge Motorad Objekt, wenn die Daten OK sind. Sonst wird null zurückgegeben.
            if (DatenOk)
                return new Motorrad(Hersteller, Modell, Erstzulassung, Anschaffungspreis, Kennzeichen, ParkhausNummer, StellplatzNummer, Hubraum);
            else
                return null;
        }

    }
}
