using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulations_Uebung
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variante, falls Methoden nicht static: "Kalkulation kalkulation ) new Kalkulation;
            // kalkulation.Add(5,4)

            Console.WriteLine($"Summe: {Kalkulation.Add(3.125f, 7)}"); // Kein Objekt nötig, da Methoden static
            Console.WriteLine($"Summe: {Kalkulation.Add(3, 7)}");
            Console.WriteLine($"Summe: {Kalkulation.Add(3.125f, 7.5f)}");
        }
    }
}
