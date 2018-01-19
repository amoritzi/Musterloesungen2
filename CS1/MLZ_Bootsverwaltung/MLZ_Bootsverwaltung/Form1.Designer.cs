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
            this.BtnAbbrechen = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnMutieren = new System.Windows.Forms.Button();
            this.BtnListe = new System.Windows.Forms.Button();
            this.LbxBootsliste = new System.Windows.Forms.ListBox();
            this.BtnMutation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblMarke
            // 
            this.LblMarke.AutoSize = true;
            this.LblMarke.Location = new System.Drawing.Point(564, 47);
            this.LblMarke.Name = "LblMarke";
            this.LblMarke.Size = new System.Drawing.Size(37, 13);
            this.LblMarke.TabIndex = 2;
            this.LblMarke.Text = "Marke";
            // 
            // TxbMarke
            // 
            this.TxbMarke.Location = new System.Drawing.Point(647, 41);
            this.TxbMarke.Name = "TxbMarke";
            this.TxbMarke.Size = new System.Drawing.Size(266, 20);
            this.TxbMarke.TabIndex = 3;
            this.TxbMarke.TextChanged += new System.EventHandler(this.TxbMarke_TextChanged);
            // 
            // LblModell
            // 
            this.LblModell.AutoSize = true;
            this.LblModell.Location = new System.Drawing.Point(564, 77);
            this.LblModell.Name = "LblModell";
            this.LblModell.Size = new System.Drawing.Size(38, 13);
            this.LblModell.TabIndex = 4;
            this.LblModell.Text = "Modell";
            // 
            // TxbModell
            // 
            this.TxbModell.Location = new System.Drawing.Point(647, 70);
            this.TxbModell.Name = "TxbModell";
            this.TxbModell.Size = new System.Drawing.Size(266, 20);
            this.TxbModell.TabIndex = 5;
            // 
            // LblFarbe
            // 
            this.LblFarbe.AutoSize = true;
            this.LblFarbe.Location = new System.Drawing.Point(564, 106);
            this.LblFarbe.Name = "LblFarbe";
            this.LblFarbe.Size = new System.Drawing.Size(34, 13);
            this.LblFarbe.TabIndex = 6;
            this.LblFarbe.Text = "Farbe";
            // 
            // CmbFarbe
            // 
            this.CmbFarbe.FormattingEnabled = true;
            this.CmbFarbe.Location = new System.Drawing.Point(647, 96);
            this.CmbFarbe.Name = "CmbFarbe";
            this.CmbFarbe.Size = new System.Drawing.Size(121, 21);
            this.CmbFarbe.TabIndex = 7;
            this.CmbFarbe.SelectedIndexChanged += new System.EventHandler(this.CmbFarbe_SelectedIndexChanged);
            // 
            // LblNummernschild
            // 
            this.LblNummernschild.AutoSize = true;
            this.LblNummernschild.Location = new System.Drawing.Point(564, 135);
            this.LblNummernschild.Name = "LblNummernschild";
            this.LblNummernschild.Size = new System.Drawing.Size(72, 13);
            this.LblNummernschild.TabIndex = 8;
            this.LblNummernschild.Text = "Nummernsch.";
            // 
            // TxbNummernschild
            // 
            this.TxbNummernschild.Location = new System.Drawing.Point(647, 128);
            this.TxbNummernschild.Name = "TxbNummernschild";
            this.TxbNummernschild.Size = new System.Drawing.Size(266, 20);
            this.TxbNummernschild.TabIndex = 9;
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(669, 365);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(64, 35);
            this.BtnSave.TabIndex = 11;
            this.BtnSave.Text = "Speichern";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnAbbrechen
            // 
            this.BtnAbbrechen.Location = new System.Drawing.Point(583, 365);
            this.BtnAbbrechen.Name = "BtnAbbrechen";
            this.BtnAbbrechen.Size = new System.Drawing.Size(70, 35);
            this.BtnAbbrechen.TabIndex = 12;
            this.BtnAbbrechen.Text = "Abbrechen";
            this.BtnAbbrechen.UseVisualStyleBackColor = true;
            this.BtnAbbrechen.Click += new System.EventHandler(this.BtnAbbrechen_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(434, 368);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(59, 32);
            this.BtnDelete.TabIndex = 13;
            this.BtnDelete.Text = "Löschen";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnMutieren
            // 
            this.BtnMutieren.Location = new System.Drawing.Point(341, 368);
            this.BtnMutieren.Name = "BtnMutieren";
            this.BtnMutieren.Size = new System.Drawing.Size(69, 34);
            this.BtnMutieren.TabIndex = 14;
            this.BtnMutieren.Text = "Bearbeiten";
            this.BtnMutieren.UseVisualStyleBackColor = true;
            this.BtnMutieren.Click += new System.EventHandler(this.BtnMutieren_Click);
            // 
            // BtnListe
            // 
            this.BtnListe.Location = new System.Drawing.Point(30, 12);
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
            this.LbxBootsliste.Location = new System.Drawing.Point(30, 45);
            this.LbxBootsliste.MultiColumn = true;
            this.LbxBootsliste.Name = "LbxBootsliste";
            this.LbxBootsliste.Size = new System.Drawing.Size(463, 303);
            this.LbxBootsliste.TabIndex = 16;
            this.LbxBootsliste.SelectedIndexChanged += new System.EventHandler(this.LbxBootsliste_SelectedIndexChanged);
            // 
            // BtnMutation
            // 
            this.BtnMutation.Location = new System.Drawing.Point(213, 368);
            this.BtnMutation.Name = "BtnMutation";
            this.BtnMutation.Size = new System.Drawing.Size(111, 35);
            this.BtnMutation.TabIndex = 17;
            this.BtnMutation.Text = "Mutation speichern";
            this.BtnMutation.UseVisualStyleBackColor = true;
            this.BtnMutation.Click += new System.EventHandler(this.BtnMutation_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 410);
            this.Controls.Add(this.BtnMutation);
            this.Controls.Add(this.LbxBootsliste);
            this.Controls.Add(this.BtnListe);
            this.Controls.Add(this.BtnMutieren);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnAbbrechen);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.TxbNummernschild);
            this.Controls.Add(this.LblNummernschild);
            this.Controls.Add(this.CmbFarbe);
            this.Controls.Add(this.LblFarbe);
            this.Controls.Add(this.TxbModell);
            this.Controls.Add(this.LblModell);
            this.Controls.Add(this.TxbMarke);
            this.Controls.Add(this.LblMarke);
            this.Name = "MainForm";
            this.Text = "Bootsverwaltung";
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
        private System.Windows.Forms.Button BtnAbbrechen;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnMutieren;
        private System.Windows.Forms.Button BtnListe;
        private System.Windows.Forms.ListBox LbxBootsliste;
        private System.Windows.Forms.Button BtnMutation;
    }
}

