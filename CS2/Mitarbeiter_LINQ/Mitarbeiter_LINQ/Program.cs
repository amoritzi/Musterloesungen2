using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mitarbeiter_LINQ
{
    class Program
    {


        static void Main(string[] args)
        {
            MitarbeiterVerzeichnis mitarbeiterVerzeichnis = new MitarbeiterVerzeichnis();
            List<Mitarbeiter> mitarbeiterListe = mitarbeiterVerzeichnis.GetMitarbeiterList();


            // = C.1

            //IEnumerable<Mitarbeiter> query = from Mitarbeiter mitarbeiter in mitarbeiterListe
            //                                 orderby mitarbeiter.Name
            //                                 select mitarbeiter;

            //foreach (Mitarbeiter v in query)
            //{
            //    Console.WriteLine(v.Name + " " + v.Personalnummer + " " + v.Wohnort);
            //}

            // = C.2
            //    var query =
            //         from Mitarbeiter mitarbeiter in mitarbeiterListe
            //         group mitarbeiter by mitarbeiter.Abteilung into newGroup
            //         orderby newGroup.Key
            //         select newGroup;

            //    foreach (var nameGroup in query)
            //    {
            //        Console.WriteLine("\r\n");
            //        Console.WriteLine(nameGroup.Key+":\r\n");
            //        foreach (var mitarbeiter in nameGroup)
            //        {
            //            Console.WriteLine(mitarbeiter.Name + " " + mitarbeiter.Personalnummer + " " + mitarbeiter.Wohnort);
            //        }
            //    }
            //    Console.WriteLine("\r\n");

            // = C.3

            //IEnumerable<Mitarbeiter> query
            //    = from Mitarbeiter mitarbeiter in mitarbeiterListe
            //      where mitarbeiter.Salaer > 6000
            //      orderby mitarbeiter.Salaer
            //      select mitarbeiter;

            //foreach (Mitarbeiter v in query)
            //{
            //    Console.WriteLine(v.Name + " " + v.Personalnummer + " " + v.Wohnort + " " + v.Salaer);
            //}

            // = C.4

            //IEnumerable<Mitarbeiter> query
            //    = from Mitarbeiter mitarbeiter in mitarbeiterListe
            //      where mitarbeiter.PLZ > 8000
            //      orderby mitarbeiter.Wohnort
            //      select mitarbeiter;

            //foreach (Mitarbeiter v in query)
            //{
            //    Console.WriteLine(v.Name + " " + v.PLZ+ " " + v.Wohnort + " " );
            //}

            // 4.2     (r => r.ID == id)
            // A.1

            //var test = mitarbeiterListe.FindAll(s => s.Salaer > 6000);
            //IEnumerable<Mitarbeiter> query
            //    = from Mitarbeiter ma in test
            //      orderby ma.Salaer
            //      select ma;



            //foreach (Mitarbeiter v in query)
            //{
            //    Console.WriteLine(v.Name + " " + v.Personalnummer + " " + v.Wohnort + " " + v.Salaer);
            //}

            // 4.2
            // A.2

            var wohnort = mitarbeiterListe.FindAll(s => s.Wohnort.Length < 6);
            IEnumerable<Mitarbeiter> query
                = from Mitarbeiter ma in wohnort
                  orderby ma.Salaer
                  select ma;



            foreach (Mitarbeiter v in query)
            {
                Console.WriteLine(v.Name + " " + v.Personalnummer + " " + v.Wohnort + " " + v.Salaer);
            }
        }
     }
}

    



