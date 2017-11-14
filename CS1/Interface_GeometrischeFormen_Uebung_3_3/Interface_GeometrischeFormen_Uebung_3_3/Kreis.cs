using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_GeometrischeFormen_Uebung_3_3
{
    class Kreis : IForm
    {

        public double Radius;

        // Konstruktor empfängt Radius:
        public Kreis(double radius)
        {
            Radius = radius;
        }
        // Eigenschaft Umfang, nur get-Methode nötig:
        public double Umfang
        { 
            get
            {
                return 2 * Radius * Math.PI; ;
            }
        }

        public double Flaeche()
        {
            return Math.Pow(Radius, 2) * Math.PI;
        }
    }
}
