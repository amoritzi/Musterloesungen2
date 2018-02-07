using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Books_XLM_4._3
{
    public partial class Form1 : Form
    {
        private BindingSource lbxBindingSource = new BindingSource();
        Buchliste buchliste = new Buchliste();
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnList_Click(object sender, EventArgs e)
        {
            lbxBindingSource.DataSource = buchliste.buchListe;
            LbxBookList.DataSource = lbxBindingSource;
            XDocument books = XDocument.Load(@"books.xml");

            var buchListe = from buch in books.Descendants("book")
                            select (string)books.Element("id") + " " + (string)books.Element("title") + " " +
                            (string)books.Element("author") + " " + (string)books.Element("price");
            UpdateListe();
        }
        private void UpdateListe()
        {
            LbxBookList.DataSource = null;
            lbxBindingSource.DataSource = buchliste.buchListe;
            LbxBookList.DataSource = lbxBindingSource;
        }
    }
}
