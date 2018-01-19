using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLZ_Bootsverwaltung
{
    [Serializable]
    class Boot
    {
        /*     public Boot()
             {

             }
             public Boot(string Marke, string Modell)
             {
                 // Farbe Farbe, int Nummernschild, double Laenge,
                 //  double Breite, double Hoehe, double Tagesmiete, int AnzahlPersonen, string Typ
             }

         */
        public List<Boot> bootsListe = new List<Boot>();
        public int ID { get; set; }
        public string Typ { get; set; }
        public string Marke { get; set; }
        public string Modell { get; set; }
        public Farbe Farbe { get; set; }
        public int Nummernschild { get; set; }
        public double Laenge { get; set; }
        public double Breite { get; set; }
        public double Hoehe { get; set; }
        public double Tagesmiete { get; set; }
        public int AnzahlPersonen { get; set; }

        public override string ToString()
        {
            return ID + " " + Marke +" "+ Modell;
        }


    }
}
