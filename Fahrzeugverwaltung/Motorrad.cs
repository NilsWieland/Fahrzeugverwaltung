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
        public Motorrad(string pHersteller, string pModell, int pJahrErstzulassung, float pAnschaffungspreis, string pKennzeichen, int pHubraum) :
               base(pHersteller, pModell, pJahrErstzulassung, pAnschaffungspreis, pKennzeichen)
        {
            Hubraum = pHubraum;
        }

        public static Motorrad ErzeugeFahrzeug(
            string Datenzeile)
        {
            string Hersteller;
            string Modell;
            int Erstzulassung;
            float Anschaffungspreis;
            string Kennzeichen;
            int Hubraum = 0;

            string[] DataArray = Datenzeile.Split(';');

            bool DatenOk = Fahrzeug.PruefeDaten(Datenzeile, out Hersteller, out Modell, out Erstzulassung, out Anschaffungspreis, out Kennzeichen);

            if (DatenOk)
            {
                if (DataArray[0] != "Motorrad")
                {
                    DatenOk = false;
                }
            }

            if (DatenOk)
            {
                DatenOk = PruefeInteger(DataArray[6], 50, 10000, out Hubraum);
            }

            if (DatenOk)
                return new Motorrad(Hersteller, Modell, Erstzulassung, Anschaffungspreis, Kennzeichen, Hubraum);
            else
                return null;
        }

    }
}
