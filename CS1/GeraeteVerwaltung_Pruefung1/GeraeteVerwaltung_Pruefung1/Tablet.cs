using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeraeteVerwaltung_Pruefung1
{
    class Tablet : Geraet
    {
        public bool MicroSDCardSlot { get; set; }
        public bool _4G { get; set; }

        public override string ToString()
        {
            return $"Id:{Id}, Marke:{Marke}, Model:{Model}, OS:{OS}, Arbeitsspeicher:{Arbeitsspeicher}," +
            $"Speicherkapazität:{Speicherkapazitaet}, Bildschirmgrösse:{Bildschirmgroesse}, Akkulaufzeit:{Akkulaufzeit}, " +
            $"Prozessortyp:{Prozessortyp}, Anzahl Prozessoren:{AnzahlProzessoren}, Farbe:{Farbe},Kaufpreis:{Kaufpreis}," +
            $"Micro SD Card Slot:{MicroSDCardSlot}, 4G:{_4G}";        }
    }
}
