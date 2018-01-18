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
    public partial class MainForm : Form
    {
        Kajakform kajakform = new Kajakform();
        
        public MainForm()
        {
            InitializeComponent();
            // Boat.xml laden!
        }
    
       private void erfassenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Keine Action notwendig.
        }

        private void tsmiKajak_Click(object sender, EventArgs e)
        {
            if (kajakform.IsDisposed)
            {
                kajakform = new Kajakform();
            }
            kajakform.Show();
        }

        private void tsmiKatamaran_Click(object sender, EventArgs e)
        {
            
        }

        private void tsmiMotorboot_Click(object sender, EventArgs e)
        {

        }

        private void tsmiSegelboot_Click(object sender, EventArgs e)
        {

        }

        private void bearbeitenToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void löschenToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tsmiListeKurz_Click(object sender, EventArgs e)
        {

        }

        private void tsmiListedetailliert_Click(object sender, EventArgs e)
        {
            var list = new BindingList<Boot>(BootMethoden.bootsListe);
            bootdataGridView.DataSource = null;
            bootdataGridView.DataSource = list;
        }

        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Daten speichern in Boats.xlm
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void lblAnzBoote_Click(object sender, EventArgs e)
        {
            lblAnzBoote.Text = "Anzahl Boote: {BootMethoden.AnzahlBoote}";
        }
    }
}
