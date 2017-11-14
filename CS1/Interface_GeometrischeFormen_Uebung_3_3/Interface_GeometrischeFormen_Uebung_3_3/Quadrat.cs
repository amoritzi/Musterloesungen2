using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_GeometrischeFormen_Uebung_3_3
{
    class Quadrat : IForm
    {
        public double Seitenlaenge;

        // Konstruktor empfängt Seitenlänge:
        public Quadrat(double seitenlaenge)
        {
            Seitenlaenge = seitenlaenge;
        }
        // Eigenschaft Umfang, nur get-Methode nötig:
        public double Umfang
        {
            get
            {
                return  4 * Seitenlaenge;
            }
        }


        public double Flaeche()
        {
            
            return Seitenlaenge * Seitenlaenge;
        }
    }
}
