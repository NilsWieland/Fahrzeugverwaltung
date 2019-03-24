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
    public partial class FormFahrzeugHinzufuegen : Form
    {
        // Array von boolschen Werten für jeden Eingabewert
        // Ist der Eingabewert OK, wird das entsprechende Array-Element auf true gesetzt
        // Ist der Eingabewert nicht OK, wird das entsprechende Array-Element auf false gesetzt
        // Nur wenn alle Array-Element auf true gesetzt sind, wird der OK Button aktiviert. 
        private bool[] AlleDatenOK;

        // Erzeugtes Fahrzeug (PKW, LKW, Motorrad) nachdem OK Button gedrückt wurde
        public Fahrzeug Fahrzeug{ get; set;  }

        public FormFahrzeugHinzufuegen()
        {
            AlleDatenOK = new bool[8];

            // Initalieren Form
            InitializeComponent();

            // Wähle PKW als Fahrzeugtyp (Voreinstellung, kann geändert werden)
            comboBoxFahrzeugTyp.SelectedIndex = 0;
        }

        // Funktion wird nach Fahrzeugtypwechsel aufgerufen
        // Die Funktion initialisiert passt die Beschriftung und die Anzahl der
        //   Datenfelder dem ausgewählten Fahrzeugtyp an
        // Alle Daten werden initialisiert.
        private void comboBoxFahrzeugTyp_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Lösche alle Daten nach einem Fahrzeugtypwechsel
            textBoxHersteller.Clear();
            textBoxModell.Clear();
            textBoxErstzulassung.Clear();
            textBoxAnschaffungspreis.Clear();
            textBoxKennzeichen.Clear();
            textBoxUnbestimmt_1.Clear();
            textBoxUnbestimmt_2.Clear();
            textBoxUnbestimmt_3.Clear();

            // Nach einem Fahrzeugtypwechsel sind alle Daten ungültig
            // Setzte Hintergrundfarbe der Textboxen auf rot
            textBoxHersteller.BackColor = System.Drawing.Color.LightCoral;
            textBoxModell.BackColor = System.Drawing.Color.LightCoral;
            textBoxErstzulassung.BackColor = System.Drawing.Color.LightCoral;
            textBoxAnschaffungspreis.BackColor = System.Drawing.Color.LightCoral;
            textBoxKennzeichen.BackColor = System.Drawing.Color.LightCoral;
            textBoxUnbestimmt_1.BackColor = System.Drawing.Color.LightCoral;
            textBoxUnbestimmt_2.BackColor = System.Drawing.Color.LightCoral;
            textBoxUnbestimmt_3.BackColor = System.Drawing.Color.LightCoral;

            // Nach einem Fahrzeugtypwechsel sind alle Daten ungültig
            for (int ii = 0; ii < 8; ii++)
            {
                AlleDatenOK[ii] = false;
            }
            // Deaktiviere OK Button
            AktualisiereOkButton();

            // PKW ausgewaehlt
            if (comboBoxFahrzeugTyp.SelectedIndex == 0)
            {
                // Zeige PKW Text und Eingabefelder
                labelUnbestimmt_1.Show();
                labelUnbestimmt_2.Show();
                labelUnbestimmt_3.Show();

                textBoxUnbestimmt_1.Show();
                textBoxUnbestimmt_2.Show();
                textBoxUnbestimmt_3.Show();

                labelUnbestimmt_1.Text = "Hubraum in ccm (500 - 10000)";
                labelUnbestimmt_2.Text = "Leistung in kW (20 - 800)";
                labelUnbestimmt_3.Text = "Schadstoffklasse(0=Schadstoffarm, 1=Benziner, 2=Diesel)";
            }
            // LKW ausgewaehlt
            else if (comboBoxFahrzeugTyp.SelectedIndex == 1)
            {
                // Zeige LKW Text und Eingabefelder
                labelUnbestimmt_1.Show();
                labelUnbestimmt_2.Show();
                labelUnbestimmt_3.Hide();

                textBoxUnbestimmt_1.Show();
                textBoxUnbestimmt_2.Show();
                textBoxUnbestimmt_3.Hide();

                labelUnbestimmt_1.Text = "Anzahl Achsen (2 - 32)";
                labelUnbestimmt_2.Text = "Zuladung in Tonnen (1 - 50)";

                AlleDatenOK[7] = true;
            }
            // Motorrad ausgewaehlt
            else if (comboBoxFahrzeugTyp.SelectedIndex == 2)
            {
                // Zeige nur Motorrad Text und Eingabefelder
                labelUnbestimmt_1.Show();
                labelUnbestimmt_2.Hide();
                labelUnbestimmt_3.Hide();

                textBoxUnbestimmt_1.Show();
                textBoxUnbestimmt_2.Hide();
                textBoxUnbestimmt_3.Hide();

                labelUnbestimmt_1.Text = "Hubraum in ccm (50 - 2000)";

                AlleDatenOK[6] = true;
                AlleDatenOK[7] = true;
            }
        }

        // Speichert alle Daten und schliest Dialog
        private void buttonUebernehmen_Click(object sender, EventArgs e)
        {
            string Hersteller;
            string Modell;
            int Erstzulassung;
            float Anschaffungspreis;
            string Kennzeichen;

            // Alle für PKW, LKW, Motorrad gemeinsamen Daten aus den Textboxen auslesen und umwandeln
            Fahrzeug.TextToHersteller(textBoxHersteller.Text, out Hersteller);
            Fahrzeug.TextToHersteller(textBoxModell.Text, out Modell);
            Fahrzeug.TextToErstzulassung(textBoxErstzulassung.Text, out Erstzulassung);
            Fahrzeug.TextToAnschaffungspreis(textBoxAnschaffungspreis.Text, out Anschaffungspreis);
            Fahrzeug.TextToKennzeichen(textBoxKennzeichen.Text, out Kennzeichen);

            // PKW ausgewaehlt
            if (comboBoxFahrzeugTyp.SelectedIndex == 0)
            {
                int Hubraum;
                int Leistung;
                int Schadstoffklasse;

                // Alle PKW spezifischen Daten aus den Textboxen auslesen und umwandeln
                PKW.TextToHubraum(textBoxUnbestimmt_1.Text, out Hubraum);
                PKW.TextToLeistung(textBoxUnbestimmt_2.Text, out Leistung);
                PKW.TextToSchadstoffklasse(textBoxUnbestimmt_3.Text, out Schadstoffklasse);

                // Neuen PKW mit eingegeben Daten erzeugen
                Fahrzeug = new PKW(
                    Hersteller,
                    Modell,
                    Erstzulassung,
                    Anschaffungspreis,
                    Kennzeichen,
                    0,              // Noch kein Parkhaus zugewiesen
                    0,              // Noch kein Stellplatz zugewiesen
                    Hubraum,
                    Leistung,
                    Schadstoffklasse);
            }

            // LKW ausgewaehlt
            else if (comboBoxFahrzeugTyp.SelectedIndex == 1)
            {
                int AnzahlAchsen;
                float Zuladung;

                // Alle LKW spezifischen Daten aus den Textboxen auslesen und umwandeln
                LKW.TextToAnzahlAchsen(textBoxUnbestimmt_1.Text, out AnzahlAchsen);
                LKW.TextToZuladung(textBoxUnbestimmt_1.Text, out Zuladung);

                // Neuen LKW mit eingegeben Daten erzeugen
                Fahrzeug = new LKW(
                    Hersteller,
                    Modell,
                    Erstzulassung,
                    Anschaffungspreis,
                    Kennzeichen,
                    0,              // Noch kein Parkhaus zugewiesen
                    0,              // Noch kein Stellplatz zugewiesen
                    AnzahlAchsen,
                    Zuladung);
            }

            // Motorad ausgewaehlt
            else if (comboBoxFahrzeugTyp.SelectedIndex == 2)
            {
                int Hubraum;

                // Alle Motorad spezifischen Daten aus den Textboxen auslesen und umwandeln
                Motorrad.TextToHubraum(textBoxUnbestimmt_1.Text, out Hubraum);

                // Neues Motorrad mit eingegeben Daten erzeugen
                Fahrzeug = new Motorrad(
                    Hersteller,
                    Modell,
                    Erstzulassung,
                    Anschaffungspreis,
                    Kennzeichen,
                    0,              // Noch kein Parkhaus zugewiesen
                    0,              // Noch kein Stellplat zugewiesen
                    Hubraum);
            }
        }

        // Wird aufgerufen, wenn sich der Inhalt der Textbox Hersteller geändert hat.
        // Die Funktion prüft den Wert und stellt den Hintergrund im Fehlerfall rot dar
        private void textBoxHersteller_TextChanged(object sender, EventArgs e)
        {
            string s;

            // Prüfe Hersteller, zurückgegebener Wert wird nicht verwendet                         
            AlleDatenOK[0] = Fahrzeug.TextToHersteller(textBoxHersteller.Text, out s);
            
            // Hintergrundfarbe der Textbox normal wenn Daten OK
            if (AlleDatenOK[0])
            {
                textBoxHersteller.BackColor = System.Drawing.SystemColors.Window;
            }
            // Hintergrundfarbe der Textbox rot wenn Daten nicht OK
            else
            {
                textBoxHersteller.BackColor = System.Drawing.Color.LightCoral;
            }

            // Enable OK Button, wenn keine Fehler 
            // Alle Elemente von AlleDatenOK müssen true sein
            AktualisiereOkButton();
        }

        // Wird aufgerufen, wenn sich der Inhalt der Textbox Modell geändert hat.
        // Die Funktion prüft den Wert und stellt den Hintergrund im Fehlerfall rot dar
        private void textBoxModell_TextChanged(object sender, EventArgs e)
        {
            string s; 

            // Prüfe Modell, zurückgegebener Wert wird nicht verwendet
            AlleDatenOK[1] = Fahrzeug.TextToModell(textBoxModell.Text, out s);
            
            // Hintergrundfarbe der Textbox normal wenn Daten OK
            if (AlleDatenOK[1])
            {
                textBoxModell.BackColor = System.Drawing.SystemColors.Window;
            }
            // Hintergrundfarbe der Textbox rot wenn Daten nicht OK
            else
            {
                textBoxModell.BackColor = System.Drawing.Color.LightCoral;
            }

            // Enable OK Button, wenn keine Fehler 
            // Alle Elemente von AlleDatenOK müssen true sein
            AktualisiereOkButton();
        }

        // Wird aufgerufen, wenn sich der Inhalt der Textbox Erstzulassung geändert hat.
        // Die Funktion prüft den Wert und stellt den Hintergrund im Fehlerfall rot dar
        private void textBoxErstzulassung_TextChanged(object sender, EventArgs e)
        {
            int i;

            // Prüfe Erstzulassung, zurückgegebener Wert wird nicht verwendet                         
            AlleDatenOK[2] = Fahrzeug.TextToErstzulassung(textBoxErstzulassung.Text, out i);

            // Hintergrundfarbe der Textbox normal wenn Daten OK
            if (AlleDatenOK[2])
            {
                textBoxErstzulassung.BackColor = System.Drawing.SystemColors.Window;
            }
            else
            {
                textBoxErstzulassung.BackColor = System.Drawing.Color.LightCoral;
            }

            // Enable OK Button, wenn keine Fehler 
            // Alle Elemente von AlleDatenOK müssen true sein
            AktualisiereOkButton();
        }

        // Wird aufgerufen, wenn sich der Inhalt der Textbox Anschaffungspreis geändert hat.
        // Die Funktion prüft den Wert und stellt den Hintergrund im Fehlerfall rot dar
        private void textBoxAnschaffungspreis_TextChanged(object sender, EventArgs e)
        {
            float f;

            // Prüfe Anschaffungspreis, zurückgegebener Wert wird nicht verwendet                         
            AlleDatenOK[3] = Fahrzeug.TextToAnschaffungspreis(textBoxAnschaffungspreis.Text, out f);

            // Hintergrundfarbe der Textbox normal wenn Daten OK
            if (AlleDatenOK[3])
            {
                textBoxAnschaffungspreis.BackColor = System.Drawing.SystemColors.Window;
            }
            // Hintergrundfarbe der Textbox rot wenn Daten nicht OK
            else
            {
                textBoxAnschaffungspreis.BackColor = System.Drawing.Color.LightCoral;
            }

            // Enable OK Button, wenn keine Fehler 
            // Alle Elemente von AlleDatenOK müssen true sein
            AktualisiereOkButton();
        }

        // Wird aufgerufen, wenn sich der Inhalt der Textbox Kennzeichen geändert hat.
        // Die Funktion prüft den Wert und stellt den Hintergrund im Fehlerfall rot dar
        private void textBoxKennzeichen_TextChanged(object sender, EventArgs e)
        {
            string s;
            // Prüfe Kennzeichen, zurückgegebener Wert wird nicht verwendet                         
            AlleDatenOK[4] = Fahrzeug.TextToKennzeichen(textBoxKennzeichen.Text, out s);
            
            // Hintergrundfarbe der Textbox normal wenn Daten OK
            if (AlleDatenOK[4])
            {
                textBoxKennzeichen.BackColor = System.Drawing.SystemColors.Window;
            }
            // Hintergrundfarbe der Textbox rot wenn Daten nicht OK
            else
            {
                textBoxKennzeichen.BackColor = System.Drawing.Color.LightCoral;
            }

            // Enable OK Button, wenn keine Fehler 
            // Alle Elemente von AlleDatenOK müssen true sein
            AktualisiereOkButton();
        }

        // Wird aufgerufen, wenn sich der Inhalt der Textbox Unbestimmt_1 geändert hat.
        // Die Funktion prüft den Wert und stellt den Hintergrund im Fehlerfall rot dar.
        // PKW    : Textbox Unbestimmt_1 enthält Hubraum
        // LKW    : Textbox Unbestimmt_1 enthält Achsenanzahl
        // Motorad: Textbox Unbestimmt_1 enthält Hubraum
        private void textBoxUnbestimmt_1_TextChanged(object sender, EventArgs e)
        {
            // PKW ausgewaehlt
            if (comboBoxFahrzeugTyp.SelectedIndex == 0)
            {
                int i;
                
                // Prüfe Hubraum, zurückgegebener Wert wird nicht verwendet                         
                AlleDatenOK[5] = PKW.TextToHubraum(textBoxUnbestimmt_1.Text, out i);
            }
            // LKW ausgewaehlt
            else if (comboBoxFahrzeugTyp.SelectedIndex == 1)
            {
                int i;
                AlleDatenOK[5] = LKW.TextToAnzahlAchsen(textBoxUnbestimmt_1.Text, out i);
            }
            // Motorad ausgewaehlt
            else
            {
                int i;
               
                // Prüfe Hubraum, zurückgegebener Wert wird nicht verwendet                         
                AlleDatenOK[5] = Motorrad.TextToHubraum(textBoxUnbestimmt_1.Text, out i);
            }

            // Hintergrundfarbe der Textbox normal wenn Daten OK
            if (AlleDatenOK[5])
            {
                textBoxUnbestimmt_1.BackColor = System.Drawing.SystemColors.Window;
            }
            // Hintergrundfarbe der Textbox rot wenn Daten nicht OK
            else
            {
                textBoxUnbestimmt_1.BackColor = System.Drawing.Color.LightCoral;
            }

            // Enable OK Button, wenn keine Fehler 
            // Alle Elemente von AlleDatenOK müssen true sein
            AktualisiereOkButton();
        }

        // Wird aufgerufen, wenn sich der Inhalt der Textbox Unbestimmt_2 geändert hat.
        // Die Funktion prüft den Wert und stellt den Hintergrund im Fehlerfall rot dar.
        // PKW    : Textbox Unbestimmt_2 enthält Leistung
        // LKW    : Textbox Unbestimmt_2 enthält Zuladung
        // Motorad: Textbox Unbestimmt_2 ist niht benutzt
        private void textBoxUnbestimmt_2_TextChanged(object sender, EventArgs e)
        {
            // PKW ausgewaehlt
            if (comboBoxFahrzeugTyp.SelectedIndex == 0)
            {
                int i;

                // Prüfe Leistung, zurückgegebener Wert wird nicht verwendet                         
                AlleDatenOK[6] = PKW.TextToLeistung(textBoxUnbestimmt_2.Text, out i);
            }
            // LKW ausgewaehlt
            else if (comboBoxFahrzeugTyp.SelectedIndex == 1)
            {
                float f;

                // Prüfe Zuladung, zurückgegebener Wert wird nicht verwendet                         
                AlleDatenOK[6] = LKW.TextToZuladung(textBoxUnbestimmt_2.Text, out f);
            }
            // Motorad ausgewaehlt
            else
            {
                // Keine Daten für Motorad, daher immer OK
                AlleDatenOK[6] = true;
            }

            // Hintergrundfarbe der Textbox normal wenn Daten OK
            if (AlleDatenOK[6])
            {
                textBoxUnbestimmt_2.BackColor = System.Drawing.SystemColors.Window;
            }
            // Hintergrundfarbe der Textbox rot wenn Daten nicht OK
            else
            {
                textBoxUnbestimmt_2.BackColor = System.Drawing.Color.LightCoral;
            }

            // Enable OK Button, wenn keine Fehler 
            // Alle Elemente von AlleDatenOK müssen true sein
            AktualisiereOkButton();
        }

        // Wird aufgerufen, wenn sich der Inhalt der Textbox Unbestimmt_3 geändert hat.
        // Die Funktion prüft den Wert und stellt den Hintergrund im Fehlerfall rot dar.
        // PKW    : Textbox Unbestimmt_3 enthält Schadstoffklasse
        // LKW    : Textbox Unbestimmt_3 ist niht benutzt
        // Motorad: Textbox Unbestimmt_3 ist niht benutzt
        private void textBoxUnbestimmt_3_TextChanged(object sender, EventArgs e)
        {
            // PKW ausgewaehlt
            if (comboBoxFahrzeugTyp.SelectedIndex == 0)
            {
                int i;

                // Prüfe Schadstoffklasse, zurückgegebener Wert wird nicht verwendet                         
                AlleDatenOK[7] = PKW.TextToSchadstoffklasse(textBoxUnbestimmt_3.Text, out i);
            }
            // LKW ausgewaehlt
            else if (comboBoxFahrzeugTyp.SelectedIndex == 1)
            {
                // Keine Daten für LKW, daher immer OK
                AlleDatenOK[7] = true;
            }
            // Motorad ausgewaehlt
            else
            {
                // Keine Daten für Motorad, daher immer OK
                AlleDatenOK[7] = true;
            }

            // Hintergrundfarbe der Textbox normal wenn Daten OK
            if (AlleDatenOK[7])
            {
                textBoxUnbestimmt_3.BackColor = System.Drawing.SystemColors.Window;
            }
            // Hintergrundfarbe der Textbox rot wenn Daten nicht OK
            else
            {
                textBoxUnbestimmt_3.BackColor = System.Drawing.Color.LightCoral;
            }

            // Enable OK Button, wenn keine Fehler 
            // Alle Elemente von AlleDatenOK müssen true sein
            AktualisiereOkButton();
        }

        // Aktualisiert OK Button wenn alle Daten in Ordnung sind, d.h.
        // Alle Elemente von AlleDatenOK müssen true sein
        private void AktualisiereOkButton()
        {
            // Wird auf false gesetzt, wenn ein Element des Arrays AlleDatenOK false ist
            bool EnableButton = true;

            // Prüfe auf Fehler
            for (int ii = 0; ii < 8; ii++)
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
