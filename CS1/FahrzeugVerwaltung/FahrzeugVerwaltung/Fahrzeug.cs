using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FahrzeugVerwaltung
{

    class Fahrzeug : IComparable
    {
        public int FahrzeugID;
        public string Marke;
        public String Typ;
        public String Farbe;
        public int Hubraum;
        public int Preis;
        public int Jahrgang;
        public String Treibstoff;

        public int CompareTo(object obj)
        {
            return FahrzeugID.CompareTo(obj);
        }
    }
}

   
    

