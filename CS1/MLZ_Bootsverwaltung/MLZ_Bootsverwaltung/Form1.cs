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
        Farbe farbe = new Farbe();
        Boot boot = new Boot();
        BootController bc = new BootController();
        private BindingSource lbxBindingSource = new BindingSource();
        public int Zaehler { get; set; }
        public static int Index { get; set; }
        public static int id;


        public MainForm()
        {
            InitializeComponent();
            CmbFarbe.DataSource = Enum.GetValues(typeof(Farbe));
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
            bc.Erfassen(boot);
            TxbMarke.Clear();
            TxbModell.Clear();
        }  
        
        private void BtnAbbrechen_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnListe_Click(object sender, EventArgs e)
        {
            UpdateListe();
            lbxBindingSource.DataSource = boot.bootsListe;
            LbxBootsliste.DataSource = lbxBindingSource;
        }
        private void BtnMutieren_Click(object sender, EventArgs e)
        {
            String mutation;
            mutation = LbxBootsliste.SelectedItem.ToString();
            TxbMarke.Clear();
            TxbModell.Clear();
            StringBuilder sb = new StringBuilder(mutation);
            string[] mutationsstring = sb.ToString().Split(' ');
            id = Convert.ToInt32(mutationsstring[0]);
            Boot record = boot.bootsListe.Find(x => x.ID == id);
            Index = boot.bootsListe.FindIndex(x => x.ID == id);
            TxbMarke.Text = record.Marke;
            TxbModell.Text = record.Modell;

            MessageBox.Show("Bitte Mutation eintragen und \"Mutation speichern\" drücken");

            bc.Mutieren(boot);
           

            /*     MessageBox.Show("Item1: "+mutationsstring[0]);
                 MessageBox.Show("Item2: " + mutationsstring[1]);
                 MessageBox.Show("Item3: " + mutationsstring[2]); */


        }

        private void UpdateListe()
        {
            LbxBootsliste.DataSource = null;
            lbxBindingSource.DataSource = boot.bootsListe;
            LbxBootsliste.DataSource = lbxBindingSource;

        }

        private void TxbMarke_TextChanged(object sender, EventArgs e)
        {

        }

        private void LbxBootsliste_SelectedIndexChanged(object sender, EventArgs e)
        {
            Zaehler++;

            if (Zaehler > 1)
            {
                MessageBox.Show("Gewählte Zeile: " + LbxBootsliste.SelectedItem);
            }
            
           
        }

        private void BtnMutation_Click(object sender, EventArgs e)
        {

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if ((LbxBootsliste.SelectedIndex >= 0 && (LbxBootsliste.SelectedIndex < boot.bootsListe.Count)))
                boot.bootsListe.RemoveAt(LbxBootsliste.SelectedIndex);
            UpdateListe();
        }
    }
}

