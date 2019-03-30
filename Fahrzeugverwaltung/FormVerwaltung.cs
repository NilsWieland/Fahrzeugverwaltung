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
    public partial class FormVerwaltung : Form
    {
        // Verwaltungsobjekt, enthält alle Parkhäuser und Fahrzeuge
        private Verwaltung Verwaltung;

        // Konstruktor, initialisiert alle grafischen Elemente des Forms
        public FormVerwaltung()
        {
            // Die Funktion InitializeComponent() wird durch Visual Studio generiert und 
            // soll nicht manuell geändert werden
            InitializeComponent();
        }

        // Lädt alle Parkhäuser und Fahrzeuge und stellt sie im Hauptfenster dar.
        // Die Funktion wird beim Start von FormVerwaltung aufgerufen
        private void FormVerwaltung_Load(object sender, EventArgs e)
        {
            // Erzeuge neues Verwaltungsobjekt
            Verwaltung = new Verwaltung();

            // Lade alle Parkhäuser und Fahrzeuge
            Verwaltung.Laden();

            // Stelle Parkhäuser im Hauptfenster dar
            listViewParkhaeuser.View = View.Details;
            ViewParkhaeuser_Update();

            // Erster Eintrag für Fahrzeugtyp (Alle) selektiert
            comboBoxFahrzeugTyp.SelectedIndex = 0;

            // Stelle Fahrzeuge im Hauptfenster dar
            listViewFahrzeuge.View = View.Details;
            ViewFahrzeuge_Update();
        }

        // Speichert alle Parkhäuser und Fahrzeuge
        // Die Funktion wird beim Schliessen des Fensters FormVerwaltung aufgerufen
        private void FormVerwaltung_Closing(object sender, FormClosingEventArgs e)
        {
            // Speicher alle Parkhäuser und Fahrzeuge
            Verwaltung.Speichern();
        }

        private void View_Update()
        {
            ViewParkhaeuser_Update();
            ViewFahrzeuge_Update();
        }

        // Aktualisiert die Darstellung der Parkhäuser im Hauptfenster
        private void ViewParkhaeuser_Update()
        {
            // Lösche alle Einträge im Listview
            listViewParkhaeuser.Items.Clear();

            // Füge die Daten aller Parkhäuser zum Listview hinzu 
            for (int ii = 0; ii < Verwaltung.AnzahlParkhaeuser; ii++)
            {
                // Hole Parkhausobjekt aus der Parkhausliste
                Parkhaus ph = Verwaltung.ParkhausGet(ii);

                // Alle dargestellten Daten eines Parkhauses werden in ein Array kopiert
                // Das Array entspricht einer Zeile im Listview
                // Jedes Array-Element entspricht dabei einer Spalte im Listview
                string[] ListviewZeile = new string[7];

                // Spalten 1: Parkhausnummer
                ListviewZeile[0] = ph.ParkhausNummer.ToString();
                
                // Spalten 2 - 4: Addresse
                ListviewZeile[1] = ph.PLZ;
                ListviewZeile[2] = ph.Ort;
                ListviewZeile[3] = ph.Strasse;
                
                // Spalte 5: Anzahl der PKW Stellplätze (Belegt/Frei)
                ListviewZeile[4] = ph.AnzahlStellplaetze_Belegt_Typ("PKW").ToString() + " von " + ph.AnzahlStellplaetze_Typ("PKW").ToString();
                
                // Spalte 6: Anzahl der LKW Stellplätze (Belegt/Frei)
                ListviewZeile[5] = ph.AnzahlStellplaetze_Belegt_Typ("LKW").ToString() + " von " + ph.AnzahlStellplaetze_Typ("LKW").ToString();

                // Spalte 7: Anzahl der Motorrad Stellplätze (Belegt/Frei)
                ListviewZeile[6] = ph.AnzahlStellplaetze_Belegt_Typ("Motorrad").ToString() + " von " + ph.AnzahlStellplaetze_Typ("Motorrad").ToString();

                // Füge neue Zeile  mit Parkhausdaten zum Listview hinzu
                listViewParkhaeuser.Items.Add(new ListViewItem(ListviewZeile));
            }
            // Passe die Breite aller Spalten so an, dass alle Daten sichtbar sind
            foreach (ColumnHeader ch in listViewParkhaeuser.Columns)
            {
                ch.Width = -2;
            }
        }

        // Aktualisert die Darstellung der Parkhaus-Buttons
        // Button ParkhausEntfernen ist aktiv solange 1 oder mehr Parkhäuser im Listview selektiert sind
        // Button ParkhausBearbeiten ist aktiv solange genau 1 Parkhaus im Listview selektiert ist
        // Button ParkhausHinzufuegen ist immer aktiv
        // Die Funktion wird aufgerufen, wenn sich die Selektion im Listview geändert hat
        private void listViewParkhaeuser_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewParkhaeuser.SelectedItems.Count > 0)
            {
                // 1 oder mehr Einträge selektiert, Entfernen-Button aktiv
                buttonParkhausEntfernen.Enabled = true;
            }
            else
            {
                // Kein Eintrag selektiert, Entfernen-Button nicht aktiv
                buttonParkhausEntfernen.Enabled = false;
            }
            if (listViewParkhaeuser.SelectedItems.Count == 1)
            {
                // 1 Eintrag selektiert, Bearbeiten-Button aktiv
                buttonParkhausBearbeiten.Enabled = true;
            }
            else
            {
                // 0 oder mehr als 1 Eintrag selektiert, Bearbeiten-Button nicht aktiv
                buttonParkhausBearbeiten.Enabled = false;
            }
        }

        private void buttonParkhausHinzufuegen_Click(object sender, EventArgs e)
        {
            // Erzeuge Parkhaus Hinzufuegen Dialog Objekt
            // Als Parkhausnummer wird die Anzahl der Parkhäuser + 1 genommen
            FormParkhausHinzufuegen form = new FormParkhausHinzufuegen(Verwaltung.AnzahlParkhaeuser + 1);

            // Zeige Dialog
            // Die Funktion wird erst beendet, nachdem Dialog-Fenster geschlossen wurde
            form.ShowDialog();

            // Prüfen ob Dialog mit OK beendet wurde
            if (form.DialogResult == DialogResult.OK)
            {
                // Neues Parkhaus zur Parkhausliste hinzufuegen, wenn Dialog mit OK beendet wurde
                // Das Parkhaus wurde vom Dialog erzeugt und kann von außen gelesen werden (form.Parkhaus)
                Verwaltung.ParkhausHinzufuegen(form.Parkhaus);

                // Die Darstellung der Parkhausdaten wird aktualisiert
                ViewParkhaeuser_Update();
            }

            // Der Fokus wird wieder auf den Fahrzeug Listview gesetzt
            listViewParkhaeuser.Select();
        }

        // Funktion wird aufgerufen wenn der "Löschen" Button gedrückt wurde
        private void buttonParkhausEntfernen_Click(object sender, EventArgs e)
        {
            // Nur löschen wenn mindestens ein Parkhaus im Listview selektiert wurde 
            if (listViewParkhaeuser.SelectedItems.Count > 0)
            {
                // Das Listview Element liefert eine Liste mit den Indizes der selektierten Zeilen
                // Die Liste wird von hinten abgearbeitet, damit nach dem Löschen von Einträgen 
                // die Liste mit den Indizes der selektierten Zeilen weiter gültig bleibt
                for (int ii = listViewParkhaeuser.SelectedItems.Count - 1; ii >= 0; ii--)
                {
                    // Lösche selektiertes Parkhaus aus der Liste
                    Verwaltung.ParkhausLoeschen(listViewParkhaeuser.SelectedItems[ii].Index);
                }

                // Die Darstellung der Parkhausdaten und Fahrzeuge wird aktualisiert
                // Die Darstellung der Fahrzeuge muss wegen der eventuell weggefallenen Stellplätze aktualisiert werden
                View_Update();

                // Der Fokus wird wieder auf den Listview gesetzt
                listViewParkhaeuser.Select();
            }
        }

        private void buttonParkhausBearbeiten_Click(object sender, EventArgs e)
        {
            // Dialog ist noch nicht implementiert    

            if (listViewParkhaeuser.SelectedItems.Count == 1)
            {
                int idxParkhaus = listViewParkhaeuser.SelectedItems[0].Index;

                FormParkhausBearbeiten form = new FormParkhausBearbeiten();
                form.ShowDialog();
            }
        }

        // Aktualisiert die Darstellung der Fahrzeuge im Hauptfenster
        private void ViewFahrzeuge_Update()
        {
            string GewaehlterFahrzeugTyp = comboBoxFahrzeugTyp.Text; 
            string GewaehltesKennzeichen = textBoxKennzeichen.Text.Trim();

            // Gesamte über alle Fahrzeuge aufsummierte KFZ-Steuer
            float SteuerGesamt = 0f;

            // Lösche alle Einträge im Listview
            listViewFahrzeuge.Items.Clear();

            // Spalten mit zusätzliche PKW-Daten  
            if (GewaehlterFahrzeugTyp == "PKW")
            {
                columnUnbestimmt_1.Text = "Hubraum";
                columnUnbestimmt_2.Text = "Leistung";
                columnUnbestimmt_3.Text = "Schadstoffklasse";
            }
            // Spalten mit zusätzliche LKW-Daten  
            else if (GewaehlterFahrzeugTyp == "LKW")
            {
                columnUnbestimmt_1.Text = "Achsen";
                columnUnbestimmt_2.Text = "Zuladung";
                columnUnbestimmt_3.Text = "";
            }
            // Spalten mit zusätzliche Motoraddaten
            else if (GewaehlterFahrzeugTyp == "Motorrad")
            {
                columnUnbestimmt_1.Text = "Hubraum";
                columnUnbestimmt_2.Text = "";
                columnUnbestimmt_3.Text = "";
            }
            // Keine Zusatzdaten, wenn alle Fahrzeugtypen dargestellt werden
            else
            {
                columnUnbestimmt_1.Text = "";
                columnUnbestimmt_2.Text = "";
                columnUnbestimmt_3.Text = "";
            }

            // Füge die Daten aller Fahrzeuge zum Listview hinzu 
            for (int ii = 0; ii < Verwaltung.AnzahlFahrzeuge; ii++)
            {
                // Hole Fahrzeugobjekt aus der fahrzeugliste
                Fahrzeug fz = Verwaltung.FahrzeugGet(ii);

                // Filter für Fahrzeugtyp und Kennzeichen anwenden
                // Gewaelter Fahrzeugtyp muss "Alle" sein oder Fahrzeug muss dem gewählten Typ entsprechen
                //  und
                // Eingegebenes Kennzeichen muss leer sein oder der Anfang des Fahrzeugkennzeichens sein
                if (((GewaehlterFahrzeugTyp == "Alle")   || (fz.Typ == GewaehlterFahrzeugTyp)) &&
                    ((GewaehltesKennzeichen.Length == 0) || (fz.Kennzeichen.IndexOf(GewaehltesKennzeichen) == 0)))
                {
                    // Addiere Steuer des Fahrzeuges zur Gesamtsteuer
                    float Steuer = fz.Steuer;
                    SteuerGesamt += Steuer;

                    // Alle dargestellten Daten eines Fahrzeuges werden in ein Array kopiert
                    // Das Array entspricht einer Zeile im Listview
                    // Jedes Array-Element entspricht dabei einer Spalte im Listview
                    string[] ListviewZeile = new string[12];

                    // Spalte 1: Typ
                    ListviewZeile[0] = fz.Typ;

                    // Spalte 2: Hersteller
                    ListviewZeile[1] = fz.Hersteller;

                    // Spalte 3: Modell
                    ListviewZeile[2] = fz.Modell;

                    // Spalte 4: Kennzeichen
                    ListviewZeile[3] = fz.Kennzeichen;

                    // Spalte 5: Parkhausnummer
                    if (fz.ParkhausNummer > 0)
                    {
                        ListviewZeile[4] = fz.ParkhausNummer.ToString();
                    }
                    else
                    {
                        ListviewZeile[4] = "-";
                    }

                    // Spalte 6: Stellplatznummer
                    if (fz.StellplatzNummer > 0)
                    {
                        ListviewZeile[5] = fz.StellplatzNummer.ToString();
                    }
                    else
                    {
                        ListviewZeile[5] = "-";
                    }

                    // Spalte 7: Jahr der Erstzulassung
                    ListviewZeile[6] = fz.Erstzulassung.ToString();

                    // Spalte 8:  Anschaffungspreis in Euro mit 2 Nachkommastellen (C2)
                    ListviewZeile[7] = String.Format("{0:C2}", fz.Anschaffungspreis);

                    // Spalte 9:  Steuer in Euro mit 2 Nachkommastellen (C2)
                    ListviewZeile[8] = String.Format("{0:C2}", Steuer);

                    // Zusätzliche PKW-Daten  
                    if (GewaehlterFahrzeugTyp == "PKW")
                    {
                        ListviewZeile[9]  = ((PKW)fz).Hubraum.ToString() + " ccm"; ;
                        ListviewZeile[10] = ((PKW)fz).Leistung.ToString() + " kW"; ;
                        ListviewZeile[11] = ((PKW)fz).Schadstoffklasse.ToString();
                    }
                    // Zusätzliche LKW-Daten  
                    else if (GewaehlterFahrzeugTyp == "LKW")
                    {
                        ListviewZeile[9] = ((LKW)fz).AnzahlAchsen.ToString();
                        ListviewZeile[10] = ((LKW)fz).Zuladung.ToString() + " t"; 
                        ListviewZeile[11] = "";
                    }
                    // Zusätzliche Motorraddaten
                    else if (GewaehlterFahrzeugTyp == "Motorrad")
                    {
                        ListviewZeile[9] = ((Motorrad)fz).Hubraum.ToString() + " ccm";
                        ListviewZeile[10] = "";
                        ListviewZeile[11] = "";
                    }
                    // Keine Zusatzdaten, wenn alle Fahrzeugtypen dargestellt werden
                    else
                    {
                        ListviewZeile[9] = "";
                        ListviewZeile[10] = "";
                        ListviewZeile[11] = "";
                    }


                    // Füge neue Zeile  mit Fahrzeugdaten zum Listview hinzu
                    listViewFahrzeuge.Items.Add(new ListViewItem(ListviewZeile));
                }
            }
            
            // Passe die Breite aller Spalten so an, dass alle Daten sichtbar sind
            foreach (ColumnHeader ch in listViewFahrzeuge.Columns)
            {
                ch.Width = -2;
            }

            // Ausgabe der Gesamtsteuer
            labelSteuerGesamt.Text = String.Format("{0:C2}", SteuerGesamt);
        }

        // Aktualisert die Darstellung der Parkhaus-Buttons
        // Button FahrzeugEntfernen ist aktiv solange 1 oder mehr Fahrzeuge im Listview selektiert sind
        // Button FahrzeugBearbeiten ist aktiv solange genau 1 Fahrzeug im Listview selektiert ist
        // Button FahrzeugHinzufuegen ist immer aktiv
        // Die Funktion wird aufgerufen, wenn sich die Selektion im Listview geändert hat
        private void listViewFahrzeuge_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewFahrzeuge.SelectedItems.Count > 0)
            {
                // 1 oder mehr Einträge selektiert, Entfernen-Button aktiv
                buttonFahrzeugEntfernen.Enabled = true;
            }
            else
            {
                // Kein Eintrag selektiert, Entfernen-Button nicht aktiv
                buttonFahrzeugEntfernen.Enabled = false;
            }
            if (listViewFahrzeuge.SelectedItems.Count == 1)
            {
                // 1 Fahrzeug ausgewählt
                //   Fahrzeug bearbeiten -Button aktiv und 
                //   Stellplatz zuweisen -Button aktiv
                buttonFahrzeugBearbeiten.Enabled = true;
                buttonStellplatzZuweisen.Enabled = true;
            }
            else
            {
                // 0 oder mehr als 1 Fahrzeug ausgewählt
                //   Fahrzeug bearbeiten - Button nicht aktiv und 
                //   Stellplatz zuweisen - Button nicht aktiv
                buttonFahrzeugBearbeiten.Enabled = false;
                buttonStellplatzZuweisen.Enabled = false;
            }
        }

        // Funktion wird aufgerufen, wenn der Fahrzeug hinzufuegen Button gedrückt wurde
        // Die Funktion öffnet einen Dialog, in dem ein neues Fahrzeug erzeugt werden kann
        private void buttonFahrzeugHinzufuegen_Click(object sender, EventArgs e)
        {
            // Erzeuge FahrzeugHinzufuegen Dialog Objekt
            FormFahrzeugHinzufuegen form = new FormFahrzeugHinzufuegen();

            // Zeige Dialog
            // Die Funktion wird erst beendet, nachdem Dialog-Fenster geschlossen wurde
            form.ShowDialog();

            // Prüfen ob Dialog mit OK beendet wurde
            if (form.DialogResult == DialogResult.OK)
            {
                // Neues Fahrzeug zur Fahrzeugliste hinzufuegen, wenn Dialog mit OK beendet wurde
                // Das Fahrzeug wurde vom Dialog erzeugt und kann von Außen gelesen werden (form.Fahrzeug)
                Verwaltung.FahrzeugHinzufuegen(form.Fahrzeug);

                // Die Darstellung der Fahrzeugdaten wird aktualisiert
                ViewFahrzeuge_Update();
            }

            // Der Fokus wird wieder auf den Fahrzeug Listview gesetzt
            listViewFahrzeuge.Select();
        }

        // Funktion wird aufgerufen wenn der "Löschen" Button gedrückt wurde
        // Alle ausgeählten Fahrzeuge werden gelöscht
        private void buttonFahrzeugEntfernen_Click(object sender, EventArgs e)
        {
            // Nur löschen wenn mindestens ein Fahrzeug im Listview selektiert wurde 
            if (listViewFahrzeuge.SelectedItems.Count > 0)
            {
                // Das Listview Element liefert eine Liste mit den Indizes der selektierten Zeilen
                // Die Liste wird von hinten abgearbeitet, damit nach dem Löschen von Einträgen 
                // die Liste mit den Indizes der selektierten Zeilen weiter gültig bleibt

                for (int ii = listViewFahrzeuge.SelectedItems.Count - 1; ii >= 0; ii--)
                {
                    // Lösche selektiertes Fahrzeug aus der Liste
                    Verwaltung.FahrzeugLoeschen(listViewFahrzeuge.SelectedItems[ii].Index);
                }

                // Die Darstellung der Parkhausdaten und Fahrzeuge wird aktualisiert
                // Die Darstellung der Parkhausdaten muss wegen der eventuell weggefallenen Stellplatzbelegung aktualisiert werden
                View_Update();

                // Der Fokus wird wieder auf den Listview gesetzt
                listViewFahrzeuge.Select();
            }
        }

        // Funktion wird aufgerufen, wenn der Fahrzeug bearbeiten Button gedrückt wurde
        // Die Funktion öffnet einen Dialog, in dem die Daten des ausgewählten Fahrzeugs bearbeitet werden können
        private void buttonFahrzeugBearbeiten_Click(object sender, EventArgs e)
        {
            // Dialog ist noch nicht implementiert    

            FormFahrzeugBearbeiten form = new FormFahrzeugBearbeiten();

            form.ShowDialog();
        }

        // Funktion wird aufgerufen, wenn der Stellplatz zuweisen Button gedrückt wurde
        // Die Funktion öffnet einen Dialog, in welchem dem ausgewählten Fahrzeug 
        //   ein Parkhaus und ein Stellplatz zugewiesen werden kann
        private void buttonStellplatzZuweisen_Click(object sender, EventArgs e)
        {
            if (listViewFahrzeuge.SelectedItems.Count == 1)
            {
                // Hole Index des selktierten Eintrags
                int ListviewIndex = listViewFahrzeuge.SelectedItems[0].Index;

                // Hole Fahrzeug mit dem Index aus Liste
                Fahrzeug fz = Verwaltung.FahrzeugGet(ListviewIndex);

                // Erzeuge neues Dialog-Objekt
                FormStellplatzZuweisen form = new FormStellplatzZuweisen(Verwaltung, fz);

                // Setzte Title des Dialogs mit Typ und Kennzeichen des Fahrzeugs
                form.Text = "Stellplatz zuweisen für " + fz.Typ + " " + fz.Kennzeichen;
                form.ShowDialog();

                // Prüfen ob Dialog mit OK beendet wurde
                if (form.DialogResult == DialogResult.OK)
                {
                    // Die Darstellung der Parkhausdaten und Fahrzeuge wird aktualisiert
                    View_Update();
                }

                // Der Fokus wird wieder auf den vorher selektierten Eintrag gestzt
                listViewFahrzeuge.Select();
                listViewFahrzeuge.Items[ListviewIndex].Focused = true;
                listViewFahrzeuge.Items[ListviewIndex].Selected = true;
            }
        }

        // Wird aufgerufen, wenn sich der selektiert Fahrzeugtyp geändert hat
        private void comboBoxFahrzeugTyp_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Listview mit dem selektierten Fahrzeugtyp aktualisieren 
            // Fahrzeuge, die nicht dem selektierten Typ entsprechen werden nicht dargestellt
            ViewFahrzeuge_Update();
        }

        // Wird aufgerufen, wenn sich der Text in der Textbox Kennzeichen geändert hat
        private void textBoxKennzeichen_TextChanged(object sender, EventArgs e)
        {
            // Listview mit dem eingegebenen Kennzeichen aktualsieren
            // Fahrzeuge, die nicht das eingegebene Kennzeichen enthalten werden nicht dargestellt
            ViewFahrzeuge_Update();
        }
    }
}
