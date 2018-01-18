using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLZ_Bootsverwaltung
{
    class BootController
    {
        public static int AnzahlBoote = 0;
        public static int BootId = 1000;
        Boot boot = new Boot();
        public static List<Boot> bootsListe = new List<Boot>();

        public BootController(string Marke, string Modell)
        {
            boot.Marke = Marke;
            boot.Modell = Modell;
        }
        public BootController()
        {

        }
        public static void ErfasseBootDaten(Boot boot)
        {
            BootId++;

            
                bootsListe.Add(new Boot()

            {   ID = BootId,
                Marke = boot.Marke,   
                Modell = boot.Modell,
              //  Farbe = boot.Farbe,
              //  Nummernschild = boot.Nummernschild
            });
        }

        public static void ErfasseKajak()
            {
                Kajak kajak = new Kajak();
                ErfasseBootDaten(kajak);
            }
            

        
    }
}
