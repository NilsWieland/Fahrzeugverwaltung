using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fahrzeugverwaltung
{
    public partial class FormParkhausHinzufuegen : Form
    {
        // Array von boolschen Werten für jeden Eingabewert
        // Ist der Eingabewert OK, wird das entsprechende Array-Element auf true gesetzt
        // Ist der Eingabewert nicht OK, wird das entsprechende Array-Element auf false gesetzt
        // Nur wenn alle Array-Element auf true gesetzt sind, wird der OK Button aktiviert. 
        private bool[] AlleDatenOK;

        // Erzeugtes Parkhaus nachdem OK Button gedrückt wurde
        public Parkhaus Parkhaus { get; set; }

        // Die Parkhausnummer, die das neu erzeugte Parkhaus erhalten soll
        // Diese Nummer wird dem Dialog-Konstruktor übergeben
        int ParkhausNummer;

        // Dialog Konstruktor
        public FormParkhausHinzufuegen(int pParkhausNummer)
        {
            ParkhausNummer = pParkhausNummer;

            // Zunächst sind alle Daten ungültig
            AlleDatenOK = new bool[4];
            for (int ii = 0; ii < 4; ii++)
            {
                AlleDatenOK[ii] = false;
            }

            // Initialisiere alle Elemente des Dialogs
            // Der Inhalt dieser Funktion wird von Visual Studio erzeugt und soll nicht mauell verändert werden
            InitializeComponent();

            // Beim Start sind alle Daten ungültig
            // Setzte Hintergrundfarbe der Textboxen auf rot
            textBoxPLZ.BackColor = System.Drawing.Color.LightCoral;
            textBoxOrt.BackColor = System.Drawing.Color.LightCoral;
            textBoxStrasse.BackColor = System.Drawing.Color.LightCoral;
            textBoxAnzahlParkplaetze.BackColor = System.Drawing.Color.LightCoral;


            // Deaktiviere OK Button
            AktualisiereOkButton();
        }

        // Wird aufgerufen, wenn sich der Inhalt der Textbox PLZ geändert hat.
        // Die Funktion prüft den Wert und stellt den Hintergrund im Fehlerfall rot dar
        private void textBoxPLZ_TextChanged(object sender, EventArgs e)
        {
            string s;

            // Prüfe PLZ, zurückgegebener Wert wird nicht verwendet                         
            AlleDatenOK[0] = Parkhaus.TextToPLZ(textBoxPLZ.Text, out s);

            // Hintergrundfarbe der Textbox normal wenn Daten OK
            if (AlleDatenOK[0])
            {
                textBoxPLZ.BackColor = System.Drawing.SystemColors.Window;
            }
            // Hintergrundfarbe der Textbox rot wenn Daten nicht OK
            else
            {
                textBoxPLZ.BackColor = System.Drawing.Color.LightCoral;
            }

            // Enable OK Button, wenn keine Fehler 
            // Alle Elemente von AlleDatenOK müssen true sein
            AktualisiereOkButton();
        }

        // Wird aufgerufen, wenn sich der Inhalt der Textbox Ort geändert hat.
        // Die Funktion prüft den Wert und stellt den Hintergrund im Fehlerfall rot dar
        private void textBoxOrt_TextChanged(object sender, EventArgs e)
        {
            string s;
            
            // Prüfe Ort, zurückgegebener Wert wird nicht verwendet                         
            AlleDatenOK[1] = Parkhaus.TextToOrt(textBoxOrt.Text, out s);

            // Hintergrundfarbe der Textbox normal wenn Daten OK
            if (AlleDatenOK[1])
            {
                textBoxOrt.BackColor = System.Drawing.SystemColors.Window;
            }
            // Hintergrundfarbe der Textbox rot wenn Daten nicht OK
            else
            {
                textBoxOrt.BackColor = System.Drawing.Color.LightCoral;
            }

            // Enable OK Button, wenn keine Fehler 
            // Alle Elemente von AlleDatenOK müssen true sein
            AktualisiereOkButton();
        }

        // Wird aufgerufen, wenn sich der Inhalt der Textbox Strasse geändert hat.
        // Die Funktion prüft den Wert und stellt den Hintergrund im Fehlerfall rot dar
        private void textBoxStrasse_TextChanged(object sender, EventArgs e)
        {
            string s;

            // Prüfe Ort, zurückgegebener Wert wird nicht verwendet                         
            AlleDatenOK[2] = Parkhaus.TextToStrasse(textBoxStrasse.Text, out s);

            // Hintergrundfarbe der Textbox normal wenn Daten OK
            if (AlleDatenOK[2])
            {
                textBoxStrasse.BackColor = System.Drawing.SystemColors.Window;
            }
            // Hintergrundfarbe der Textbox rot wenn Daten nicht OK
            else
            {
                textBoxStrasse.BackColor = System.Drawing.Color.LightCoral;
            }

            // Enable OK Button, wenn keine Fehler 
            // Alle Elemente von AlleDatenOK müssen true sein
            AktualisiereOkButton();
        }

        // Wird aufgerufen, wenn sich der Inhalt der Textbox AnzahlParkplaetze geändert hat.
        // Die Funktion prüft den Wert und stellt den Hintergrund im Fehlerfall rot dar
        private void textBoxAnzahlParkplaetze_TextChanged(object sender, EventArgs e)
        {
            int i;

            // Prüfe Anzahl Stellplätze, zurückgegebener Wert wird nicht verwendet                         
            AlleDatenOK[3] = Parkhaus.TextToAnzahlStellplaetze(textBoxAnzahlParkplaetze.Text, out i);

            // Hintergrundfarbe der Textbox normal wenn Daten OK
            if (AlleDatenOK[3])
            {
                textBoxAnzahlParkplaetze.BackColor = System.Drawing.SystemColors.Window;
            }
            // Hintergrundfarbe der Textbox rot wenn Daten nicht OK
            else
            {
                textBoxAnzahlParkplaetze.BackColor = System.Drawing.Color.LightCoral;
            }

            // Enable OK Button, wenn keine Fehler 
            // Alle Elemente von AlleDatenOK müssen true sein
            AktualisiereOkButton();
        }

        // Speichert alle Daten, Dialogfenster wird anschliesen geschlossen
        private void buttonUebernehmen_Click(object sender, EventArgs e)
        {
            string PLZ;
            string Ort;
            string Strasse;
            int AnzahlStellplaetze;

            // Alle Parkhausdaten aus den Texboxen auslesen
            Parkhaus.TextToPLZ(textBoxPLZ.Text, out PLZ);
            Parkhaus.TextToOrt(textBoxOrt.Text, out Ort);
            Parkhaus.TextToStrasse(textBoxStrasse.Text, out Strasse);
            Parkhaus.TextToAnzahlStellplaetze(textBoxAnzahlParkplaetze.Text, out AnzahlStellplaetze);
            
            // Neues Parkhaus mit eingegebenen Daten erzeugen
            Parkhaus = new Parkhaus(ParkhausNummer, AnzahlStellplaetze, PLZ, Ort, Strasse);
        }

        // Aktualisiert OK Button wenn alle Daten in Ordnung sind, d.h.
        // Alle Elemente von AlleDatenOK müssen true sein
        private void AktualisiereOkButton()
        {
            // Wird auf false gesetzt, wenn ein Element des Arrays AlleDatenOK false ist
            bool EnableButton = true;

            // Prüfe auf Fehler
            for (int ii = 0; ii < 4; ii++)
            {
                if (AlleDatenOK[ii] == false)
                {
                    // Fehler gefunden
                    EnableButton = false;
                }
            }

            // Aktiviere oder deaktiviere OK Button
            buttonUebernehmen.Enabled = EnableButton;
        }

    }
}
