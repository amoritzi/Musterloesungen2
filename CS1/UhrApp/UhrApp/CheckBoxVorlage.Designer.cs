namespace UhrApp
{
    partial class CheckBoxVorlage
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

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.CbxText = new System.Windows.Forms.CheckBox();
            this.PbrProgress = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CbxText
            // 
            this.CbxText.AutoSize = true;
            this.CbxText.Location = new System.Drawing.Point(46, 35);
            this.CbxText.Name = "CbxText";
            this.CbxText.Size = new System.Drawing.Size(47, 17);
            this.CbxText.TabIndex = 1;
            this.CbxText.Text = "Text";
            this.CbxText.UseVisualStyleBackColor = true;
            this.CbxText.CheckedChanged += new System.EventHandler(this.CbxText_CheckedChanged);
            // 
            // PbrProgress
            // 
            this.PbrProgress.BackColor = System.Drawing.SystemColors.ControlDark;
            this.PbrProgress.Location = new System.Drawing.Point(99, 35);
            this.PbrProgress.Name = "PbrProgress";
            this.PbrProgress.Size = new System.Drawing.Size(250, 23);
            this.PbrProgress.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(184, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // CheckBoxVorlage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PbrProgress);
            this.Controls.Add(this.CbxText);
            this.Name = "CheckBoxVorlage";
            this.Size = new System.Drawing.Size(399, 80);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ProgressBar PbrProgress;
        public System.Windows.Forms.CheckBox CbxText;
        private System.Windows.Forms.Label label1;
    }
}
