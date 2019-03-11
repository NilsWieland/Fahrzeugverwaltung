using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrzeugverwaltung
{
    // Klasse Stellplatz
    public class Stellplatz
    {
        // Typ des Stellplatzes (PKW, LKW, Motorrad)
        public string Typ { get; set; }

        // Kennzeichen des Fahrzeugs, das den Stellplatz belegt
        // Wenn der Stellplatz frei ist, ist kein Kenn´zeichen abgelegt
        public string Kennzeichen { get; set; }

        // Nummer des Stellplatzes im Parkhaus
        public int Nummer { get; }

        // Konstruktor
        public Stellplatz(int pNummer)
        {
            Kennzeichen = "";
            Typ = "PKW";
            Nummer = pNummer;
        }
        // Gibt true zurück, wenn der Stellplatz frei ist
        public bool FreierStellplatz()
        {
            return (Kennzeichen.Length == 0);
        }
    }
}
