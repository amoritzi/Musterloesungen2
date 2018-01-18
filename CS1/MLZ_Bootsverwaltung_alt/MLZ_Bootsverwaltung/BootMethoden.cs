using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLZ_Bootsverwaltung

{   [Serializable]
    class BootMethoden
    {
        public static int AnzahlBoote = 0;
        public static int BootId = 1000;
        public static  List<Boot> bootsListe = new List<Boot>();
       

        static void ErfasseBootDaten(Boot boot)
        {
            boot.ID = BootId++;
            bootsListe.Add(new Boot()
            { ID = boot.ID, Marke = boot.Marke, Modell = boot.Modell, Farbe = boot.Farbe,
             Nummernschild = boot.Nummernschild});
        }
        public static Kajak ErfasseKajak()
        {
            Kajak kajak = new Kajak();
            ErfasseBootDaten(kajak);
            bootsListe.Add (new Kajak()
            { Typ = "KAJ" });

            return kajak;
        }
    }
}
