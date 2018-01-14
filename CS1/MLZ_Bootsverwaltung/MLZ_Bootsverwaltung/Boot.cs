using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLZ_Bootsverwaltung
{
    class Boot
    {
        public int ID { get; set; }
        public string Marke { get; set; }
        public string Modell { get; set; }
        public Farbe Farbe { get; set; }
        public int Nummernschild { get; set; }
        public double Laenge { get; set; }
        public double Breite { get; set; }
        public double Hoehe { get; set; }
        public double Tagesmiete { get; set; }
        public int AnzahlPersonen { get; set; }

    }
}
