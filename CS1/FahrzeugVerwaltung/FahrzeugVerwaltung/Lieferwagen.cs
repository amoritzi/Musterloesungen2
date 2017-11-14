using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FahrzeugVerwaltung
{
    class Lieferwagen : Fahrzeug, IFahrzeug
    {
        public int Sitzplaetze;
        public int Ladegewicht;

        public Lieferwagen()
        {
           
        }

        public void Datenerfassung()
        {
            throw new NotImplementedException();
        }

        public void FahrzeugListe()
        {
            throw new NotImplementedException();
        }
    }
}
