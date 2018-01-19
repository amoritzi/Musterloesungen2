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
       
        public BootController()
        {

        }
        public BootController(string Marke, string Modell)
        {
            boot.Marke = Marke;
            boot.Modell = Modell;
        }
              public void Erfassen(Boot boot)
              {
                    BootId++;

                    boot.bootsListe.Add(new Boot()
                    {
                         ID = BootId,
                         Marke = boot.Marke,
                         Modell = boot.Modell
                  //  Farbe = boot.Farbe,
                   //  Nummernschild = boot.Nummernschild
        });
           }



    public void Mutieren(Boot boot)
        {

            boot.bootsListe.Insert(MainForm.Index, new Boot()
            {
                ID = MainForm.id,
                Marke = boot.Marke,
                Modell = boot.Modell
            });
            
        }

      /*  public static void ErfasseKajak()
                 {
                     Kajak kajak = new Kajak();
                     ErfasseBootDaten(kajak);
                 }  */
        }
    }

