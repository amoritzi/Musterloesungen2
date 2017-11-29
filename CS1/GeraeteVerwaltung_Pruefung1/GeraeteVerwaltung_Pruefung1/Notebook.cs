using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeraeteVerwaltung_Pruefung1
{
    class Notebook : Geraet
    {
        public string SSDGroesse { get; set; }
        public bool BeleuchteteTastatur { get; set; }
        public bool HDMIAnschluss { get; set; }

        public override string ToString()
        {
            return $"Id:{Id}, Marke:{Marke}, Model:{Model}, OS:{OS}, Arbeitsspeicher:{Arbeitsspeicher}," +
            $"Speicherkapazität:{Speicherkapazitaet}, Bildschirmgrösse:{Bildschirmgroesse}, Akkulaufzeit:{Akkulaufzeit}, " +
            $"Prozessortyp:{Prozessortyp}, Anzahl Prozessoren:{AnzahlProzessoren}, Farbe:{Farbe},Kaufpreis:{Kaufpreis}," +
            $"SSD Grösse:{SSDGroesse}, Beleuchtete Tastatur:{BeleuchteteTastatur}, HDMI Anschluss:{HDMIAnschluss}";
        }
    }
}

