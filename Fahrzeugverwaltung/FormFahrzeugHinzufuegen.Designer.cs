namespace Fahrzeugverwaltung
{
    partial class FormFahrzeugHinzufuegen
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
            this.buttonUebernehmen = new System.Windows.Forms.Button();
            this.buttonAbbrechen = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxUnbestimmt_3 = new System.Windows.Forms.TextBox();
            this.textBoxUnbestimmt_2 = new System.Windows.Forms.TextBox();
            this.textBoxUnbestimmt_1 = new System.Windows.Forms.TextBox();
            this.textBoxKennzeichen = new System.Windows.Forms.TextBox();
            this.textBoxAnschaffungspreis = new System.Windows.Forms.TextBox();
            this.textBoxErstzulassung = new System.Windows.Forms.TextBox();
            this.textBoxModell = new System.Windows.Forms.TextBox();
            this.labelHersteller = new System.Windows.Forms.Label();
            this.labelUnbestimmt_3 = new System.Windows.Forms.Label();
            this.labelUnbestimmt_2 = new System.Windows.Forms.Label();
            this.labelUnbestimmt_1 = new System.Windows.Forms.Label();
            this.labelKennzeichen = new System.Windows.Forms.Label();
            this.labelAnschaffungspreis = new System.Windows.Forms.Label();
            this.labelErstzulassung = new System.Windows.Forms.Label();
            this.labelModel = new System.Windows.Forms.Label();
            this.textBoxHersteller = new System.Windows.Forms.TextBox();
            this.comboBoxFahrzeugTyp = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxFahrzeugTyp, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(630, 312);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.8141F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.76923F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.25641F));
            this.tableLayoutPanel3.Controls.Add(this.buttonUebernehmen, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.buttonAbbrechen, 2, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 275);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(624, 34);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // buttonUebernehmen
            // 
            this.buttonUebernehmen.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonUebernehmen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonUebernehmen.Enabled = false;
            this.buttonUebernehmen.Location = new System.Drawing.Point(2, 2);
            this.buttonUebernehmen.Margin = new System.Windows.Forms.Padding(2);
            this.buttonUebernehmen.Name = "buttonUebernehmen";
            this.buttonUebernehmen.Size = new System.Drawing.Size(207, 30);
            this.buttonUebernehmen.TabIndex = 10;
            this.buttonUebernehmen.Text = "Übernehmen";
            this.buttonUebernehmen.UseVisualStyleBackColor = true;
            this.buttonUebernehmen.Click += new System.EventHandler(this.buttonUebernehmen_Click);
            // 
            // buttonAbbrechen
            // 
            this.buttonAbbrechen.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonAbbrechen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAbbrechen.Location = new System.Drawing.Point(405, 2);
            this.buttonAbbrechen.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAbbrechen.Name = "buttonAbbrechen";
            this.buttonAbbrechen.Size = new System.Drawing.Size(217, 30);
            this.buttonAbbrechen.TabIndex = 11;
            this.buttonAbbrechen.Text = "Abbrechen";
            this.buttonAbbrechen.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.72436F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.27564F));
            this.tableLayoutPanel2.Controls.Add(this.textBoxUnbestimmt_3, 1, 7);
            this.tableLayoutPanel2.Controls.Add(this.textBoxUnbestimmt_2, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.textBoxUnbestimmt_1, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.textBoxKennzeichen, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.textBoxAnschaffungspreis, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.textBoxErstzulassung, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.textBoxModell, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.labelHersteller, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelUnbestimmt_3, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.labelUnbestimmt_2, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.labelUnbestimmt_1, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.labelKennzeichen, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.labelAnschaffungspreis, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.labelErstzulassung, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.labelModel, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.textBoxHersteller, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 30);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 8;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(624, 239);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // textBoxUnbestimmt_3
            // 
            this.textBoxUnbestimmt_3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxUnbestimmt_3.Location = new System.Drawing.Point(332, 211);
            this.textBoxUnbestimmt_3.Name = "textBoxUnbestimmt_3";
            this.textBoxUnbestimmt_3.Size = new System.Drawing.Size(200, 20);
            this.textBoxUnbestimmt_3.TabIndex = 9;
            this.textBoxUnbestimmt_3.TextChanged += new System.EventHandler(this.textBoxUnbestimmt_3_TextChanged);
            // 
            // textBoxUnbestimmt_2
            // 
            this.textBoxUnbestimmt_2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxUnbestimmt_2.Location = new System.Drawing.Point(332, 178);
            this.textBoxUnbestimmt_2.Name = "textBoxUnbestimmt_2";
            this.textBoxUnbestimmt_2.Size = new System.Drawing.Size(200, 20);
            this.textBoxUnbestimmt_2.TabIndex = 8;
            this.textBoxUnbestimmt_2.TextChanged += new System.EventHandler(this.textBoxUnbestimmt_2_TextChanged);
            // 
            // textBoxUnbestimmt_1
            // 
            this.textBoxUnbestimmt_1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxUnbestimmt_1.Location = new System.Drawing.Point(332, 149);
            this.textBoxUnbestimmt_1.Name = "textBoxUnbestimmt_1";
            this.textBoxUnbestimmt_1.Size = new System.Drawing.Size(200, 20);
            this.textBoxUnbestimmt_1.TabIndex = 7;
            this.textBoxUnbestimmt_1.TextChanged += new System.EventHandler(this.textBoxUnbestimmt_1_TextChanged);
            // 
            // textBoxKennzeichen
            // 
            this.textBoxKennzeichen.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxKennzeichen.Location = new System.Drawing.Point(332, 120);
            this.textBoxKennzeichen.Name = "textBoxKennzeichen";
            this.textBoxKennzeichen.Size = new System.Drawing.Size(200, 20);
            this.textBoxKennzeichen.TabIndex = 6;
            this.textBoxKennzeichen.TextChanged += new System.EventHandler(this.textBoxKennzeichen_TextChanged);
            // 
            // textBoxAnschaffungspreis
            // 
            this.textBoxAnschaffungspreis.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxAnschaffungspreis.Location = new System.Drawing.Point(332, 91);
            this.textBoxAnschaffungspreis.Name = "textBoxAnschaffungspreis";
            this.textBoxAnschaffungspreis.Size = new System.Drawing.Size(200, 20);
            this.textBoxAnschaffungspreis.TabIndex = 5;
            this.textBoxAnschaffungspreis.TextChanged += new System.EventHandler(this.textBoxAnschaffungspreis_TextChanged);
            // 
            // textBoxErstzulassung
            // 
            this.textBoxErstzulassung.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxErstzulassung.Location = new System.Drawing.Point(332, 62);
            this.textBoxErstzulassung.Name = "textBoxErstzulassung";
            this.textBoxErstzulassung.Size = new System.Drawing.Size(200, 20);
            this.textBoxErstzulassung.TabIndex = 4;
            this.textBoxErstzulassung.TextChanged += new System.EventHandler(this.textBoxErstzulassung_TextChanged);
            // 
            // textBoxModell
            // 
            this.textBoxModell.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxModell.Location = new System.Drawing.Point(332, 33);
            this.textBoxModell.Name = "textBoxModell";
            this.textBoxModell.Size = new System.Drawing.Size(200, 20);
            this.textBoxModell.TabIndex = 3;
            this.textBoxModell.TextChanged += new System.EventHandler(this.textBoxModell_TextChanged);
            // 
            // labelHersteller
            // 
            this.labelHersteller.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelHersteller.AutoSize = true;
            this.labelHersteller.Location = new System.Drawing.Point(3, 8);
            this.labelHersteller.Name = "labelHersteller";
            this.labelHersteller.Size = new System.Drawing.Size(135, 13);
            this.labelHersteller.TabIndex = 0;
            this.labelHersteller.Text = "Hersteller (2 - 100 Zeichen)";
            // 
            // labelUnbestimmt_3
            // 
            this.labelUnbestimmt_3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelUnbestimmt_3.AutoSize = true;
            this.labelUnbestimmt_3.Location = new System.Drawing.Point(3, 214);
            this.labelUnbestimmt_3.Name = "labelUnbestimmt_3";
            this.labelUnbestimmt_3.Size = new System.Drawing.Size(56, 13);
            this.labelUnbestimmt_3.TabIndex = 6;
            this.labelUnbestimmt_3.Text = "Undefined";
            // 
            // labelUnbestimmt_2
            // 
            this.labelUnbestimmt_2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelUnbestimmt_2.AutoSize = true;
            this.labelUnbestimmt_2.Location = new System.Drawing.Point(3, 182);
            this.labelUnbestimmt_2.Name = "labelUnbestimmt_2";
            this.labelUnbestimmt_2.Size = new System.Drawing.Size(56, 13);
            this.labelUnbestimmt_2.TabIndex = 4;
            this.labelUnbestimmt_2.Text = "Undefined";
            // 
            // labelUnbestimmt_1
            // 
            this.labelUnbestimmt_1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelUnbestimmt_1.AutoSize = true;
            this.labelUnbestimmt_1.Location = new System.Drawing.Point(3, 153);
            this.labelUnbestimmt_1.Name = "labelUnbestimmt_1";
            this.labelUnbestimmt_1.Size = new System.Drawing.Size(56, 13);
            this.labelUnbestimmt_1.TabIndex = 5;
            this.labelUnbestimmt_1.Text = "Undefined";
            // 
            // labelKennzeichen
            // 
            this.labelKennzeichen.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelKennzeichen.AutoSize = true;
            this.labelKennzeichen.Location = new System.Drawing.Point(3, 124);
            this.labelKennzeichen.Name = "labelKennzeichen";
            this.labelKennzeichen.Size = new System.Drawing.Size(147, 13);
            this.labelKennzeichen.TabIndex = 3;
            this.labelKennzeichen.Text = "Kennzeichen (5 - 11 Zeichen)";
            // 
            // labelAnschaffungspreis
            // 
            this.labelAnschaffungspreis.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelAnschaffungspreis.AutoSize = true;
            this.labelAnschaffungspreis.Location = new System.Drawing.Point(3, 95);
            this.labelAnschaffungspreis.Name = "labelAnschaffungspreis";
            this.labelAnschaffungspreis.Size = new System.Drawing.Size(169, 13);
            this.labelAnschaffungspreis.TabIndex = 2;
            this.labelAnschaffungspreis.Text = "Anschaffungspreis (0 - 1000000 €)";
            // 
            // labelErstzulassung
            // 
            this.labelErstzulassung.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelErstzulassung.AutoSize = true;
            this.labelErstzulassung.Location = new System.Drawing.Point(3, 66);
            this.labelErstzulassung.Name = "labelErstzulassung";
            this.labelErstzulassung.Size = new System.Drawing.Size(166, 13);
            this.labelErstzulassung.TabIndex = 1;
            this.labelErstzulassung.Text = "Jahr Erstzulassung (1900 bis jetzt)";
            // 
            // labelModel
            // 
            this.labelModel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelModel.AutoSize = true;
            this.labelModel.Location = new System.Drawing.Point(3, 37);
            this.labelModel.Name = "labelModel";
            this.labelModel.Size = new System.Drawing.Size(122, 13);
            this.labelModel.TabIndex = 9;
            this.labelModel.Text = "Modell (2 - 100 Zeichen)";
            // 
            // textBoxHersteller
            // 
            this.textBoxHersteller.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxHersteller.Location = new System.Drawing.Point(332, 4);
            this.textBoxHersteller.Name = "textBoxHersteller";
            this.textBoxHersteller.Size = new System.Drawing.Size(200, 20);
            this.textBoxHersteller.TabIndex = 2;
            this.textBoxHersteller.TextChanged += new System.EventHandler(this.textBoxHersteller_TextChanged);
            // 
            // comboBoxFahrzeugTyp
            // 
            this.comboBoxFahrzeugTyp.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBoxFahrzeugTyp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFahrzeugTyp.FormattingEnabled = true;
            this.comboBoxFahrzeugTyp.Items.AddRange(new object[] {
            "PKW",
            "LKW",
            "Motorrad"});
            this.comboBoxFahrzeugTyp.Location = new System.Drawing.Point(3, 3);
            this.comboBoxFahrzeugTyp.Name = "comboBoxFahrzeugTyp";
            this.comboBoxFahrzeugTyp.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFahrzeugTyp.TabIndex = 1;
            this.comboBoxFahrzeugTyp.SelectedIndexChanged += new System.EventHandler(this.comboBoxFahrzeugTyp_SelectedIndexChanged);
            // 
            // FormFahrzeugHinzufuegen
            // 
            this.AcceptButton = this.buttonUebernehmen;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonAbbrechen;
            this.ClientSize = new System.Drawing.Size(630, 312);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormFahrzeugHinzufuegen";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Fahrzeughinzufügen";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button buttonUebernehmen;
        private System.Windows.Forms.Button buttonAbbrechen;
        private System.Windows.Forms.ComboBox comboBoxFahrzeugTyp;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox textBoxUnbestimmt_3;
        private System.Windows.Forms.TextBox textBoxUnbestimmt_2;
        private System.Windows.Forms.TextBox textBoxUnbestimmt_1;
        private System.Windows.Forms.TextBox textBoxKennzeichen;
        private System.Windows.Forms.TextBox textBoxAnschaffungspreis;
        private System.Windows.Forms.TextBox textBoxErstzulassung;
        private System.Windows.Forms.TextBox textBoxModell;
        private System.Windows.Forms.Label labelHersteller;
        private System.Windows.Forms.Label labelUnbestimmt_3;
        private System.Windows.Forms.Label labelUnbestimmt_2;
        private System.Windows.Forms.Label labelUnbestimmt_1;
        private System.Windows.Forms.Label labelKennzeichen;
        private System.Windows.Forms.Label labelAnschaffungspreis;
        private System.Windows.Forms.Label labelErstzulassung;
        private System.Windows.Forms.Label labelModel;
        private System.Windows.Forms.TextBox textBoxHersteller;
    }
}