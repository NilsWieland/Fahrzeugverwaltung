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
    public partial class FormStellplatzZuweisen : Form
    {
        // Das Verwaltungs-Objekt. 
        // Wird dem Kontruktor des Dialogs übergeben
        private Verwaltung verwaltung;

        // Das Fahrzeug-Objekt, welches einen Stellplatz zugewiesen werden soll
        // Wird dem Kontruktor des Dialogs übergeben
        private Fahrzeug fahrzeug;

        // Kontruktor für den Stellplatz zuweisen Dialog
        public FormStellplatzZuweisen(Verwaltung pVerwaltung, Fahrzeug pFahrzeug)
        {
            verwaltung = pVerwaltung;
            fahrzeug = pFahrzeug;

            // Initialisiere alle Elemente des Dialogs
            // Der Inhalt dieser Funktion wird von Visual Studio erzeugt und soll nicht mauell verändert werden
            InitializeComponent();

            // Fülle Combobox mit allen vorhandenen Parkhäusern
            for (int iParkhaus = 0; iParkhaus < verwaltung.AnzahlParkhaeuser; iParkhaus++)
            {
                // Hole Parkhaus-Objekt aus der Parkhausliste
                Parkhaus ph = verwaltung.ParkhausGet(iParkhaus);

                // Füge Parkhaus (Nummer, Ort, Strasse) zur Combobox hinzu
                comboBoxParkhaus.Items.Add("Parkhaus " + ph.ParkhausNummer +", " + ph.Ort + ", " + ph.Strasse);
            }

            // Füge zusätzlichen Eintrag "Zuweisung löschen" hinzu, wenn Fahrzeug bereits einen zugwiesenen Stellplatz hat
            if ((fahrzeug.ParkhausNummer > 0) && (fahrzeug.StellplatzNummer > 0))
            {
                comboBoxParkhaus.Items.Add("Stellplatzzuweisung löschen");
            }

            // Wähle erstes (Index = 0) Parkhaus aus
            comboBoxParkhaus.SelectedIndex = 0;
        }

        // Wird aufgerufen wenn ein anderes Parkhaus in der ComboBox ausgewählt wurde
        private void comboBoxParkhaus_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Prüfe ob Parkhaus ausgewählt wurde (Liste könnte auch leer sein)
            if (comboBoxParkhaus.Items.Count > 0)
            {
                // Nachdem ein anderes Parkhaus gewählt wurde, muss die ComboBox mit den
                // verfügbaren Stellplätzen neu gefüllt werden.
                // Lösche zunächst alle Einträge in der ComboBox für Stellpätze
                comboBoxStellplatz.Items.Clear();

                // Am Ende der Liste in der Parkhaus-ComboBox existiert eventuell der Spezialeintrag "Zuweisung löschen". 
                // Falls dieser ausgwählt wurde, wird die Stellpatz-ComboBox nicht gefüllt. 
                // Ein echtes Parkhaus wurde ausgewählt, wenn der Index in der Combobox kleiner als AnzahlParkhaeuser ist.
                if (comboBoxParkhaus.SelectedIndex < verwaltung.AnzahlParkhaeuser)
                {
                    // Hole Parkhaus-Objekt aus Parkhaus-Liste 
                    // Der Index des ausgewählten Parkhauses in der ComboBox kann direkt verwendet werden,
                    //  um auf die Parkhausliste zuzugreifen.
                    Parkhaus ph = verwaltung.ParkhausGet(comboBoxParkhaus.SelectedIndex);

                    // Fülle ComboBox mit Stellplätzen
                    for (int iStellplatz = 0; iStellplatz < ph.AnzahlStellplaetze; iStellplatz++)
                    {
                        Stellplatz sp = ph.StellPlaetze[iStellplatz];

                        // Es werden nur folgende Stellpätze angezeigt:
                        //   - Stellplatztyp (PKW, LKW, Motorrad) muss identisch mit dem Fahrzeugtyp sein
                        //   - der Stellplatz muss frei sein
                        if ((fahrzeug.Typ == sp.Typ) && (sp.FreierStellplatz() == true))
                        {
                            comboBoxStellplatz.Items.Add(sp.Nummer);
                        }
                    }
                }
                else
                {
                    comboBoxStellplatz.Items.Add("-");
                }

                // Wähle ersten Stellplatz in der ComboBox aus, wenn mindestens ein Stellplatz vorhanden ist
                if (comboBoxStellplatz.Items.Count > 0)
                {
                    comboBoxStellplatz.SelectedIndex = 0;
                }
            }
        }

        // Funktion wird aufgerufen wenn der Übernehmen Button gedrückt wurde
        // Die Funktion weist dem Fahrzeug den ausgewählten Stellplatz im ausgewählten Parkhaus zu.
        private void buttonUebernehmen_Click(object sender, EventArgs e)
        {
            // Es muss ein Parkhaus und ein Stellplatz ausgewählt ein
            if ((comboBoxParkhaus.Items.Count > 0) && (comboBoxStellplatz.Items.Count > 0))
            {
                // Am Ende der Liste in der Parkhaus-ComboBox existiert eventuell der Spezialeintrag "Zuweisung löschen". 
                // Ein echtes Parkhaus wurde ausgewählt, wenn der Index in der Combobox kleiner als AnzahlParkhaeuser ist.
                if (comboBoxParkhaus.SelectedIndex < verwaltung.AnzahlParkhaeuser)
                {
                    // Hole Parkhaus-Objekt aus Parkhaus-Liste 
                    // Der Index des ausgewählten Parkhauses in der ComboBox kann direkt verwendet werden,
                    //  um auf die Parkhausliste zuzugreifen.
                    Parkhaus ph = verwaltung.ParkhausGet(comboBoxParkhaus.SelectedIndex);

                    // Lese Stellplatznummer aus der ComboBox und wandle sie in einen int Wert um
                    // Der Index des ausgewählten Stellplatzes in der ComboBox kann NICHT direkt verwendet werden,
                    //   um auf die Stellplatzliste zuzugreifen, da nicht alle Stellplätze (nicht frei, falscher Typ)
                    //   in die ComboBox eingetragen wurden.
                    int StellplatzNummer = 0;

                    if (Int32.TryParse(comboBoxStellplatz.Text, out StellplatzNummer) == true)
                    {
                        // Die Stellplatzzuweisung für das Fahrzeug mit der ausgewählten
                        //   Parkhaus-und Stellplatznummer wird von der Verwaltungsklasse durchgeführt
                        verwaltung.StellplatzZuweisen(fahrzeug, ph.ParkhausNummer, StellplatzNummer);
                    }
                }
                // Spezialeintrag "Zuweisung löschen" wurde gewählt
                else
                {
                    // Durch übergabe der 0 für die Parkhaus und Stellplatznummer wird die Zuweisung gelöscht
                    //
                    verwaltung.StellplatzZuweisen(fahrzeug, 0, 0);
                }
            }
        }
    }
}
