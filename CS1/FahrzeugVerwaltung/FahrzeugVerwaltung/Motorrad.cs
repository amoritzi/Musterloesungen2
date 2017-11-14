using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FahrzeugVerwaltung
{
    class Motorrad : Fahrzeug, IFahrzeug
    { 
    public string Extras;
    public int Tankvolumen;

        public Motorrad()
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
