using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form1
{
    public partial class Form1 : Form
    {
        Button btnLoad;
        PictureBox pbxShowÏmage;
        public Form1()
        {
            InitializeComponent();
            this.Text = "Hello World";

            #region button
            btnLoad = new Button();
            btnLoad.Text = "&Load";
            btnLoad.Left = 30;
            btnLoad.Top = 10;
            btnLoad.Click += new EventHandler(btnLoad_Click);
            this.Controls.Add(btnLoad);
            #endregion
            #region picturebox
            pbxShowÏmage = new PictureBox();
            pbxShowÏmage.BorderStyle = BorderStyle.Fixed3D;
            pbxShowÏmage.Width = Width;
            pbxShowÏmage.Height = Height;
            pbxShowÏmage.Left = (Width - pbxShowÏmage.Width);
            pbxShowÏmage.Top = (Height - pbxShowÏmage.Height);
            pbxShowÏmage.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(pbxShowÏmage);
            #endregion
        }
        void btnLoad_Click(Object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Open Image";
            dialog.Filter = "jpg files (*.jpg)|*.jpg|All files (*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                pbxShowÏmage.Image = new Bitmap(dialog.OpenFile());
            }
            dialog.Dispose();
        }

        private void Hallo_TextChanged(object sender, EventArgs e)
        {

        }

        private void User(object sender, EventArgs e)
        {

        }
    }
    }

