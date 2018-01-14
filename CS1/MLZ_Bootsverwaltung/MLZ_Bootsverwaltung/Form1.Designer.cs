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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.erfassenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiKajak = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiKatamaran = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMotorboot = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSegelboot = new System.Windows.Forms.ToolStripMenuItem();
            this.bearbeitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.löschenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anzeigenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiListedetailliert = new System.Windows.Forms.ToolStripMenuItem();
            this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bootdataGridView = new System.Windows.Forms.DataGridView();
            this.bootMethodenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblList = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bootdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bootMethodenBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.erfassenToolStripMenuItem,
            this.bearbeitenToolStripMenuItem,
            this.löschenToolStripMenuItem,
            this.anzeigenToolStripMenuItem,
            this.beendenToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(851, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // erfassenToolStripMenuItem
            // 
            this.erfassenToolStripMenuItem.CheckOnClick = true;
            this.erfassenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiKajak,
            this.tsmiKatamaran,
            this.tsmiMotorboot,
            this.tsmiSegelboot});
            this.erfassenToolStripMenuItem.Name = "erfassenToolStripMenuItem";
            this.erfassenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.erfassenToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.erfassenToolStripMenuItem.Text = "Erfassen";
            this.erfassenToolStripMenuItem.Click += new System.EventHandler(this.erfassenToolStripMenuItem_Click);
            // 
            // tsmiKajak
            // 
            this.tsmiKajak.Name = "tsmiKajak";
            this.tsmiKajak.Size = new System.Drawing.Size(152, 22);
            this.tsmiKajak.Text = "Kajak";
            this.tsmiKajak.Click += new System.EventHandler(this.tsmiKajak_Click);
            // 
            // tsmiKatamaran
            // 
            this.tsmiKatamaran.Name = "tsmiKatamaran";
            this.tsmiKatamaran.Size = new System.Drawing.Size(152, 22);
            this.tsmiKatamaran.Text = "Katamaran";
            this.tsmiKatamaran.Click += new System.EventHandler(this.tsmiKatamaran_Click);
            // 
            // tsmiMotorboot
            // 
            this.tsmiMotorboot.Name = "tsmiMotorboot";
            this.tsmiMotorboot.Size = new System.Drawing.Size(152, 22);
            this.tsmiMotorboot.Text = "Motorboot";
            this.tsmiMotorboot.Click += new System.EventHandler(this.tsmiMotorboot_Click);
            // 
            // tsmiSegelboot
            // 
            this.tsmiSegelboot.Name = "tsmiSegelboot";
            this.tsmiSegelboot.Size = new System.Drawing.Size(152, 22);
            this.tsmiSegelboot.Text = "Segelboot";
            this.tsmiSegelboot.Click += new System.EventHandler(this.tsmiSegelboot_Click);
            // 
            // bearbeitenToolStripMenuItem
            // 
            this.bearbeitenToolStripMenuItem.Name = "bearbeitenToolStripMenuItem";
            this.bearbeitenToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.bearbeitenToolStripMenuItem.Text = "Bearbeiten";
            this.bearbeitenToolStripMenuItem.Click += new System.EventHandler(this.bearbeitenToolStripMenuItem_Click);
            // 
            // löschenToolStripMenuItem
            // 
            this.löschenToolStripMenuItem.Name = "löschenToolStripMenuItem";
            this.löschenToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.löschenToolStripMenuItem.Text = "Löschen";
            this.löschenToolStripMenuItem.Click += new System.EventHandler(this.löschenToolStripMenuItem_Click);
            // 
            // anzeigenToolStripMenuItem
            // 
            this.anzeigenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiListedetailliert});
            this.anzeigenToolStripMenuItem.Name = "anzeigenToolStripMenuItem";
            this.anzeigenToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.anzeigenToolStripMenuItem.Text = "Anzeigen";
            // 
            // tsmiListedetailliert
            // 
            this.tsmiListedetailliert.Name = "tsmiListedetailliert";
            this.tsmiListedetailliert.Size = new System.Drawing.Size(152, 22);
            this.tsmiListedetailliert.Text = "Liste detailliert";
            this.tsmiListedetailliert.Click += new System.EventHandler(this.tsmiListedetailliert_Click);
            // 
            // beendenToolStripMenuItem
            // 
            this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
            this.beendenToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.beendenToolStripMenuItem.Text = "Beenden";
            this.beendenToolStripMenuItem.Click += new System.EventHandler(this.beendenToolStripMenuItem_Click);
            // 
            // bootdataGridView
            // 
            this.bootdataGridView.AutoGenerateColumns = false;
            this.bootdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bootdataGridView.DataSource = this.bootMethodenBindingSource;
            this.bootdataGridView.Location = new System.Drawing.Point(39, 56);
            this.bootdataGridView.Name = "bootdataGridView";
            this.bootdataGridView.Size = new System.Drawing.Size(781, 270);
            this.bootdataGridView.TabIndex = 1;
            // 
            // bootMethodenBindingSource
            // 
            this.bootMethodenBindingSource.DataSource = typeof(MLZ_Bootsverwaltung.BootMethoden);
            // 
            // lblList
            // 
            this.lblList.AutoSize = true;
            this.lblList.Location = new System.Drawing.Point(36, 40);
            this.lblList.Name = "lblList";
            this.lblList.Size = new System.Drawing.Size(95, 13);
            this.lblList.TabIndex = 2;
            this.lblList.Text = "Liste der Eingaben";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 392);
            this.Controls.Add(this.lblList);
            this.Controls.Add(this.bootdataGridView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Bootsverwaltung";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bootdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bootMethodenBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem erfassenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiKajak;
        private System.Windows.Forms.ToolStripMenuItem tsmiKatamaran;
        private System.Windows.Forms.ToolStripMenuItem tsmiMotorboot;
        private System.Windows.Forms.ToolStripMenuItem tsmiSegelboot;
        private System.Windows.Forms.ToolStripMenuItem bearbeitenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem löschenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anzeigenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiListedetailliert;
        private System.Windows.Forms.ToolStripMenuItem beendenToolStripMenuItem;
        private System.Windows.Forms.DataGridView bootdataGridView;
        private System.Windows.Forms.BindingSource bootMethodenBindingSource;
        private System.Windows.Forms.Label lblList;
    }
}

