using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_GeometrischeFormen_Uebung_3_3
{
       class Program
    {
        
        static void Main(string[] args)
        {
            Kreis k1 = new Kreis(12.5);
            Quadrat q1 = new Quadrat(6.5);
            TestTreiber tt = new TestTreiber();
            tt.Drucke(k1);
            tt.Drucke(q1);
        }
    }
}
