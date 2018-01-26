namespace MLZ_Bootsverwaltung
{
    partial class MainForm
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
            this.LblMarke = new System.Windows.Forms.Label();
            this.TxbMarke = new System.Windows.Forms.TextBox();
            this.LblModell = new System.Windows.Forms.Label();
            this.TxbModell = new System.Windows.Forms.TextBox();
            this.LblFarbe = new System.Windows.Forms.Label();
            this.CmbFarbe = new System.Windows.Forms.ComboBox();
            this.LblNummernschild = new System.Windows.Forms.Label();
            this.TxbNummernschild = new System.Windows.Forms.TextBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnMutieren = new System.Windows.Forms.Button();
            this.BtnListe = new System.Windows.Forms.Button();
            this.LbxBootsliste = new System.Windows.Forms.ListBox();
            this.LblErfassenMutieren = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LblAnzahlBoote = new System.Windows.Forms.Label();
            this.TxbAnzBoote = new System.Windows.Forms.TextBox();
            this.LblTyp = new System.Windows.Forms.Label();
            this.CmbTyp = new System.Windows.Forms.ComboBox();
            this.LblLaenge = new System.Windows.Forms.Label();
            this.TxBLaenge = new System.Windows.Forms.TextBox();
            this.LblBreite = new System.Windows.Forms.Label();
            this.TxbBreite = new System.Windows.Forms.TextBox();
            this.LblHoehe = new System.Windows.Forms.Label();
            this.LblTagesmiete = new System.Windows.Forms.Label();
            this.TxbTagesmiete = new System.Windows.Forms.TextBox();
            this.LblPS = new System.Windows.Forms.Label();
            this.TxbPS = new System.Windows.Forms.TextBox();
            this.LblMaxSpeedMotor = new System.Windows.Forms.Label();
            this.TxbSpeedMotor = new System.Windows.Forms.TextBox();
            this.LblMaxSpeedSegel = new System.Windows.Forms.Label();
            this.TxbSpeedSegel = new System.Windows.Forms.TextBox();
            this.TxBHoehe = new System.Windows.Forms.TextBox();
            this.LblAnzahlPersonen = new System.Windows.Forms.Label();
            this.TxbAnzahlPersonen = new System.Windows.Forms.TextBox();
            this.Lbl_Gesellschaft = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.BtnBildAnzeigen = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblMarke
            // 
            this.LblMarke.AutoSize = true;
            this.LblMarke.Location = new System.Drawing.Point(547, 81);
            this.LblMarke.Name = "LblMarke";
            this.LblMarke.Size = new System.Drawing.Size(37, 13);
            this.LblMarke.TabIndex = 2;
            this.LblMarke.Text = "Marke";
            // 
            // TxbMarke
            // 
            this.TxbMarke.Location = new System.Drawing.Point(647, 74);
            this.TxbMarke.Name = "TxbMarke";
            this.TxbMarke.Size = new System.Drawing.Size(266, 20);
            this.TxbMarke.TabIndex = 3;
     //       this.TxbMarke.TextChanged += new System.EventHandler(this.TxbMarke_TextChanged);
            // 
            // LblModell
            // 
            this.LblModell.AutoSize = true;
            this.LblModell.Location = new System.Drawing.Point(547, 107);
            this.LblModell.Name = "LblModell";
            this.LblModell.Size = new System.Drawing.Size(38, 13);
            this.LblModell.TabIndex = 4;
            this.LblModell.Text = "Modell";
            // 
            // TxbModell
            // 
            this.TxbModell.Location = new System.Drawing.Point(647, 100);
            this.TxbModell.Name = "TxbModell";
            this.TxbModell.Size = new System.Drawing.Size(266, 20);
            this.TxbModell.TabIndex = 5;
     //       this.TxbModell.TextChanged += new System.EventHandler(this.TxbModell_TextChanged);
            // 
            // LblFarbe
            // 
            this.LblFarbe.AutoSize = true;
            this.LblFarbe.Location = new System.Drawing.Point(547, 130);
            this.LblFarbe.Name = "LblFarbe";
            this.LblFarbe.Size = new System.Drawing.Size(34, 13);
            this.LblFarbe.TabIndex = 6;
            this.LblFarbe.Text = "Farbe";
            // 
            // CmbFarbe
            // 
            this.CmbFarbe.FormattingEnabled = true;
            this.CmbFarbe.Location = new System.Drawing.Point(647, 127);
            this.CmbFarbe.Name = "CmbFarbe";
            this.CmbFarbe.Size = new System.Drawing.Size(121, 21);
            this.CmbFarbe.TabIndex = 7;
            this.CmbFarbe.SelectedIndexChanged += new System.EventHandler(this.CmbFarbe_SelectedIndexChanged);
            // 
            // LblNummernschild
            // 
            this.LblNummernschild.AutoSize = true;
            this.LblNummernschild.Location = new System.Drawing.Point(547, 156);
            this.LblNummernschild.Name = "LblNummernschild";
            this.LblNummernschild.Size = new System.Drawing.Size(72, 13);
            this.LblNummernschild.TabIndex = 8;
            this.LblNummernschild.Text = "Nummernsch.";
            // 
            // TxbNummernschild
            // 
            this.TxbNummernschild.Location = new System.Drawing.Point(647, 153);
            this.TxbNummernschild.Name = "TxbNummernschild";
            this.TxbNummernschild.Size = new System.Drawing.Size(266, 20);
            this.TxbNummernschild.TabIndex = 9;
            this.TxbNummernschild.TextChanged += new System.EventHandler(this.TxbNummernschild_TextChanged);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(795, 381);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(64, 35);
            this.BtnSave.TabIndex = 11;
            this.BtnSave.Text = "Speichern";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(467, 384);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(59, 32);
            this.BtnDelete.TabIndex = 13;
            this.BtnDelete.Text = "Löschen";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnMutieren
            // 
            this.BtnMutieren.Location = new System.Drawing.Point(371, 384);
            this.BtnMutieren.Name = "BtnMutieren";
            this.BtnMutieren.Size = new System.Drawing.Size(69, 34);
            this.BtnMutieren.TabIndex = 14;
            this.BtnMutieren.Text = "Bearbeiten";
            this.BtnMutieren.UseVisualStyleBackColor = true;
            this.BtnMutieren.Click += new System.EventHandler(this.BtnMutieren_Click);
            // 
            // BtnListe
            // 
            this.BtnListe.Location = new System.Drawing.Point(30, 38);
            this.BtnListe.Name = "BtnListe";
            this.BtnListe.Size = new System.Drawing.Size(113, 22);
            this.BtnListe.TabIndex = 15;
            this.BtnListe.Text = "Bootsliste anzeigen";
            this.BtnListe.UseVisualStyleBackColor = true;
            this.BtnListe.Click += new System.EventHandler(this.BtnListe_Click);
            // 
            // LbxBootsliste
            // 
            this.LbxBootsliste.FormattingEnabled = true;
            this.LbxBootsliste.HorizontalScrollbar = true;
            this.LbxBootsliste.Location = new System.Drawing.Point(30, 70);
            this.LbxBootsliste.MultiColumn = true;
            this.LbxBootsliste.Name = "LbxBootsliste";
            this.LbxBootsliste.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LbxBootsliste.Size = new System.Drawing.Size(496, 303);
            this.LbxBootsliste.TabIndex = 16;
            this.LbxBootsliste.SelectedIndexChanged += new System.EventHandler(this.LbxBootsliste_SelectedIndexChanged);
            // 
            // LblErfassenMutieren
            // 
            this.LblErfassenMutieren.AutoSize = true;
            this.LblErfassenMutieren.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblErfassenMutieren.ForeColor = System.Drawing.SystemColors.MenuText;
            this.LblErfassenMutieren.Location = new System.Drawing.Point(643, 9);
            this.LblErfassenMutieren.Name = "LblErfassenMutieren";
            this.LblErfassenMutieren.Size = new System.Drawing.Size(134, 13);
            this.LblErfassenMutieren.TabIndex = 18;
            this.LblErfassenMutieren.Text = "Erfassen und Mutieren";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.beendenToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(925, 24);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // beendenToolStripMenuItem
            // 
            this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
            this.beendenToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.beendenToolStripMenuItem.Text = "Beenden";
            this.beendenToolStripMenuItem.Click += new System.EventHandler(this.beendenToolStripMenuItem_Click);
            // 
            // LblAnzahlBoote
            // 
            this.LblAnzahlBoote.AutoSize = true;
            this.LblAnzahlBoote.Location = new System.Drawing.Point(342, 38);
            this.LblAnzahlBoote.Name = "LblAnzahlBoote";
            this.LblAnzahlBoote.Size = new System.Drawing.Size(70, 13);
            this.LblAnzahlBoote.TabIndex = 20;
            this.LblAnzahlBoote.Text = "Anzahl Boote";
            // 
            // TxbAnzBoote
            // 
            this.TxbAnzBoote.Location = new System.Drawing.Point(422, 35);
            this.TxbAnzBoote.Name = "TxbAnzBoote";
            this.TxbAnzBoote.Size = new System.Drawing.Size(71, 20);
            this.TxbAnzBoote.TabIndex = 21;
            // 
            // LblTyp
            // 
            this.LblTyp.AutoSize = true;
            this.LblTyp.Location = new System.Drawing.Point(547, 55);
            this.LblTyp.Name = "LblTyp";
            this.LblTyp.Size = new System.Drawing.Size(25, 13);
            this.LblTyp.TabIndex = 22;
            this.LblTyp.Text = "Typ";
            // 
            // CmbTyp
            // 
            this.CmbTyp.FormattingEnabled = true;
            this.CmbTyp.Location = new System.Drawing.Point(647, 47);
            this.CmbTyp.Name = "CmbTyp";
            this.CmbTyp.Size = new System.Drawing.Size(121, 21);
            this.CmbTyp.TabIndex = 23;
            this.CmbTyp.SelectedIndexChanged += new System.EventHandler(this.CmbTyp_SelectedIndexChanged);
            // 
            // LblLaenge
            // 
            this.LblLaenge.AutoSize = true;
            this.LblLaenge.Location = new System.Drawing.Point(547, 187);
            this.LblLaenge.Name = "LblLaenge";
            this.LblLaenge.Size = new System.Drawing.Size(37, 13);
            this.LblLaenge.TabIndex = 24;
            this.LblLaenge.Text = "Länge";
            // 
            // TxBLaenge
            // 
            this.TxBLaenge.Location = new System.Drawing.Point(590, 185);
            this.TxBLaenge.Name = "TxBLaenge";
            this.TxBLaenge.Size = new System.Drawing.Size(52, 20);
            this.TxBLaenge.TabIndex = 25;
            this.TxBLaenge.TextChanged += new System.EventHandler(this.TxBLaenge_TextChanged);
            // 
            // LblBreite
            // 
            this.LblBreite.AutoSize = true;
            this.LblBreite.Location = new System.Drawing.Point(648, 188);
            this.LblBreite.Name = "LblBreite";
            this.LblBreite.Size = new System.Drawing.Size(34, 13);
            this.LblBreite.TabIndex = 26;
            this.LblBreite.Text = "Breite";
            // 
            // TxbBreite
            // 
            this.TxbBreite.Location = new System.Drawing.Point(688, 185);
            this.TxbBreite.Name = "TxbBreite";
            this.TxbBreite.Size = new System.Drawing.Size(52, 20);
            this.TxbBreite.TabIndex = 27;
            this.TxbBreite.TextChanged += new System.EventHandler(this.TxbBreite_TextChanged);
            // 
            // LblHoehe
            // 
            this.LblHoehe.AutoSize = true;
            this.LblHoehe.Location = new System.Drawing.Point(756, 188);
            this.LblHoehe.Name = "LblHoehe";
            this.LblHoehe.Size = new System.Drawing.Size(33, 13);
            this.LblHoehe.TabIndex = 28;
            this.LblHoehe.Text = "Höhe";
            // 
            // LblTagesmiete
            // 
            this.LblTagesmiete.AutoSize = true;
            this.LblTagesmiete.Location = new System.Drawing.Point(547, 224);
            this.LblTagesmiete.Name = "LblTagesmiete";
            this.LblTagesmiete.Size = new System.Drawing.Size(62, 13);
            this.LblTagesmiete.TabIndex = 30;
            this.LblTagesmiete.Text = "Tagesmiete";
            // 
            // TxbTagesmiete
            // 
            this.TxbTagesmiete.Location = new System.Drawing.Point(647, 217);
            this.TxbTagesmiete.Name = "TxbTagesmiete";
            this.TxbTagesmiete.Size = new System.Drawing.Size(119, 20);
            this.TxbTagesmiete.TabIndex = 31;
            this.TxbTagesmiete.TextChanged += new System.EventHandler(this.TxbTagesmiete_TextChanged);
            // 
            // LblPS
            // 
            this.LblPS.AutoSize = true;
            this.LblPS.Location = new System.Drawing.Point(547, 280);
            this.LblPS.Name = "LblPS";
            this.LblPS.Size = new System.Drawing.Size(21, 13);
            this.LblPS.TabIndex = 34;
            this.LblPS.Text = "PS";
            // 
            // TxbPS
            // 
            this.TxbPS.Location = new System.Drawing.Point(647, 277);
            this.TxbPS.Name = "TxbPS";
            this.TxbPS.Size = new System.Drawing.Size(121, 20);
            this.TxbPS.TabIndex = 35;
            this.TxbPS.TextChanged += new System.EventHandler(this.TxbPS_TextChanged);
            // 
            // LblMaxSpeedMotor
            // 
            this.LblMaxSpeedMotor.AutoSize = true;
            this.LblMaxSpeedMotor.Location = new System.Drawing.Point(547, 313);
            this.LblMaxSpeedMotor.Name = "LblMaxSpeedMotor";
            this.LblMaxSpeedMotor.Size = new System.Drawing.Size(94, 13);
            this.LblMaxSpeedMotor.TabIndex = 36;
            this.LblMaxSpeedMotor.Text = "Max. Speed Motor";
            // 
            // TxbSpeedMotor
            // 
            this.TxbSpeedMotor.Location = new System.Drawing.Point(647, 310);
            this.TxbSpeedMotor.Name = "TxbSpeedMotor";
            this.TxbSpeedMotor.Size = new System.Drawing.Size(121, 20);
            this.TxbSpeedMotor.TabIndex = 37;
            this.TxbSpeedMotor.TextChanged += new System.EventHandler(this.TxbSpeedMotor_TextChanged);
            // 
            // LblMaxSpeedSegel
            // 
            this.LblMaxSpeedSegel.AutoSize = true;
            this.LblMaxSpeedSegel.Location = new System.Drawing.Point(547, 346);
            this.LblMaxSpeedSegel.Name = "LblMaxSpeedSegel";
            this.LblMaxSpeedSegel.Size = new System.Drawing.Size(94, 13);
            this.LblMaxSpeedSegel.TabIndex = 38;
            this.LblMaxSpeedSegel.Text = "Max. Speed Segel";
            // 
            // TxbSpeedSegel
            // 
            this.TxbSpeedSegel.Location = new System.Drawing.Point(647, 343);
            this.TxbSpeedSegel.Name = "TxbSpeedSegel";
            this.TxbSpeedSegel.Size = new System.Drawing.Size(121, 20);
            this.TxbSpeedSegel.TabIndex = 39;
            this.TxbSpeedSegel.TextChanged += new System.EventHandler(this.TxbSpeedSegel_TextChanged);
            // 
            // TxBHoehe
            // 
            this.TxBHoehe.Location = new System.Drawing.Point(795, 184);
            this.TxBHoehe.Name = "TxBHoehe";
            this.TxBHoehe.Size = new System.Drawing.Size(48, 20);
            this.TxBHoehe.TabIndex = 40;
            this.TxBHoehe.TextChanged += new System.EventHandler(this.TxBHoehe_TextChanged);
            // 
            // LblAnzahlPersonen
            // 
            this.LblAnzahlPersonen.AutoSize = true;
            this.LblAnzahlPersonen.Location = new System.Drawing.Point(547, 252);
            this.LblAnzahlPersonen.Name = "LblAnzahlPersonen";
            this.LblAnzahlPersonen.Size = new System.Drawing.Size(76, 13);
            this.LblAnzahlPersonen.TabIndex = 41;
            this.LblAnzahlPersonen.Text = "Anz. Personen";
            // 
            // TxbAnzahlPersonen
            // 
            this.TxbAnzahlPersonen.Location = new System.Drawing.Point(646, 249);
            this.TxbAnzahlPersonen.Name = "TxbAnzahlPersonen";
            this.TxbAnzahlPersonen.Size = new System.Drawing.Size(120, 20);
            this.TxbAnzahlPersonen.TabIndex = 42;
            this.TxbAnzahlPersonen.TextChanged += new System.EventHandler(this.TxbAnzahlPersonen_TextChanged);
            // 
            // Lbl_Gesellschaft
            // 
            this.Lbl_Gesellschaft.AutoSize = true;
            this.Lbl_Gesellschaft.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Lbl_Gesellschaft.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Gesellschaft.Location = new System.Drawing.Point(332, 0);
            this.Lbl_Gesellschaft.Name = "Lbl_Gesellschaft";
            this.Lbl_Gesellschaft.Size = new System.Drawing.Size(144, 20);
            this.Lbl_Gesellschaft.TabIndex = 43;
            this.Lbl_Gesellschaft.Text = "Pacific Boat Rental";
            // 
            // BtnBildAnzeigen
            // 
            this.BtnBildAnzeigen.Location = new System.Drawing.Point(265, 384);
            this.BtnBildAnzeigen.Name = "BtnBildAnzeigen";
            this.BtnBildAnzeigen.Size = new System.Drawing.Size(81, 34);
            this.BtnBildAnzeigen.TabIndex = 44;
            this.BtnBildAnzeigen.Text = "Bild anzeigen";
            this.BtnBildAnzeigen.UseVisualStyleBackColor = true;
            this.BtnBildAnzeigen.Click += new System.EventHandler(this.BtnBildAnzeigen_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 451);
            this.Controls.Add(this.BtnBildAnzeigen);
            this.Controls.Add(this.Lbl_Gesellschaft);
            this.Controls.Add(this.TxbAnzahlPersonen);
            this.Controls.Add(this.LblAnzahlPersonen);
            this.Controls.Add(this.TxBHoehe);
            this.Controls.Add(this.TxbSpeedSegel);
            this.Controls.Add(this.LblMaxSpeedSegel);
            this.Controls.Add(this.TxbSpeedMotor);
            this.Controls.Add(this.LblMaxSpeedMotor);
            this.Controls.Add(this.TxbPS);
            this.Controls.Add(this.LblPS);
            this.Controls.Add(this.TxbTagesmiete);
            this.Controls.Add(this.LblTagesmiete);
            this.Controls.Add(this.LblHoehe);
            this.Controls.Add(this.TxbBreite);
            this.Controls.Add(this.LblBreite);
            this.Controls.Add(this.TxBLaenge);
            this.Controls.Add(this.LblLaenge);
            this.Controls.Add(this.CmbTyp);
            this.Controls.Add(this.LblTyp);
            this.Controls.Add(this.TxbAnzBoote);
            this.Controls.Add(this.LblAnzahlBoote);
            this.Controls.Add(this.LblErfassenMutieren);
            this.Controls.Add(this.LbxBootsliste);
            this.Controls.Add(this.BtnListe);
            this.Controls.Add(this.BtnMutieren);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.TxbNummernschild);
            this.Controls.Add(this.LblNummernschild);
            this.Controls.Add(this.CmbFarbe);
            this.Controls.Add(this.LblFarbe);
            this.Controls.Add(this.TxbModell);
            this.Controls.Add(this.LblModell);
            this.Controls.Add(this.TxbMarke);
            this.Controls.Add(this.LblMarke);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Bootsverwaltung";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LblMarke;
        private System.Windows.Forms.TextBox TxbMarke;
        private System.Windows.Forms.Label LblModell;
        private System.Windows.Forms.TextBox TxbModell;
        private System.Windows.Forms.Label LblFarbe;
        private System.Windows.Forms.ComboBox CmbFarbe;
        private System.Windows.Forms.Label LblNummernschild;
        private System.Windows.Forms.TextBox TxbNummernschild;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnMutieren;
        private System.Windows.Forms.Button BtnListe;
        private System.Windows.Forms.ListBox LbxBootsliste;
        private System.Windows.Forms.Label LblErfassenMutieren;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem beendenToolStripMenuItem;
        private System.Windows.Forms.Label LblAnzahlBoote;
        private System.Windows.Forms.TextBox TxbAnzBoote;
        private System.Windows.Forms.Label LblTyp;
        private System.Windows.Forms.ComboBox CmbTyp;
        private System.Windows.Forms.Label LblLaenge;
        private System.Windows.Forms.TextBox TxBLaenge;
        private System.Windows.Forms.Label LblBreite;
        private System.Windows.Forms.TextBox TxbBreite;
        private System.Windows.Forms.Label LblHoehe;
        private System.Windows.Forms.Label LblTagesmiete;
        private System.Windows.Forms.TextBox TxbTagesmiete;
        private System.Windows.Forms.Label TxbAnzPersonen;
        private System.Windows.Forms.Label LblPS;
        private System.Windows.Forms.TextBox TxbPS;
        private System.Windows.Forms.Label LblMaxSpeedMotor;
        private System.Windows.Forms.TextBox TxbSpeedMotor;
        private System.Windows.Forms.Label LblMaxSpeedSegel;
        private System.Windows.Forms.TextBox TxbSpeedSegel;
        private System.Windows.Forms.TextBox TxBHoehe;
        private System.Windows.Forms.Label LblAnzahlPersonen;
        private System.Windows.Forms.TextBox TxbAnzahlPersonen;
        private System.Windows.Forms.Label Lbl_Gesellschaft;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button BtnBildAnzeigen;
        //     private System.Windows.Forms.TextBox TxbAnzPersonen;
    }
}

