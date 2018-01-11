namespace Temperaturanzeige_UebungA2a
{
    partial class TmpSensor
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
            this.NumDisp = new System.Windows.Forms.Button();
            this.GraphDisp = new System.Windows.Forms.Button();
            this.TempRegl = new System.Windows.Forms.TrackBar();
            this.TempLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TempRegl)).BeginInit();
            this.SuspendLayout();
            // 
            // NumDisp
            // 
            this.NumDisp.Location = new System.Drawing.Point(91, 138);
            this.NumDisp.Name = "NumDisp";
            this.NumDisp.Size = new System.Drawing.Size(116, 23);
            this.NumDisp.TabIndex = 0;
            this.NumDisp.Text = "Numeric Display";
            this.NumDisp.UseVisualStyleBackColor = true;
            this.NumDisp.Click += new System.EventHandler(this.NumDisp_Click);
            // 
            // GraphDisp
            // 
            this.GraphDisp.Location = new System.Drawing.Point(91, 189);
            this.GraphDisp.Name = "GraphDisp";
            this.GraphDisp.Size = new System.Drawing.Size(116, 23);
            this.GraphDisp.TabIndex = 1;
            this.GraphDisp.Text = "Graphic Display";
            this.GraphDisp.UseVisualStyleBackColor = true;
            // 
            // TempRegl
            // 
            this.TempRegl.Location = new System.Drawing.Point(28, 65);
            this.TempRegl.Maximum = 100;
            this.TempRegl.Name = "TempRegl";
            this.TempRegl.Size = new System.Drawing.Size(244, 45);
            this.TempRegl.TabIndex = 3;
            this.TempRegl.Scroll += new System.EventHandler(this.TempRegl_Scroll);
            // 
            // TempLbl
            // 
            this.TempLbl.AutoSize = true;
            this.TempLbl.Location = new System.Drawing.Point(43, 38);
            this.TempLbl.Name = "TempLbl";
            this.TempLbl.Size = new System.Drawing.Size(61, 13);
            this.TempLbl.TabIndex = 4;
            this.TempLbl.Text = "Temperatur";
            // 
            // TmpSensor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.TempLbl);
            this.Controls.Add(this.TempRegl);
            this.Controls.Add(this.GraphDisp);
            this.Controls.Add(this.NumDisp);
            this.Name = "TmpSensor";
            this.Text = "TemperaturSensor";
            ((System.ComponentModel.ISupportInitialize)(this.TempRegl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NumDisp;
        private System.Windows.Forms.Button GraphDisp;
        private System.Windows.Forms.TrackBar TempRegl;
        private System.Windows.Forms.Label TempLbl;
    }
}

