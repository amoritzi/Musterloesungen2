using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mitarbeiter_Hashtable_Uebung_6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Testtreiber tt = new Testtreiber();
            MitarbeiterVerzeichnis mv = new MitarbeiterVerzeichnis();
           
           
            tt.MitarbeiterAbfuellen();
            tt.MAListe();
            tt.ArrayCopy();
           
            
           

            

        }
    }
}
