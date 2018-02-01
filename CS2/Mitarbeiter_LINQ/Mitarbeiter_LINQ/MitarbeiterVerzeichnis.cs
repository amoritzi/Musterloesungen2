using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mitarbeiter_LINQ
{
    class MitarbeiterVerzeichnis
    {
        public List<Mitarbeiter> GetMitarbeiterList()
        {
            List<Mitarbeiter> mitarbeiterListe = new List<Mitarbeiter>
            {
                new Mitarbeiter {
                    Personalnummer = 100,
                    Name = "Meier",
                    Vorname = "Andreas",
                    Abteilung = "Buchhaltung",
                    Strasse = "Stationsstrasse 59",
                    PLZ = 8606,
                    Wohnort = "Greifensee",
                    Telefonnummer = "044 940 58 14",
                    Salaer = 8500.00
                },
                new Mitarbeiter {
                Personalnummer = 101, Name = "Müller", Vorname = "Alex",
                Abteilung = "Produktion", Strasse = "Sandbüelstr. 59",
                PLZ = 8702, Wohnort = "Küsnacht", Telefonnummer = "044 981 55 01", Salaer = 6800.00 },
                new Mitarbeiter {
                Personalnummer = 102, Name = "Gujer", Vorname = "Erich",
                Abteilung = "Produktion", Strasse = "Burstwiesenstr. 14",
                PLZ = 8600, Wohnort = "Dübendorf", Telefonnummer = "043 753 55 02", Salaer = 7650.00 },
                new Mitarbeiter {
                Personalnummer = 103, Name = "Stögmüller", Vorname = "Heinz",
                Abteilung = "Bau", Strasse = "Letzistr. 46",
                PLZ = 8006, Wohnort = "Zürich", Telefonnummer = "044 754 88 99", Salaer = 5350.00 },
                new Mitarbeiter {
                Personalnummer = 104, Name = "Wernli", Vorname = "Dani",
                Abteilung = "Produktion", Strasse = "Horbstr. 47",
                PLZ = 3000, Wohnort = "Bern", Telefonnummer = "031 251 44 88", Salaer = 5200.00 },
                new Mitarbeiter {
                Personalnummer = 105, Name = "Gallmeier", Vorname = "Fritz",
                Abteilung = "Einkauf", Strasse = "Lenggistr. 13",
                PLZ = 2120, Wohnort = "Lausanne", Telefonnummer = "021 755 55 02", Salaer = 3500.00 },
                new Mitarbeiter {
                Personalnummer = 106, Name = "Gugger", Vorname = "Jean",
                Abteilung = "Einkauf", Strasse = "Traufferweg 4",
                PLZ = 7000, Wohnort = "Chur", Telefonnummer = "081 753 55 02", Salaer = 4800.00 },
                new Mitarbeiter {
                Personalnummer = 107, Name = "Geisser", Vorname = "Heiri",
                Abteilung = "Produktion", Strasse = "Hurniweg 6",
                PLZ = 7450, Wohnort = "Klosters", Telefonnummer = "081 550 93 01", Salaer = 5900.00 },
                new Mitarbeiter {
                Personalnummer = 108, Name = "Maissen", Vorname = "Sacha",
                Abteilung = "Leitung", Strasse = "Bernstr. 12",
                PLZ = 5000  , Wohnort = "Aarau", Telefonnummer = "053 950 41 20", Salaer = 8700.00 },
                new Mitarbeiter {
                Personalnummer = 109, Name = "Mayer", Vorname = "Franz",
                Abteilung = "Produktion", Strasse = "Davoserstr. 9",
                PLZ = 7250, Wohnort = "Klosters", Telefonnummer = "081 225 68 00", Salaer = 7000.00 },
                new Mitarbeiter {
                Personalnummer = 110, Name = "Hügli", Vorname = "Barbara",
                Abteilung = "Buchhaltung", Strasse = "Steigstr. 12",
                PLZ = 8400, Wohnort = "Winterthur", Telefonnummer = "052 722 55 15", Salaer = 3600.00 }
            };
            return mitarbeiterListe;
        }
    }
}

