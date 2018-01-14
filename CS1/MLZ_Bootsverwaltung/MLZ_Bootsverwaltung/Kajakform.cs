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
    public partial class Kajakform : Form
    {
        Boot boot = new Boot();
        BootMethoden bm = new BootMethoden();

        public Kajakform()
        {
            InitializeComponent();
            BootMethoden bm = new BootMethoden();
            cbxKajak.DataSource = Enum.GetValues(typeof(Farbe));
            
        }

        private void txbKajakMarke_TextChanged(object sender, EventArgs e)
        {
                boot.Marke = txbKajakMarke.Text;
                label2.Text = boot.Marke;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Farbe farbe = new Farbe();
            Enum.TryParse<Farbe>(cbxKajak.SelectedValue.ToString(), out farbe);
            }
        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
               BootMethoden.AnzahlBoote++;
               BootMethoden.ErfasseKajak();
               this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
