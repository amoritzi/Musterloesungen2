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
    public partial class TmpSensor : Form , ISubject
    {
        private List<IObserver> _observers = new List<IObserver>();
        public System.Windows.Forms.TrackBar MyTB;

        public TmpSensor()
        {
            InitializeComponent();
        }

        private void TempRegl_Scroll(object sender, EventArgs e)
        {
            System.Windows.Forms.TrackBar myTB;
            myTB = (System.Windows.Forms.TrackBar)sender;
        }

        private void NumDisp_Click(object sender, EventArgs e)
        {
            NumericDisplay NC = new NumericDisplay();
            NC.Show();
        }

        public void Attach(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void Notify(IObserver observer)
        {
            foreach (IObserver o in _observers)

            {

                o.Update();

            }
        }
    }
}
