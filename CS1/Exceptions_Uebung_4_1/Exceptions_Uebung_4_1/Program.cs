using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions_Uebung_4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            Person p1 = new Person();

            p.Name = "Meier";
            p.Vorname = "Hans";
            p.Stadt = "Bern";

            p1.Name = "Müller";
            p1.Vorname = "Mario";
            p1.Stadt = "Zürich";

            if (p.CompareTo(p1) < 0)
            {
                Console.WriteLine("Das erste Objekt ist kleiner als das zweite.");
            }
            if (p.CompareTo(p1) == 0)
            {
                Console.WriteLine("Die beiden Objekte sind gleich.");
            }
            if (p.CompareTo(p1) > 0)
            {
                Console.WriteLine("Das erste Objekt ist grösser, als das zweite.");
            }
            else Console.WriteLine("Kein Vergleich möglich!");
                 Environment.Exit(0);
        }
    }
}
