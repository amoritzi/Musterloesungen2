using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mitarbeiter_Hashtable_Uebung_6_1
{
    class MitarbeiterVerzeichnis
    {
        public Hashtable mitarbeitervz = new Hashtable();

        public void Add (Mitarbeiter mitarbeiter)
        {
            mitarbeitervz.Add(mitarbeiter.Personalnummer, mitarbeiter);

        }
        

    }
}
