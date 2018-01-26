using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MLZ_Bootsverwaltung
{
    [Serializable]
    class BootModell
    {
        Boot boot = new Boot();
        public List<Boot> bootsListe = new List<Boot>();
    }
}
