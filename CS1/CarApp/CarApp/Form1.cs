using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarApp
{
    public partial class MainForm : Form
    {
        List<string> cars;
        public MainForm()
        {
            InitializeComponent();
        }
        
        private void MainForm_Load(object sender, EventArgs e)
        {
            cars = new List<string>()
            {
                "Audi A3",
                "BMW 320",
                "Mercedes A3",
                "Toyota C-HR",
                "Ford Focus"
            };
            UpdateCarList();
        }
        private void UpdateCarList()
        {
            LbxCarList.DataSource = null;  // Damit Liste neu geladen wird!
            LbxCarList.DataSource = cars;
        }

        private void BtnAddCar_Click(object sender, EventArgs e)
        {
            if (TbxInputCar.Text != String.Empty)
            {
                cars.Add(TbxInputCar.Text);
                UpdateCarList();
            }
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            // Variante a
            if (LbxCarList.SelectedItem != null)
            {
                cars.Remove(LbxCarList.SelectedItem.ToString());

                // Variante b
                // cars.RemoveAt(LbxCarList.SelectedIndex);
                UpdateCarList();
            }
        }

        private void BtnModify_Click(object sender, EventArgs e)
        {
            if ((LbxCarList.SelectedItem != null) && (TbxInputCar.Text != String.Empty))
            {
                // Variante a
             //   cars[LbxCarList.SelectedIndex] = TbxInputCar.Text;
               

                // Variante b
                cars.RemoveAt(LbxCarList.SelectedIndex);
                cars.Insert(LbxCarList.SelectedIndex, TbxInputCar.Text);

                UpdateCarList();
            }
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test Message Box");
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
