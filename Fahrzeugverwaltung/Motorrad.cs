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

        // Hubraum in Kubikcentimeter
        public int Hubraum { get; }

        // Konstruktor
        // Ruft Konstruktor der Basisklasse auf
        public Motorrad(string pHersteller, string pModell, int pJahrErstzulassung, float pAnschaffungspreis, string pKennzeichen, int pHubraum) :
               base(pHersteller, pModell, pJahrErstzulassung, pAnschaffungspreis, pKennzeichen)
        {
            Hubraum = pHubraum;
        }
    }
}
