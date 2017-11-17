using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FahrzeugVerwaltung
{

    class Fahrzeug
    {
        public int FahrzeugID { get; set; }
        public string Marke { get; set; }
        public string Typ { get; set; }
        public string Farbe { get; set; }
        public int Hubraum { get; set; }
        public double Preis { get; set; }
        public DateTime Jahrgang { get; set; }
        public string Treibstoff { get; set; }

        //public override string ToString()
        //{
        //    return $"Id:{}, Typ:{}, Marke:{Marke}, Typ: { Typ}";
        //  //  return String.Format("Id:{0}, Marke:{1}, Typ:{2}", FahrzeugID, Marke, Typ); // Variante mit Platzhaltern
        //}
    }
}

   
    

