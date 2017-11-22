using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mitarbeiter_Hashtable_Uebung_6_1
{
    class Mitarbeiter
    {
        public int Personalnummer { get; set; }
        public string Name { get; set; }
        public string Vorname { get; set; }
        public string Telefonnummer { get; set; }

        public override string ToString()
        {
            return $"{Personalnummer}, { Name}, { Vorname}, { Telefonnummer}";
        }

        
    }
}
