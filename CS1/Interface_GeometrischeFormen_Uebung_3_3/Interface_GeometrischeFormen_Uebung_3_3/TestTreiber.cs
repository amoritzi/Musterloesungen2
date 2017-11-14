using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_GeometrischeFormen_Uebung_3_3
{
    class TestTreiber
    {
        // Die Verwendung von IForm erlaubt den "neutralen" Zugriff auf Fläche und Umfang!
        public void Drucke(IForm myForm)
        {
            Console.WriteLine("Fläche: {0} und Umfang: {1}", myForm.Flaeche(), myForm.Umfang);
            Console.ReadLine();
        }

    }
}
