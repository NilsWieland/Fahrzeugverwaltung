namespace Fahrzeugverwaltung
{
    partial class Form1
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonHinzufuegen = new System.Windows.Forms.Button();
            this.buttonLoeschen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonBearbeiten = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonHinzufügen2 = new System.Windows.Forms.Button();
            this.buttonLöschen2 = new System.Windows.Forms.Button();
            this.buttonBearbeiten2 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.792208F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.20779F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.buttonHinzufuegen, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonLoeschen, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonBearbeiten, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 388);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(394, 59);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // buttonHinzufuegen
            // 
            this.buttonHinzufuegen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonHinzufuegen.Location = new System.Drawing.Point(3, 3);
            this.buttonHinzufuegen.Name = "buttonHinzufuegen";
            this.buttonHinzufuegen.Size = new System.Drawing.Size(125, 53);
            this.buttonHinzufuegen.TabIndex = 0;
            this.buttonHinzufuegen.Text = "Hinzfügen";
            this.buttonHinzufuegen.UseVisualStyleBackColor = true;
            // 
            // buttonLoeschen
            // 
            this.buttonLoeschen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonLoeschen.Location = new System.Drawing.Point(134, 3);
            this.buttonLoeschen.Name = "buttonLoeschen";
            this.buttonLoeschen.Size = new System.Drawing.Size(125, 53);
            this.buttonLoeschen.TabIndex = 1;
            this.buttonLoeschen.Text = "Löschen";
            this.buttonLoeschen.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Parkhäuser";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(403, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fahrzeuge";
            // 
            // buttonBearbeiten
            // 
            this.buttonBearbeiten.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonBearbeiten.Location = new System.Drawing.Point(265, 3);
            this.buttonBearbeiten.Name = "buttonBearbeiten";
            this.buttonBearbeiten.Size = new System.Drawing.Size(126, 53);
            this.buttonBearbeiten.TabIndex = 2;
            this.buttonBearbeiten.Text = "Bearbeiten";
            this.buttonBearbeiten.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Controls.Add(this.buttonHinzufügen2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.buttonLöschen2, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.buttonBearbeiten2, 2, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(403, 388);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(394, 59);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // buttonHinzufügen2
            // 
            this.buttonHinzufügen2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonHinzufügen2.Location = new System.Drawing.Point(3, 3);
            this.buttonHinzufügen2.Name = "buttonHinzufügen2";
            this.buttonHinzufügen2.Size = new System.Drawing.Size(125, 53);
            this.buttonHinzufügen2.TabIndex = 0;
            this.buttonHinzufügen2.Text = "Hinzufügen";
            this.buttonHinzufügen2.UseVisualStyleBackColor = true;
            // 
            // buttonLöschen2
            // 
            this.buttonLöschen2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonLöschen2.Location = new System.Drawing.Point(134, 3);
            this.buttonLöschen2.Name = "buttonLöschen2";
            this.buttonLöschen2.Size = new System.Drawing.Size(125, 53);
            this.buttonLöschen2.TabIndex = 1;
            this.buttonLöschen2.Text = "Löschen";
            this.buttonLöschen2.UseVisualStyleBackColor = true;
            // 
            // buttonBearbeiten2
            // 
            this.buttonBearbeiten2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonBearbeiten2.Location = new System.Drawing.Point(265, 3);
            this.buttonBearbeiten2.Name = "buttonBearbeiten2";
            this.buttonBearbeiten2.Size = new System.Drawing.Size(126, 53);
            this.buttonBearbeiten2.TabIndex = 2;
            this.buttonBearbeiten2.Text = "Bearbeiten";
            this.buttonBearbeiten2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button buttonHinzufuegen;
        private System.Windows.Forms.Button buttonLoeschen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonBearbeiten;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button buttonHinzufügen2;
        private System.Windows.Forms.Button buttonLöschen2;
        private System.Windows.Forms.Button buttonBearbeiten2;
    }
}

