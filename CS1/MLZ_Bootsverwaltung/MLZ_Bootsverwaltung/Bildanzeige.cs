using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MLZ_Bootsverwaltung
{
    public partial class Bildanzeige : Form
    {
        public Bildanzeige()
        {
            InitializeComponent();
            MainForm form = new MainForm();
              try
            {
                pictureBox1.Image = Image.FromFile(MainForm.Bildpfad);
            }
            catch (System.ArgumentNullException e)
            {
                MessageBox.Show("Bitte zuerst Zeile auswählen.");
            }
        
        }

        public void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }
     }
}

