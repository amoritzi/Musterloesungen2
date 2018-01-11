namespace Temperaturanzeige_UebungA2a
{
    partial class NumericDisplay
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
            this.LblTemperatur = new System.Windows.Forms.Label();
            this.LblTempAnz = new System.Windows.Forms.Label();
            this.LblClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblTemperatur
            // 
            this.LblTemperatur.AutoSize = true;
            this.LblTemperatur.Location = new System.Drawing.Point(25, 22);
            this.LblTemperatur.Name = "LblTemperatur";
            this.LblTemperatur.Size = new System.Drawing.Size(67, 13);
            this.LblTemperatur.TabIndex = 0;
            this.LblTemperatur.Text = "Temperatur: ";
            // 
            // LblTempAnz
            // 
            this.LblTempAnz.AutoSize = true;
            this.LblTempAnz.Location = new System.Drawing.Point(121, 22);
            this.LblTempAnz.Name = "LblTempAnz";
            this.LblTempAnz.Size = new System.Drawing.Size(45, 13);
            this.LblTempAnz.TabIndex = 1;
            this.LblTempAnz.Text = "Anzeige";
            // 
            // LblClose
            // 
            this.LblClose.Location = new System.Drawing.Point(115, 73);
            this.LblClose.Name = "LblClose";
            this.LblClose.Size = new System.Drawing.Size(75, 23);
            this.LblClose.TabIndex = 2;
            this.LblClose.Text = "Close";
            this.LblClose.UseVisualStyleBackColor = true;
            // 
            // NumericDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 111);
            this.Controls.Add(this.LblClose);
            this.Controls.Add(this.LblTempAnz);
            this.Controls.Add(this.LblTemperatur);
            this.Name = "NumericDisplay";
            this.Text = "NumericDisplay";
            this.Load += new System.EventHandler(this.NumericDisplay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTemperatur;
        private System.Windows.Forms.Label LblTempAnz;
        private System.Windows.Forms.Button LblClose;
    }
}