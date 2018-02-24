using System;
using System.Collections.Generic;
using System.Configuration;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

using Personalverwaltung.Controller;

namespace Personalverwaltung
{
    public partial class MainForm : Form
    {
        PersonenController personcon = new PersonenController();
        public static int ID;
        public static string PName;
        public static string Vorname;
        public static string Strasse;
        public static int PLZ;
        public static string Ort;
        public static string Telefon;
        private BindingSource lbxBindingSource = new BindingSource();
        public string connString = @"Data Source=(local)\SQLEXPRESS;" +
                               "Initial Catalog=Personalverwaltung;" +
                               "Integrated Security=sspi";
        string abfrageString = "select * from Persons order by Name" ;
        static string eingabe;
        DataTable personTable;
        BindingSource bSource = new BindingSource();
        SqlDataAdapter adapter = new SqlDataAdapter();
        int index = 0;
        public static string deleteID;
        public static string updateID;

        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            ReadData(abfrageString);
        }
        
             private void BtnNew_Click(object sender, EventArgs e)
        {
            TbxID.Clear();
            TbxName.Clear();
            TbxVorname.Clear();
            TbxStrasse.Clear();
            TbxPLZ.Clear();
            TbxOrt.Clear();
            TbxTelefon.Clear();
            TbxName.Focus();
        }

        private void BtnSpeichern_Click(object sender, EventArgs e)
        {   
            if (TbxID.Text == "")
            {
                EingabenLesen();
                personcon.ErfassenPerson();
                personcon.SchreibenPerson();
                ReadData(abfrageString);
            }
            else
            {
                updateID = TbxID.Text;
                EingabenMutLesen();
                personcon.ErfassenMutPerson();
                personcon.MutierenPerson();
                ReadData(abfrageString);
            }
        }

        public void EingabenLesen()
        {
            PName = TbxName.Text;
            Vorname = TbxVorname.Text;
            Strasse = TbxStrasse.Text;
            try
            {
                PLZ = Convert.ToInt32(TbxPLZ.Text);
            }
            catch
            {
                MessageBox.Show("Es muss eine Postleizahl eingegeben werden!");
            }           
            Ort = TbxOrt.Text;
            Telefon = TbxTelefon.Text;

        }

        public void EingabenMutLesen()
        {
            ID = Convert.ToInt32(updateID);
            PName = TbxName.Text;
            Vorname = TbxVorname.Text;
            Strasse = TbxStrasse.Text;
            try
            {
                PLZ = Convert.ToInt32(TbxPLZ.Text);
            }
            catch
            {
                MessageBox.Show("Es muss eine Postleizahl eingegeben werden!");
            }
            Ort = TbxOrt.Text;
            Telefon = TbxTelefon.Text;

        }

        private void UpdateListe()
        {
            DgvMitarbeiterListe.DataSource = null;
            lbxBindingSource.DataSource = personcon.personenliste;
            DgvMitarbeiterListe.DataSource = lbxBindingSource;
        }

        private void BtnSuchen_Click(object sender, EventArgs e)
        {
            eingabe = TbxSuche.Text;      
            string filterExpression = string.Format("Name LIKE '{0}%'", eingabe);
            bSource.Filter = filterExpression;
        }
        private void ReadData (string queryString)
        {
            using (SqlConnection con = new SqlConnection(connString))
            {
                adapter.SelectCommand = new SqlCommand(queryString, con);
                personTable = new DataTable();
                adapter.Fill(personTable);
                bSource.DataSource = personTable;
                DgvMitarbeiterListe.DataSource = bSource;
                DgvMitarbeiterListe.AutoResizeRows();                
            }
        }
        private void DgvTables_CellClick(System.Object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            index = e.RowIndex;
            DgvMitarbeiterListe.Rows[index].Selected = true;
            UpdateDetails();
       }
        private void UpdateDetails()
        {
            TbxID.Text = DgvMitarbeiterListe.Rows[index].Cells[0].Value.ToString();
            TbxName.Text = DgvMitarbeiterListe.Rows[index].Cells[1].Value.ToString();
            TbxVorname.Text = DgvMitarbeiterListe.Rows[index].Cells[2].Value.ToString();
            TbxStrasse.Text = DgvMitarbeiterListe.Rows[index].Cells[3].Value.ToString();
            TbxPLZ.Text = DgvMitarbeiterListe.Rows[index].Cells[4].Value.ToString();
            TbxOrt.Text = DgvMitarbeiterListe.Rows[index].Cells[5].Value.ToString();
            TbxTelefon.Text = DgvMitarbeiterListe.Rows[index].Cells[6].Value.ToString();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            deleteID = TbxID.Text;
            DgvMitarbeiterListe.Rows.RemoveAt(index);
            personcon.LoeschenPerson();
        }
    }
}
