using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrzeugverwaltung
{
    public abstract class Fahrzeug
        
    {
        private string Hersteller;
        private string Modell;
        private string Kennzeichen;
        private int JahrErstzulassung;
        private float Anschaffungspreis;
        private int Parkhausindex;
        private int Stellplatzindex;

        public string get_Hersteller()
        {
            return Hersteller;
        }

        public string get_Modell()
        {
            return Modell;
        }

        public string get_Kennzeichen()
        {
            return Kennzeichen;
        }

        public int get_JahrErstzulassung()
        {
            return JahrErstzulassung;
        }

        public float get_Anschaffungspreis ()
        {
            return Anschaffungspreis;
        }

        public int get_Parkhausindex()
        {
            return Parkhausindex;
        }

        public int get_Stellplatzindex()
        {
            return Stellplatzindex;
        }


        public void set_Hersteller()
        {

        }

        public void set_Modell()
        {

        }

        public void set_Kennzeichen()
        {

        }

        public void set_JahrErstzulassung()
        {

        }

        public void set_Anschaffungspreis()
        {

        }

        public void set_Parkhausindex()
        {

        }

        public void set_Stellplatzindex()
        {

        }

        public void print_alleFahrzeugdaten()
        {
            
        }
        
    }
    
}
