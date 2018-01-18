namespace MLZ_Bootsverwaltung
{
    partial class Kajakform
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
            this.lblKajak_Marke = new System.Windows.Forms.Label();
            this.txbKajakMarke = new System.Windows.Forms.TextBox();
            this.lblKajak_Modell = new System.Windows.Forms.Label();
            this.txbKajak_Modell = new System.Windows.Forms.TextBox();
            this.lblKajakFarbe = new System.Windows.Forms.Label();
            this.cbxKajak = new System.Windows.Forms.ComboBox();
            this.btKajakSpeichern = new System.Windows.Forms.Button();
            this.btnKajakCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblKajakNummernschild = new System.Windows.Forms.Label();
            this.txbKajakNummernschild = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblKajak_Marke
            // 
            this.lblKajak_Marke.AutoSize = true;
            this.lblKajak_Marke.Location = new System.Drawing.Point(23, 27);
            this.lblKajak_Marke.Name = "lblKajak_Marke";
            this.lblKajak_Marke.Size = new System.Drawing.Size(37, 13);
            this.lblKajak_Marke.TabIndex = 0;
            this.lblKajak_Marke.Text = "Marke";
            this.lblKajak_Marke.Click += new System.EventHandler(this.label1_Click);
            // 
            // txbKajakMarke
            // 
            this.txbKajakMarke.Location = new System.Drawing.Point(119, 27);
            this.txbKajakMarke.Name = "txbKajakMarke";
            this.txbKajakMarke.Size = new System.Drawing.Size(250, 20);
            this.txbKajakMarke.TabIndex = 1;
            this.txbKajakMarke.TextChanged += new System.EventHandler(this.txbKajakMarke_TextChanged);
            // 
            // lblKajak_Modell
            // 
            this.lblKajak_Modell.AutoSize = true;
            this.lblKajak_Modell.Location = new System.Drawing.Point(23, 60);
            this.lblKajak_Modell.Name = "lblKajak_Modell";
            this.lblKajak_Modell.Size = new System.Drawing.Size(38, 13);
            this.lblKajak_Modell.TabIndex = 2;
            this.lblKajak_Modell.Text = "Modell";
            // 
            // txbKajak_Modell
            // 
            this.txbKajak_Modell.Location = new System.Drawing.Point(119, 53);
            this.txbKajak_Modell.Name = "txbKajak_Modell";
            this.txbKajak_Modell.Size = new System.Drawing.Size(250, 20);
            this.txbKajak_Modell.TabIndex = 3;
            this.txbKajak_Modell.TextChanged += new System.EventHandler(this.txbKajak_Modell_TextChanged);
            // 
            // lblKajakFarbe
            // 
            this.lblKajakFarbe.AutoSize = true;
            this.lblKajakFarbe.Location = new System.Drawing.Point(26, 92);
            this.lblKajakFarbe.Name = "lblKajakFarbe";
            this.lblKajakFarbe.Size = new System.Drawing.Size(34, 13);
            this.lblKajakFarbe.TabIndex = 4;
            this.lblKajakFarbe.Text = "Farbe";
            // 
            // cbxKajak
            // 
            this.cbxKajak.FormattingEnabled = true;
            this.cbxKajak.Location = new System.Drawing.Point(119, 84);
            this.cbxKajak.Name = "cbxKajak";
            this.cbxKajak.Size = new System.Drawing.Size(129, 21);
            this.cbxKajak.TabIndex = 5;
            this.cbxKajak.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btKajakSpeichern
            // 
            this.btKajakSpeichern.Location = new System.Drawing.Point(254, 347);
            this.btKajakSpeichern.Name = "btKajakSpeichern";
            this.btKajakSpeichern.Size = new System.Drawing.Size(75, 23);
            this.btKajakSpeichern.TabIndex = 6;
            this.btKajakSpeichern.Text = "Speichern";
            this.btKajakSpeichern.UseVisualStyleBackColor = true;
            this.btKajakSpeichern.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnKajakCancel
            // 
            this.btnKajakCancel.Location = new System.Drawing.Point(133, 347);
            this.btnKajakCancel.Name = "btnKajakCancel";
            this.btnKajakCancel.Size = new System.Drawing.Size(75, 23);
            this.btnKajakCancel.TabIndex = 7;
            this.btnKajakCancel.Text = "Abbrechen";
            this.btnKajakCancel.UseVisualStyleBackColor = true;
            this.btnKajakCancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(430, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(436, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Eingabe";
            // 
            // lblKajakNummernschild
            // 
            this.lblKajakNummernschild.AutoSize = true;
            this.lblKajakNummernschild.Location = new System.Drawing.Point(23, 124);
            this.lblKajakNummernschild.Name = "lblKajakNummernschild";
            this.lblKajakNummernschild.Size = new System.Drawing.Size(79, 13);
            this.lblKajakNummernschild.TabIndex = 10;
            this.lblKajakNummernschild.Text = "Nummernschild";
            // 
            // txbKajakNummernschild
            // 
            this.txbKajakNummernschild.Location = new System.Drawing.Point(119, 116);
            this.txbKajakNummernschild.Name = "txbKajakNummernschild";
            this.txbKajakNummernschild.Size = new System.Drawing.Size(250, 20);
            this.txbKajakNummernschild.TabIndex = 11;
            this.txbKajakNummernschild.TextChanged += new System.EventHandler(this.txbKajakNummernschild_TextChanged);
            // 
            // Kajakform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 390);
            this.Controls.Add(this.txbKajakNummernschild);
            this.Controls.Add(this.lblKajakNummernschild);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKajakCancel);
            this.Controls.Add(this.btKajakSpeichern);
            this.Controls.Add(this.cbxKajak);
            this.Controls.Add(this.lblKajakFarbe);
            this.Controls.Add(this.txbKajak_Modell);
            this.Controls.Add(this.lblKajak_Modell);
            this.Controls.Add(this.txbKajakMarke);
            this.Controls.Add(this.lblKajak_Marke);
            this.Name = "Kajakform";
            this.Text = "Erfasse Kajak";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKajak_Marke;
        private System.Windows.Forms.TextBox txbKajakMarke;
        private System.Windows.Forms.Label lblKajak_Modell;
        private System.Windows.Forms.TextBox txbKajak_Modell;
        private System.Windows.Forms.Label lblKajakFarbe;
        private System.Windows.Forms.ComboBox cbxKajak;
        private System.Windows.Forms.Button btKajakSpeichern;
        private System.Windows.Forms.Button btnKajakCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblKajakNummernschild;
        private System.Windows.Forms.TextBox txbKajakNummernschild;
    }
}