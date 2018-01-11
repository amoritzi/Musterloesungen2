using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temperaturanzeige_UebungA2a
{
    public partial class NumericDisplay : Form , IObserver
    {
        private TmpSensor _subject;

        public NumericDisplay()
        {
            InitializeComponent();
        }

       
        public void Update()

        {
            TmpSensor ts = new TmpSensor();

            LblTempAnz.Text = "" + ts.MyTB.Value;

        }



        // Gets or sets subject

        public TmpSensor Subject

        {

            get { return _subject; }

            set { _subject = value; }

        }

        private void NumericDisplay_Load(object sender, EventArgs e)
        {

        }
    }
}
