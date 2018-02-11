namespace Books_XLM_4._3
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
            this.LbxBookList = new System.Windows.Forms.ListBox();
            this.BtnList = new System.Windows.Forms.Button();
            this.BtnCSV = new System.Windows.Forms.Button();
            this.BtnXML = new System.Windows.Forms.Button();
            this.BtnPriceSelect = new System.Windows.Forms.Button();
            this.BtnISBN = new System.Windows.Forms.Button();
            this.BtnStadt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LbxBookList
            // 
            this.LbxBookList.FormattingEnabled = true;
            this.LbxBookList.Location = new System.Drawing.Point(30, 24);
            this.LbxBookList.Name = "LbxBookList";
            this.LbxBookList.Size = new System.Drawing.Size(776, 329);
            this.LbxBookList.TabIndex = 0;
            // 
            // BtnList
            // 
            this.BtnList.Location = new System.Drawing.Point(722, 358);
            this.BtnList.Name = "BtnList";
            this.BtnList.Size = new System.Drawing.Size(84, 21);
            this.BtnList.TabIndex = 1;
            this.BtnList.Text = "Liste einlesen";
            this.BtnList.UseVisualStyleBackColor = true;
            this.BtnList.Click += new System.EventHandler(this.BtnList_Click);
            // 
            // BtnCSV
            // 
            this.BtnCSV.Location = new System.Drawing.Point(589, 359);
            this.BtnCSV.Name = "BtnCSV";
            this.BtnCSV.Size = new System.Drawing.Size(116, 20);
            this.BtnCSV.TabIndex = 2;
            this.BtnCSV.Text = "Speichern als CSV";
            this.BtnCSV.UseVisualStyleBackColor = true;
            this.BtnCSV.Click += new System.EventHandler(this.BtnCSV_Click);
            // 
            // BtnXML
            // 
            this.BtnXML.Location = new System.Drawing.Point(456, 359);
            this.BtnXML.Name = "BtnXML";
            this.BtnXML.Size = new System.Drawing.Size(115, 20);
            this.BtnXML.TabIndex = 3;
            this.BtnXML.Text = "Speichern als XML";
            this.BtnXML.UseVisualStyleBackColor = true;
            this.BtnXML.Click += new System.EventHandler(this.BtnXML_Click);
            // 
            // BtnPriceSelect
            // 
            this.BtnPriceSelect.Location = new System.Drawing.Point(330, 359);
            this.BtnPriceSelect.Name = "BtnPriceSelect";
            this.BtnPriceSelect.Size = new System.Drawing.Size(107, 20);
            this.BtnPriceSelect.TabIndex = 4;
            this.BtnPriceSelect.Text = "Preis < 20";
            this.BtnPriceSelect.UseVisualStyleBackColor = true;
            this.BtnPriceSelect.Click += new System.EventHandler(this.BtnPriceSelect_Click);
            // 
            // BtnISBN
            // 
            this.BtnISBN.Location = new System.Drawing.Point(232, 359);
            this.BtnISBN.Name = "BtnISBN";
            this.BtnISBN.Size = new System.Drawing.Size(75, 23);
            this.BtnISBN.TabIndex = 5;
            this.BtnISBN.Text = "ISBN +";
            this.BtnISBN.UseVisualStyleBackColor = true;
            this.BtnISBN.Click += new System.EventHandler(this.BtnISBN_Click);
            // 
            // BtnStadt
            // 
            this.BtnStadt.Location = new System.Drawing.Point(110, 359);
            this.BtnStadt.Name = "BtnStadt";
            this.BtnStadt.Size = new System.Drawing.Size(75, 23);
            this.BtnStadt.TabIndex = 6;
            this.BtnStadt.Text = "Stadt+";
            this.BtnStadt.UseVisualStyleBackColor = true;
            this.BtnStadt.Click += new System.EventHandler(this.BtnStadt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 391);
            this.Controls.Add(this.BtnStadt);
            this.Controls.Add(this.BtnISBN);
            this.Controls.Add(this.BtnPriceSelect);
            this.Controls.Add(this.BtnXML);
            this.Controls.Add(this.BtnCSV);
            this.Controls.Add(this.BtnList);
            this.Controls.Add(this.LbxBookList);
            this.Name = "Form1";
            this.Text = "Bücherliste";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox LbxBookList;
        private System.Windows.Forms.Button BtnList;
        private System.Windows.Forms.Button BtnCSV;
        private System.Windows.Forms.Button BtnXML;
        private System.Windows.Forms.Button BtnPriceSelect;
        private System.Windows.Forms.Button BtnISBN;
        private System.Windows.Forms.Button BtnStadt;
    }
}

