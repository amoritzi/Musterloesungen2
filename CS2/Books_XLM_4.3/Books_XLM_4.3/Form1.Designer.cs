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
            this.SuspendLayout();
            // 
            // LbxBookList
            // 
            this.LbxBookList.FormattingEnabled = true;
            this.LbxBookList.Location = new System.Drawing.Point(30, 24);
            this.LbxBookList.Name = "LbxBookList";
            this.LbxBookList.Size = new System.Drawing.Size(644, 329);
            this.LbxBookList.TabIndex = 0;
            // 
            // BtnList
            // 
            this.BtnList.Location = new System.Drawing.Point(722, 331);
            this.BtnList.Name = "BtnList";
            this.BtnList.Size = new System.Drawing.Size(84, 21);
            this.BtnList.TabIndex = 1;
            this.BtnList.Text = "Liste einlesen";
            this.BtnList.UseVisualStyleBackColor = true;
            this.BtnList.Click += new System.EventHandler(this.BtnList_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 391);
            this.Controls.Add(this.BtnList);
            this.Controls.Add(this.LbxBookList);
            this.Name = "Form1";
            this.Text = "Bücherliste";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox LbxBookList;
        private System.Windows.Forms.Button BtnList;
    }
}

