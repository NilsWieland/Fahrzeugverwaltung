namespace Fahrzeugverwaltung
{
    partial class FormParkhausHinzufuegen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxPLZ = new System.Windows.Forms.TextBox();
            this.textBoxAnzahlParkplaetze = new System.Windows.Forms.TextBox();
            this.textBoxOrt = new System.Windows.Forms.TextBox();
            this.textBoxStrasse = new System.Windows.Forms.TextBox();
            this.labelParkplaetze = new System.Windows.Forms.Label();
            this.labelStrasse = new System.Windows.Forms.Label();
            this.labelOrt = new System.Windows.Forms.Label();
            this.labelPLZ = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonUebernehmen = new System.Windows.Forms.Button();
            this.buttonAbbrechen = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(447, 144);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.61571F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.05095F));
            this.tableLayoutPanel3.Controls.Add(this.textBoxPLZ, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.textBoxAnzahlParkplaetze, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.textBoxOrt, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.textBoxStrasse, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.labelParkplaetze, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.labelStrasse, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.labelOrt, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.labelPLZ, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(441, 98);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // textBoxPLZ
            // 
            this.textBoxPLZ.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBoxPLZ.Location = new System.Drawing.Point(73, 3);
            this.textBoxPLZ.Name = "textBoxPLZ";
            this.textBoxPLZ.Size = new System.Drawing.Size(72, 20);
            this.textBoxPLZ.TabIndex = 1;
            this.textBoxPLZ.TextChanged += new System.EventHandler(this.textBoxPLZ_TextChanged);
            // 
            // textBoxAnzahlParkplaetze
            // 
            this.textBoxAnzahlParkplaetze.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBoxAnzahlParkplaetze.Location = new System.Drawing.Point(73, 75);
            this.textBoxAnzahlParkplaetze.Name = "textBoxAnzahlParkplaetze";
            this.textBoxAnzahlParkplaetze.Size = new System.Drawing.Size(72, 20);
            this.textBoxAnzahlParkplaetze.TabIndex = 4;
            this.textBoxAnzahlParkplaetze.TextChanged += new System.EventHandler(this.textBoxAnzahlParkplaetze_TextChanged);
            // 
            // textBoxOrt
            // 
            this.textBoxOrt.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBoxOrt.Location = new System.Drawing.Point(73, 27);
            this.textBoxOrt.Name = "textBoxOrt";
            this.textBoxOrt.Size = new System.Drawing.Size(322, 20);
            this.textBoxOrt.TabIndex = 2;
            this.textBoxOrt.TextChanged += new System.EventHandler(this.textBoxOrt_TextChanged);
            // 
            // textBoxStrasse
            // 
            this.textBoxStrasse.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBoxStrasse.Location = new System.Drawing.Point(73, 51);
            this.textBoxStrasse.Name = "textBoxStrasse";
            this.textBoxStrasse.Size = new System.Drawing.Size(322, 20);
            this.textBoxStrasse.TabIndex = 3;
            this.textBoxStrasse.TextChanged += new System.EventHandler(this.textBoxStrasse_TextChanged);
            // 
            // labelParkplaetze
            // 
            this.labelParkplaetze.AutoSize = true;
            this.labelParkplaetze.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelParkplaetze.Location = new System.Drawing.Point(3, 72);
            this.labelParkplaetze.Name = "labelParkplaetze";
            this.labelParkplaetze.Size = new System.Drawing.Size(57, 26);
            this.labelParkplaetze.TabIndex = 4;
            this.labelParkplaetze.Text = "Parkplätze";
            this.labelParkplaetze.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelStrasse
            // 
            this.labelStrasse.AutoSize = true;
            this.labelStrasse.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelStrasse.Location = new System.Drawing.Point(3, 48);
            this.labelStrasse.Name = "labelStrasse";
            this.labelStrasse.Size = new System.Drawing.Size(42, 24);
            this.labelStrasse.TabIndex = 3;
            this.labelStrasse.Text = "Strasse";
            this.labelStrasse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelOrt
            // 
            this.labelOrt.AutoSize = true;
            this.labelOrt.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelOrt.Location = new System.Drawing.Point(3, 24);
            this.labelOrt.Name = "labelOrt";
            this.labelOrt.Size = new System.Drawing.Size(21, 24);
            this.labelOrt.TabIndex = 2;
            this.labelOrt.Text = "Ort";
            this.labelOrt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelPLZ
            // 
            this.labelPLZ.AutoSize = true;
            this.labelPLZ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelPLZ.Location = new System.Drawing.Point(3, 0);
            this.labelPLZ.Name = "labelPLZ";
            this.labelPLZ.Size = new System.Drawing.Size(64, 24);
            this.labelPLZ.TabIndex = 1;
            this.labelPLZ.Text = "PLZ";
            this.labelPLZ.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.28224F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.13869F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.82238F));
            this.tableLayoutPanel2.Controls.Add(this.buttonUebernehmen, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonAbbrechen, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 107);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(441, 34);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // buttonUebernehmen
            // 
            this.buttonUebernehmen.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonUebernehmen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonUebernehmen.Location = new System.Drawing.Point(2, 2);
            this.buttonUebernehmen.Margin = new System.Windows.Forms.Padding(2);
            this.buttonUebernehmen.Name = "buttonUebernehmen";
            this.buttonUebernehmen.Size = new System.Drawing.Size(190, 30);
            this.buttonUebernehmen.TabIndex = 5;
            this.buttonUebernehmen.Text = "Übernehmen";
            this.buttonUebernehmen.UseVisualStyleBackColor = true;
            this.buttonUebernehmen.Click += new System.EventHandler(this.buttonUebernehmen_Click);
            // 
            // buttonAbbrechen
            // 
            this.buttonAbbrechen.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonAbbrechen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAbbrechen.Location = new System.Drawing.Point(253, 2);
            this.buttonAbbrechen.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAbbrechen.Name = "buttonAbbrechen";
            this.buttonAbbrechen.Size = new System.Drawing.Size(186, 30);
            this.buttonAbbrechen.TabIndex = 6;
            this.buttonAbbrechen.Text = "Abbrechen";
            this.buttonAbbrechen.UseVisualStyleBackColor = true;
            // 
            // FormParkhausHinzufuegen
            // 
            this.AcceptButton = this.buttonUebernehmen;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonAbbrechen;
            this.ClientSize = new System.Drawing.Size(447, 144);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormParkhausHinzufuegen";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Parkhaus hinzufügen";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox textBoxPLZ;
        private System.Windows.Forms.TextBox textBoxAnzahlParkplaetze;
        private System.Windows.Forms.TextBox textBoxOrt;
        private System.Windows.Forms.TextBox textBoxStrasse;
        private System.Windows.Forms.Label labelParkplaetze;
        private System.Windows.Forms.Label labelStrasse;
        private System.Windows.Forms.Label labelOrt;
        private System.Windows.Forms.Label labelPLZ;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button buttonUebernehmen;
        private System.Windows.Forms.Button buttonAbbrechen;
    }
}