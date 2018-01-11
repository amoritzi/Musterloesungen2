namespace UhrApp
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
            this.Clock = new System.Windows.Forms.Timer(this.components);
            this.ZeitLabel = new System.Windows.Forms.Label();
            this.LblTime = new System.Windows.Forms.Label();
            this.checkBoxVorlage1 = new UhrApp.CheckBoxVorlage();
            this.SuspendLayout();
            // 
            // Clock
            // 
            this.Clock.Enabled = true;
            this.Clock.Interval = 1000;
            this.Clock.Tick += new System.EventHandler(this.Clock_Tick);
            // 
            // ZeitLabel
            // 
            this.ZeitLabel.AutoSize = true;
            this.ZeitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZeitLabel.Location = new System.Drawing.Point(32, 212);
            this.ZeitLabel.Name = "ZeitLabel";
            this.ZeitLabel.Size = new System.Drawing.Size(40, 20);
            this.ZeitLabel.TabIndex = 0;
            this.ZeitLabel.Text = "Zeit:";
            // 
            // LblTime
            // 
            this.LblTime.AutoSize = true;
            this.LblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTime.Location = new System.Drawing.Point(105, 212);
            this.LblTime.Name = "LblTime";
            this.LblTime.Size = new System.Drawing.Size(43, 20);
            this.LblTime.TabIndex = 1;
            this.LblTime.Text = "Time";
            // 
            // checkBoxVorlage1
            // 
            this.checkBoxVorlage1.EditEnabled = false;
            this.checkBoxVorlage1.Location = new System.Drawing.Point(36, 24);
            this.checkBoxVorlage1.Name = "checkBoxVorlage1";
            this.checkBoxVorlage1.Size = new System.Drawing.Size(399, 80);
            this.checkBoxVorlage1.TabIndex = 2;
            this.checkBoxVorlage1.Load += new System.EventHandler(this.checkBoxVorlage1_Load_2);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 261);
            this.Controls.Add(this.checkBoxVorlage1);
            this.Controls.Add(this.LblTime);
            this.Controls.Add(this.ZeitLabel);
            this.Name = "MainForm";
            this.Text = "MyForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer Clock;
        private System.Windows.Forms.Label ZeitLabel;
        private System.Windows.Forms.Label LblTime;
        private CheckBoxVorlage checkBoxVorlage1;
    }
}

