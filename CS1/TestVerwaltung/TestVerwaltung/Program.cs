using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestVerwaltung
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Was möchten Sie erfassen (Auto = A, Motorrad = M, Lieferwagen = L");
            string auswahl = Console.ReadLine();

            if (auswahl == "A")
            {
                Auto eingabe = new Auto();

                eingabe.ErfasseAuto();

            }
        }
    }
}
