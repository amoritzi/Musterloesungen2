using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UhrApp
{
    public partial class CheckBoxVorlage : UserControl
    {
                   public bool EditEnabled
            {
                get { return CbxText.Checked; }
                set { CbxText.Checked = value; }
            }
            public CheckBoxVorlage()
        {
            InitializeComponent();
        }
        private void CbxEditEnabled_CheckedChanged(object sender, EventArgs e)
        {
            CbxText.Enabled = CbxText.Checked;
        }

       }
}
