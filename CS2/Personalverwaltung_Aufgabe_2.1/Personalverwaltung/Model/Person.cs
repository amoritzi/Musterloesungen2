using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personalverwaltung.Model
{
    public class Person
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Vorname { get; set; }
        public string Strasse { get; set; }
        public int PLZ { get; set; }
        public string Ort { get; set; }
        public string Telefon { get; set; }

        public override string ToString()
        {
            return  $"{Name}, {Vorname}, {Strasse}, {PLZ}, {Ort}"; 
        }

    }
}
