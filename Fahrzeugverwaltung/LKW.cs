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
    }
}
