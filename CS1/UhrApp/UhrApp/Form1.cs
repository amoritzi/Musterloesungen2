using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UhrApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Clock_Tick(object sender, EventArgs e)
        {
            LblTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBoxVorlage1_Load(object sender, EventArgs e)
        {
            
        }

        private void checkBoxVorlage1_Load_1(object sender, EventArgs e)
        {

        }

        private void checkBoxVorlage1_Load_2(object sender, EventArgs e)
        {

        }
    }
}
