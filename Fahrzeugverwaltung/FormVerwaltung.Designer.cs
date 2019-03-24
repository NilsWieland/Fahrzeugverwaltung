namespace Fahrzeugverwaltung
{
    partial class FormVerwaltung
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.listViewFahrzeuge = new System.Windows.Forms.ListView();
            this.columnTyp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHersteller = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnModell = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnKennzeichen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnParkhaus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnStellplatz = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnJahrErstzulassung = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPreis = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnSteuer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewParkhaeuser = new System.Windows.Forms.ListView();
            this.columnNummer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPLZ = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnOrt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnStrasse = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPKW = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnLKW = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnMotorad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonParkhausHinzufuegen = new System.Windows.Forms.Button();
            this.buttonParkhausEntfernen = new System.Windows.Forms.Button();
            this.buttonParkhausBearbeiten = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonFahrzeugHinzufuegen = new System.Windows.Forms.Button();
            this.buttonFahrzeugEntfernen = new System.Windows.Forms.Button();
            this.buttonFahrzeugBearbeiten = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelSteuerGesamt = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.27887F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.72113F));
            this.tableLayoutPanel1.Controls.Add(this.listViewFahrzeuge, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.listViewParkhaeuser, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.133829F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.86617F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1089, 479);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // listViewFahrzeuge
            // 
            this.listViewFahrzeuge.AllowColumnReorder = true;
            this.listViewFahrzeuge.BackColor = System.Drawing.SystemColors.Window;
            this.listViewFahrzeuge.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnTyp,
            this.columnHersteller,
            this.columnModell,
            this.columnKennzeichen,
            this.columnParkhaus,
            this.columnStellplatz,
            this.columnJahrErstzulassung,
            this.columnPreis,
            this.columnSteuer});
            this.listViewFahrzeuge.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewFahrzeuge.FullRowSelect = true;
            this.listViewFahrzeuge.GridLines = true;
            this.listViewFahrzeuge.HideSelection = false;
            this.listViewFahrzeuge.Location = new System.Drawing.Point(505, 28);
            this.listViewFahrzeuge.Margin = new System.Windows.Forms.Padding(2);
            this.listViewFahrzeuge.Name = "listViewFahrzeuge";
            this.listViewFahrzeuge.Size = new System.Drawing.Size(582, 407);
            this.listViewFahrzeuge.TabIndex = 5;
            this.listViewFahrzeuge.UseCompatibleStateImageBehavior = false;
            this.listViewFahrzeuge.SelectedIndexChanged += new System.EventHandler(this.listViewFahrzeuge_SelectedIndexChanged);
            // 
            // columnTyp
            // 
            this.columnTyp.Text = "Typ";
            // 
            // columnHersteller
            // 
            this.columnHersteller.Text = "Hersteller";
            this.columnHersteller.Width = 100;
            // 
            // columnModell
            // 
            this.columnModell.Text = "Modell";
            this.columnModell.Width = 100;
            // 
            // columnKennzeichen
            // 
            this.columnKennzeichen.Text = "Kennzeichen";
            // 
            // columnParkhaus
            // 
            this.columnParkhaus.Text = "Parkhaus";
            this.columnParkhaus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnStellplatz
            // 
            this.columnStellplatz.Text = "Stellplatz";
            this.columnStellplatz.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnJahrErstzulassung
            // 
            this.columnJahrErstzulassung.Text = "Erstzulassung";
            this.columnJahrErstzulassung.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnPreis
            // 
            this.columnPreis.Text = "Preis";
            this.columnPreis.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // columnSteuer
            // 
            this.columnSteuer.Text = "Steuer";
            this.columnSteuer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // listViewParkhaeuser
            // 
            this.listViewParkhaeuser.AllowColumnReorder = true;
            this.listViewParkhaeuser.BackColor = System.Drawing.SystemColors.Window;
            this.listViewParkhaeuser.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnNummer,
            this.columnPLZ,
            this.columnOrt,
            this.columnStrasse,
            this.columnPKW,
            this.columnLKW,
            this.columnMotorad});
            this.listViewParkhaeuser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewParkhaeuser.FullRowSelect = true;
            this.listViewParkhaeuser.GridLines = true;
            this.listViewParkhaeuser.HideSelection = false;
            this.listViewParkhaeuser.Location = new System.Drawing.Point(2, 28);
            this.listViewParkhaeuser.Margin = new System.Windows.Forms.Padding(2);
            this.listViewParkhaeuser.Name = "listViewParkhaeuser";
            this.listViewParkhaeuser.Size = new System.Drawing.Size(499, 407);
            this.listViewParkhaeuser.TabIndex = 4;
            this.listViewParkhaeuser.UseCompatibleStateImageBehavior = false;
            this.listViewParkhaeuser.SelectedIndexChanged += new System.EventHandler(this.listViewParkhaeuser_SelectedIndexChanged);
            // 
            // columnNummer
            // 
            this.columnNummer.Text = "Nummer";
            this.columnNummer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // columnPLZ
            // 
            this.columnPLZ.Text = "PLZ";
            // 
            // columnOrt
            // 
            this.columnOrt.Text = "Ort";
            // 
            // columnStrasse
            // 
            this.columnStrasse.Text = "Strasse";
            // 
            // columnPKW
            // 
            this.columnPKW.Text = "PKW";
            // 
            // columnLKW
            // 
            this.columnLKW.Text = "LKW";
            // 
            // columnMotorad
            // 
            this.columnMotorad.Text = "Motorrad";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.buttonParkhausHinzufuegen, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonParkhausEntfernen, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonParkhausBearbeiten, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(2, 439);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(499, 38);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // buttonParkhausHinzufuegen
            // 
            this.buttonParkhausHinzufuegen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonParkhausHinzufuegen.Location = new System.Drawing.Point(2, 2);
            this.buttonParkhausHinzufuegen.Margin = new System.Windows.Forms.Padding(2);
            this.buttonParkhausHinzufuegen.Name = "buttonParkhausHinzufuegen";
            this.buttonParkhausHinzufuegen.Size = new System.Drawing.Size(162, 34);
            this.buttonParkhausHinzufuegen.TabIndex = 0;
            this.buttonParkhausHinzufuegen.Text = "Hinzfügen";
            this.buttonParkhausHinzufuegen.UseVisualStyleBackColor = true;
            this.buttonParkhausHinzufuegen.Click += new System.EventHandler(this.buttonParkhausHinzufuegen_Click);
            // 
            // buttonParkhausEntfernen
            // 
            this.buttonParkhausEntfernen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonParkhausEntfernen.Enabled = false;
            this.buttonParkhausEntfernen.Location = new System.Drawing.Point(168, 2);
            this.buttonParkhausEntfernen.Margin = new System.Windows.Forms.Padding(2);
            this.buttonParkhausEntfernen.Name = "buttonParkhausEntfernen";
            this.buttonParkhausEntfernen.Size = new System.Drawing.Size(162, 34);
            this.buttonParkhausEntfernen.TabIndex = 1;
            this.buttonParkhausEntfernen.Text = "Löschen";
            this.buttonParkhausEntfernen.UseVisualStyleBackColor = true;
            this.buttonParkhausEntfernen.Click += new System.EventHandler(this.buttonParkhausEntfernen_Click);
            // 
            // buttonParkhausBearbeiten
            // 
            this.buttonParkhausBearbeiten.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonParkhausBearbeiten.Enabled = false;
            this.buttonParkhausBearbeiten.Location = new System.Drawing.Point(334, 2);
            this.buttonParkhausBearbeiten.Margin = new System.Windows.Forms.Padding(2);
            this.buttonParkhausBearbeiten.Name = "buttonParkhausBearbeiten";
            this.buttonParkhausBearbeiten.Size = new System.Drawing.Size(163, 34);
            this.buttonParkhausBearbeiten.TabIndex = 2;
            this.buttonParkhausBearbeiten.Text = "Bearbeiten";
            this.buttonParkhausBearbeiten.UseVisualStyleBackColor = true;
            this.buttonParkhausBearbeiten.Click += new System.EventHandler(this.buttonParkhausBearbeiten_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Parkhäuser";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Controls.Add(this.buttonFahrzeugHinzufuegen, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.buttonFahrzeugEntfernen, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.buttonFahrzeugBearbeiten, 2, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(505, 439);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(582, 38);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // buttonFahrzeugHinzufuegen
            // 
            this.buttonFahrzeugHinzufuegen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonFahrzeugHinzufuegen.Location = new System.Drawing.Point(2, 2);
            this.buttonFahrzeugHinzufuegen.Margin = new System.Windows.Forms.Padding(2);
            this.buttonFahrzeugHinzufuegen.Name = "buttonFahrzeugHinzufuegen";
            this.buttonFahrzeugHinzufuegen.Size = new System.Drawing.Size(190, 34);
            this.buttonFahrzeugHinzufuegen.TabIndex = 0;
            this.buttonFahrzeugHinzufuegen.Text = "Hinzufügen";
            this.buttonFahrzeugHinzufuegen.UseVisualStyleBackColor = true;
            this.buttonFahrzeugHinzufuegen.Click += new System.EventHandler(this.buttonFahrzeugHinzufuegen_Click);
            // 
            // buttonFahrzeugEntfernen
            // 
            this.buttonFahrzeugEntfernen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonFahrzeugEntfernen.Enabled = false;
            this.buttonFahrzeugEntfernen.Location = new System.Drawing.Point(196, 2);
            this.buttonFahrzeugEntfernen.Margin = new System.Windows.Forms.Padding(2);
            this.buttonFahrzeugEntfernen.Name = "buttonFahrzeugEntfernen";
            this.buttonFahrzeugEntfernen.Size = new System.Drawing.Size(190, 34);
            this.buttonFahrzeugEntfernen.TabIndex = 1;
            this.buttonFahrzeugEntfernen.Text = "Löschen";
            this.buttonFahrzeugEntfernen.UseVisualStyleBackColor = true;
            this.buttonFahrzeugEntfernen.Click += new System.EventHandler(this.buttonFahrzeugEntfernen_Click);
            // 
            // buttonFahrzeugBearbeiten
            // 
            this.buttonFahrzeugBearbeiten.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonFahrzeugBearbeiten.Enabled = false;
            this.buttonFahrzeugBearbeiten.Location = new System.Drawing.Point(390, 2);
            this.buttonFahrzeugBearbeiten.Margin = new System.Windows.Forms.Padding(2);
            this.buttonFahrzeugBearbeiten.Name = "buttonFahrzeugBearbeiten";
            this.buttonFahrzeugBearbeiten.Size = new System.Drawing.Size(190, 34);
            this.buttonFahrzeugBearbeiten.TabIndex = 2;
            this.buttonFahrzeugBearbeiten.Text = "Bearbeiten";
            this.buttonFahrzeugBearbeiten.UseVisualStyleBackColor = true;
            this.buttonFahrzeugBearbeiten.Click += new System.EventHandler(this.buttonFahrzeugBearbeiten_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 4;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 307F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.label4, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.labelSteuerGesamt, 3, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(505, 2);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(582, 22);
            this.tableLayoutPanel4.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 4);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fahrzeuge";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(370, 4);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Steuer gesamt";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 4);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 6;
            // 
            // labelSteuerGesamt
            // 
            this.labelSteuerGesamt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelSteuerGesamt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelSteuerGesamt.Location = new System.Drawing.Point(449, 0);
            this.labelSteuerGesamt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSteuerGesamt.Name = "labelSteuerGesamt";
            this.labelSteuerGesamt.Size = new System.Drawing.Size(131, 22);
            this.labelSteuerGesamt.TabIndex = 7;
            this.labelSteuerGesamt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FormVerwaltung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 479);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormVerwaltung";
            this.Text = "Fahrzeugverwaltung";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormVerwaltung_Closing);
            this.Load += new System.EventHandler(this.FormVerwaltung_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button buttonFahrzeugHinzufuegen;
        private System.Windows.Forms.Button buttonFahrzeugEntfernen;
        private System.Windows.Forms.Button buttonFahrzeugBearbeiten;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button buttonParkhausHinzufuegen;
        private System.Windows.Forms.Button buttonParkhausEntfernen;
        private System.Windows.Forms.Button buttonParkhausBearbeiten;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewFahrzeuge;
        private System.Windows.Forms.ColumnHeader columnTyp;
        private System.Windows.Forms.ColumnHeader columnHersteller;
        private System.Windows.Forms.ColumnHeader columnModell;
        private System.Windows.Forms.ColumnHeader columnKennzeichen;
        private System.Windows.Forms.ColumnHeader columnParkhaus;
        private System.Windows.Forms.ColumnHeader columnStellplatz;
        private System.Windows.Forms.ColumnHeader columnJahrErstzulassung;
        private System.Windows.Forms.ColumnHeader columnPreis;
        private System.Windows.Forms.ListView listViewParkhaeuser;
        private System.Windows.Forms.ColumnHeader columnNummer;
        private System.Windows.Forms.ColumnHeader columnPLZ;
        private System.Windows.Forms.ColumnHeader columnOrt;
        private System.Windows.Forms.ColumnHeader columnStrasse;
        private System.Windows.Forms.ColumnHeader columnPKW;
        private System.Windows.Forms.ColumnHeader columnLKW;
        private System.Windows.Forms.ColumnHeader columnMotorad;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelSteuerGesamt;
        private System.Windows.Forms.ColumnHeader columnSteuer;

    }
}

