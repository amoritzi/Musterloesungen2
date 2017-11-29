using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeraeteVerwaltung_Pruefung1
{
    class Geraet
    {
        public int Id { get; set; }
        public string Marke { get; set; }
        public string Model { get; set; }
        public string OS { get; set; }
        public string Arbeitsspeicher{ get; set; }
        public string Speicherkapazitaet { get; set; }
        public string Bildschirmgroesse { get; set; }
        public double Akkulaufzeit { get; set; }
        public string Prozessortyp { get; set; }
        public int AnzahlProzessoren { get; set; }
        public Farbe Farbe { get; set; }
        public double Kaufpreis { get; set; }

        public override string ToString()
        {
                return $"Id:{Id}, Marke:{Marke}, Model:{Model}, OS:{OS}, Arbeitsspeicher:{Arbeitsspeicher}," +
                $"Speicherkapazität:{Speicherkapazitaet}, Bildschirmgrösse:{Bildschirmgroesse}, Akkulaufzeit:{Akkulaufzeit}, " +
                $"Prozessortyp:{Prozessortyp}, Anzahl Prozessoren:{AnzahlProzessoren}, Farbe:{Farbe},Kaufpreis:{Kaufpreis}";

            
        }
    }
}
