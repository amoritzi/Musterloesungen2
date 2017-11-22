using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mitarbeiter_Hashtable_Uebung_6_1
{
    class Testtreiber
    {
        MitarbeiterVerzeichnis mvz = new MitarbeiterVerzeichnis();
        Array[] marray;
       

        public void MitarbeiterAbfuellen()
        {
            

            Mitarbeiter m1 = new Mitarbeiter() { Personalnummer = 1, Name = "Müller", Vorname = "Hans", Telefonnummer = "044 950 34 55" };
            mvz.Add(m1);
            Mitarbeiter m2 = new Mitarbeiter() { Personalnummer = 2, Name = "Meyer", Vorname = "Fritz", Telefonnummer = "043 955 66 57" };
            mvz.Add(m2);
            Mitarbeiter m3 = new Mitarbeiter() { Personalnummer = 3, Name = "Cekic", Vorname = "Arda", Telefonnummer = "079 855 00 57" };
            mvz.Add(m3);
            
        }

        public Hashtable MAListe()
        {
            
            foreach (Mitarbeiter element in mvz.mitarbeitervz.Values)
            {
                Console.WriteLine(element);
            }
            int anzahl = mvz.mitarbeitervz.Count;
            Console.WriteLine("Anzahl: {0}", anzahl);
            
            return mvz.mitarbeitervz;

        }

        public Hashtable ArrayCopy ()
        {
            marray = new Array[mvz.mitarbeitervz.Count];
            //Console.WriteLine("Count: {0}", mvz.mitarbeitervz.Count);
            mvz.mitarbeitervz.CopyTo(marray, 0);

            return mvz.mitarbeitervz;
        }
    }
 }
  

