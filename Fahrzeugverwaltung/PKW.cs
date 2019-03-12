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

        // Hubraum in Kubikcentimeter
        public int Hubraum { get; }

        // Leistung in kW
        public int Leistung { get; }

        // Schadstoffklasse (0 - 6)
        public int Schadstoffklasse { get; }

        // Konstruktor
        // Ruft Konstruktor der Basisklasse auf
        public PKW(string pHersteller, string pModell, int pJahrErstzulassung, float pAnschaffungspreis, string pKennzeichen, int pHubraum, int pLeistung, int pSchadstoffklasse) :
               base(pHersteller, pModell, pJahrErstzulassung, pAnschaffungspreis, pKennzeichen)
        {
            Hubraum = pHubraum;
            Leistung = pLeistung;
            Schadstoffklasse = pSchadstoffklasse;
        }
    }

}
