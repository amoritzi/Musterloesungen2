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
        BootController bc = new BootController();
        Farbe farbe = new Farbe();
        Boot boot = new Boot();

        public MainForm()
        {
            InitializeComponent();
            CmbFarbe.DataSource = Enum.GetValues(typeof(Farbe));
            LbxBootsliste.DataSource = BootController.bootsListe ;
            LbxBootsliste.ValueMember = "ID";
            LbxBootsliste.DisplayMember = "Marke";
        }

        private void CmbFarbe_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            Enum.TryParse<Farbe>(CmbFarbe.SelectedValue.ToString(), out farbe);
          
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            BootController.AnzahlBoote++;
            // , farbe,  Convert.ToInt32(TxbNummernschild)
            BootController bootc = new BootController(TxbMarke.Text, TxbModell.Text);
        //    Boot boot = new Boot(TxbMarke.Text, TxbModell.Text);
            BootController.ErfasseKajak(); // Dies ausprobieren!
        }
        private void BtnAbbrechen_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnListe_Click(object sender, EventArgs e)
        {
            UpdateListe();

        }
        private void UpdateListe()
        {
            LbxBootsliste.DataSource = null;
            LbxBootsliste.DataSource = BootController.bootsListe;
        }

        private void TxbMarke_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
