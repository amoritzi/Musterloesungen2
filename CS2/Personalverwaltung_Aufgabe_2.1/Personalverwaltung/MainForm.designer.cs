namespace Personalverwaltung
{
    partial class MainForm
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
            this.mstMainMenu = new System.Windows.Forms.MenuStrip();
            this.GrbPersonenDetails = new System.Windows.Forms.GroupBox();
            this.TbxTelefon = new System.Windows.Forms.TextBox();
            this.LblTelefon = new System.Windows.Forms.Label();
            this.TbxOrt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LblID = new System.Windows.Forms.Label();
            this.TbxPLZ = new System.Windows.Forms.TextBox();
            this.TbxStrasse = new System.Windows.Forms.TextBox();
            this.TbxVorname = new System.Windows.Forms.TextBox();
            this.TbxName = new System.Windows.Forms.TextBox();
            this.TbxID = new System.Windows.Forms.TextBox();
            this.LblPLZ = new System.Windows.Forms.Label();
            this.LblStrasse = new System.Windows.Forms.Label();
            this.LblVorname = new System.Windows.Forms.Label();
            this.LblName = new System.Windows.Forms.Label();
            this.BtnNew = new System.Windows.Forms.Button();
            this.BtnSpeichern = new System.Windows.Forms.Button();
            this.GbxSuche = new System.Windows.Forms.GroupBox();
            this.BtnSuchen = new System.Windows.Forms.Button();
            this.TbxSuche = new System.Windows.Forms.TextBox();
            this.LblGefundene = new System.Windows.Forms.Label();
            this.DgvMitarbeiterListe = new System.Windows.Forms.DataGridView();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.GrbPersonenDetails.SuspendLayout();
            this.GbxSuche.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMitarbeiterListe)).BeginInit();
            this.SuspendLayout();
            // 
            // mstMainMenu
            // 
            this.mstMainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mstMainMenu.Location = new System.Drawing.Point(0, 0);
            this.mstMainMenu.Name = "mstMainMenu";
            this.mstMainMenu.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.mstMainMenu.Size = new System.Drawing.Size(871, 24);
            this.mstMainMenu.TabIndex = 1;
            this.mstMainMenu.Text = "menuStrip1";
            // 
            // GrbPersonenDetails
            // 
            this.GrbPersonenDetails.Controls.Add(this.TbxTelefon);
            this.GrbPersonenDetails.Controls.Add(this.LblTelefon);
            this.GrbPersonenDetails.Controls.Add(this.TbxOrt);
            this.GrbPersonenDetails.Controls.Add(this.label1);
            this.GrbPersonenDetails.Controls.Add(this.LblID);
            this.GrbPersonenDetails.Controls.Add(this.TbxPLZ);
            this.GrbPersonenDetails.Controls.Add(this.TbxStrasse);
            this.GrbPersonenDetails.Controls.Add(this.TbxVorname);
            this.GrbPersonenDetails.Controls.Add(this.TbxName);
            this.GrbPersonenDetails.Controls.Add(this.TbxID);
            this.GrbPersonenDetails.Controls.Add(this.LblPLZ);
            this.GrbPersonenDetails.Controls.Add(this.LblStrasse);
            this.GrbPersonenDetails.Controls.Add(this.LblVorname);
            this.GrbPersonenDetails.Controls.Add(this.LblName);
            this.GrbPersonenDetails.Location = new System.Drawing.Point(564, 110);
            this.GrbPersonenDetails.Margin = new System.Windows.Forms.Padding(2);
            this.GrbPersonenDetails.Name = "GrbPersonenDetails";
            this.GrbPersonenDetails.Padding = new System.Windows.Forms.Padding(2);
            this.GrbPersonenDetails.Size = new System.Drawing.Size(296, 210);
            this.GrbPersonenDetails.TabIndex = 3;
            this.GrbPersonenDetails.TabStop = false;
            this.GrbPersonenDetails.Text = "Person";
            // 
            // TbxTelefon
            // 
            this.TbxTelefon.Location = new System.Drawing.Point(76, 185);
            this.TbxTelefon.Name = "TbxTelefon";
            this.TbxTelefon.Size = new System.Drawing.Size(186, 20);
            this.TbxTelefon.TabIndex = 9;
            // 
            // LblTelefon
            // 
            this.LblTelefon.AutoSize = true;
            this.LblTelefon.Location = new System.Drawing.Point(11, 192);
            this.LblTelefon.Name = "LblTelefon";
            this.LblTelefon.Size = new System.Drawing.Size(43, 13);
            this.LblTelefon.TabIndex = 8;
            this.LblTelefon.Text = "Telefon";
            // 
            // TbxOrt
            // 
            this.TbxOrt.Location = new System.Drawing.Point(76, 157);
            this.TbxOrt.Name = "TbxOrt";
            this.TbxOrt.Size = new System.Drawing.Size(187, 20);
            this.TbxOrt.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ort";
            // 
            // LblID
            // 
            this.LblID.AutoSize = true;
            this.LblID.Location = new System.Drawing.Point(11, 18);
            this.LblID.Name = "LblID";
            this.LblID.Size = new System.Drawing.Size(18, 13);
            this.LblID.TabIndex = 5;
            this.LblID.Text = "ID";
            // 
            // TbxPLZ
            // 
            this.TbxPLZ.Location = new System.Drawing.Point(76, 128);
            this.TbxPLZ.Margin = new System.Windows.Forms.Padding(2);
            this.TbxPLZ.Name = "TbxPLZ";
            this.TbxPLZ.Size = new System.Drawing.Size(187, 20);
            this.TbxPLZ.TabIndex = 4;
            // 
            // TbxStrasse
            // 
            this.TbxStrasse.Location = new System.Drawing.Point(76, 98);
            this.TbxStrasse.Margin = new System.Windows.Forms.Padding(2);
            this.TbxStrasse.Name = "TbxStrasse";
            this.TbxStrasse.Size = new System.Drawing.Size(187, 20);
            this.TbxStrasse.TabIndex = 3;
            // 
            // TbxVorname
            // 
            this.TbxVorname.Location = new System.Drawing.Point(76, 69);
            this.TbxVorname.Margin = new System.Windows.Forms.Padding(2);
            this.TbxVorname.Name = "TbxVorname";
            this.TbxVorname.Size = new System.Drawing.Size(187, 20);
            this.TbxVorname.TabIndex = 2;
            // 
            // TbxName
            // 
            this.TbxName.Location = new System.Drawing.Point(76, 44);
            this.TbxName.Margin = new System.Windows.Forms.Padding(2);
            this.TbxName.Name = "TbxName";
            this.TbxName.Size = new System.Drawing.Size(187, 20);
            this.TbxName.TabIndex = 1;
            // 
            // TbxID
            // 
            this.TbxID.Enabled = false;
            this.TbxID.Location = new System.Drawing.Point(76, 18);
            this.TbxID.Margin = new System.Windows.Forms.Padding(2);
            this.TbxID.Name = "TbxID";
            this.TbxID.Size = new System.Drawing.Size(187, 20);
            this.TbxID.TabIndex = 0;
            // 
            // LblPLZ
            // 
            this.LblPLZ.AutoSize = true;
            this.LblPLZ.Location = new System.Drawing.Point(11, 130);
            this.LblPLZ.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblPLZ.Name = "LblPLZ";
            this.LblPLZ.Size = new System.Drawing.Size(27, 13);
            this.LblPLZ.TabIndex = 1;
            this.LblPLZ.Text = "PLZ";
            // 
            // LblStrasse
            // 
            this.LblStrasse.AutoSize = true;
            this.LblStrasse.Location = new System.Drawing.Point(11, 100);
            this.LblStrasse.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblStrasse.Name = "LblStrasse";
            this.LblStrasse.Size = new System.Drawing.Size(42, 13);
            this.LblStrasse.TabIndex = 0;
            this.LblStrasse.Text = "Strasse";
            // 
            // LblVorname
            // 
            this.LblVorname.AutoSize = true;
            this.LblVorname.Location = new System.Drawing.Point(11, 72);
            this.LblVorname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblVorname.Name = "LblVorname";
            this.LblVorname.Size = new System.Drawing.Size(49, 13);
            this.LblVorname.TabIndex = 0;
            this.LblVorname.Text = "Vorname";
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(11, 44);
            this.LblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(35, 13);
            this.LblName.TabIndex = 0;
            this.LblName.Text = "Name";
            // 
            // BtnNew
            // 
            this.BtnNew.Location = new System.Drawing.Point(14, 332);
            this.BtnNew.Margin = new System.Windows.Forms.Padding(2);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(305, 28);
            this.BtnNew.TabIndex = 5;
            this.BtnNew.Text = "Neuer Eintrag";
            this.BtnNew.UseVisualStyleBackColor = true;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // BtnSpeichern
            // 
            this.BtnSpeichern.Location = new System.Drawing.Point(347, 332);
            this.BtnSpeichern.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSpeichern.Name = "BtnSpeichern";
            this.BtnSpeichern.Size = new System.Drawing.Size(262, 28);
            this.BtnSpeichern.TabIndex = 6;
            this.BtnSpeichern.Text = "Speichern";
            this.BtnSpeichern.UseVisualStyleBackColor = true;
            this.BtnSpeichern.Click += new System.EventHandler(this.BtnSpeichern_Click);
            // 
            // GbxSuche
            // 
            this.GbxSuche.Controls.Add(this.BtnSuchen);
            this.GbxSuche.Controls.Add(this.TbxSuche);
            this.GbxSuche.Location = new System.Drawing.Point(126, 27);
            this.GbxSuche.Name = "GbxSuche";
            this.GbxSuche.Size = new System.Drawing.Size(595, 56);
            this.GbxSuche.TabIndex = 7;
            this.GbxSuche.TabStop = false;
            this.GbxSuche.Text = "Name";
            // 
            // BtnSuchen
            // 
            this.BtnSuchen.Location = new System.Drawing.Point(322, 19);
            this.BtnSuchen.Name = "BtnSuchen";
            this.BtnSuchen.Size = new System.Drawing.Size(259, 21);
            this.BtnSuchen.TabIndex = 1;
            this.BtnSuchen.Text = "Suchen";
            this.BtnSuchen.UseVisualStyleBackColor = true;
            this.BtnSuchen.Click += new System.EventHandler(this.BtnSuchen_Click);
            // 
            // TbxSuche
            // 
            this.TbxSuche.Location = new System.Drawing.Point(19, 20);
            this.TbxSuche.Name = "TbxSuche";
            this.TbxSuche.Size = new System.Drawing.Size(269, 20);
            this.TbxSuche.TabIndex = 0;
            // 
            // LblGefundene
            // 
            this.LblGefundene.AutoSize = true;
            this.LblGefundene.Location = new System.Drawing.Point(21, 101);
            this.LblGefundene.Name = "LblGefundene";
            this.LblGefundene.Size = new System.Drawing.Size(108, 13);
            this.LblGefundene.TabIndex = 8;
            this.LblGefundene.Text = "Gefundene Personen";
            // 
            // DgvMitarbeiterListe
            // 
            this.DgvMitarbeiterListe.AllowUserToOrderColumns = true;
            this.DgvMitarbeiterListe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.DgvMitarbeiterListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvMitarbeiterListe.Location = new System.Drawing.Point(28, 123);
            this.DgvMitarbeiterListe.Name = "DgvMitarbeiterListe";
            this.DgvMitarbeiterListe.Size = new System.Drawing.Size(503, 196);
            this.DgvMitarbeiterListe.TabIndex = 9;
            this.DgvMitarbeiterListe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvTables_CellClick);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(640, 332);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(185, 28);
            this.BtnDelete.TabIndex = 10;
            this.BtnDelete.Text = "Löschen";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 377);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.DgvMitarbeiterListe);
            this.Controls.Add(this.LblGefundene);
            this.Controls.Add(this.GbxSuche);
            this.Controls.Add(this.BtnSpeichern);
            this.Controls.Add(this.BtnNew);
            this.Controls.Add(this.GrbPersonenDetails);
            this.Controls.Add(this.mstMainMenu);
            this.MainMenuStrip = this.mstMainMenu;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Personenverwaltung";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.GrbPersonenDetails.ResumeLayout(false);
            this.GrbPersonenDetails.PerformLayout();
            this.GbxSuche.ResumeLayout(false);
            this.GbxSuche.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMitarbeiterListe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip mstMainMenu;
        private System.Windows.Forms.GroupBox GrbPersonenDetails;
        private System.Windows.Forms.TextBox TbxPLZ;
        private System.Windows.Forms.TextBox TbxStrasse;
        private System.Windows.Forms.TextBox TbxVorname;
        private System.Windows.Forms.TextBox TbxName;
        private System.Windows.Forms.TextBox TbxID;
        private System.Windows.Forms.Label LblPLZ;
        private System.Windows.Forms.Label LblStrasse;
        private System.Windows.Forms.Label LblVorname;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Button BtnNew;
        private System.Windows.Forms.Button BtnSpeichern;
        private System.Windows.Forms.GroupBox GbxSuche;
        private System.Windows.Forms.Label LblID;
        private System.Windows.Forms.Button BtnSuchen;
        private System.Windows.Forms.TextBox TbxSuche;
        private System.Windows.Forms.TextBox TbxOrt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblGefundene;
        private System.Windows.Forms.TextBox TbxTelefon;
        private System.Windows.Forms.Label LblTelefon;
        private System.Windows.Forms.DataGridView DgvMitarbeiterListe;
        private System.Windows.Forms.Button BtnDelete;
    }
}

