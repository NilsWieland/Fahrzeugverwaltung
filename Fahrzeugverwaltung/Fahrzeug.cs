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

        // Konstruktor der Basisklasse
        // Wird nur von den Konstruktoren der abgeleiteten Klassen aufgerufen
        public Fahrzeug(string pHersteller, string pModell, int pErstzulassung, float pAnschaffungspreis, string pKennzeichen)
        {
            Hersteller = pHersteller;
            Modell = pModell;
            Erstzulassung = pErstzulassung;
            Anschaffungspreis = pAnschaffungspreis;
            Kennzeichen = pKennzeichen;
        }
    }
}
