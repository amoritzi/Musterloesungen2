using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FahrzeugVerwaltung
{
    class Auto : Fahrzeug
    {
        public int Airbags { get; set; }
        public string Innenfarbe { get; set; }
        public string KlimaAnlage { get; set; }

        //public override string ToString()
        //{
        //    return $"Id:{}, Typ:{}, Marke:{Marke}, Typ: { Typ}, KlimaAnlage:{KlimaAnlage}";
        //}
    }


}
