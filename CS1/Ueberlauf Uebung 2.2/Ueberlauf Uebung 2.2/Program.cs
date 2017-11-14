using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ueberlauf_Uebung_2._2
{
    class Program
    {

       
        static void Main(string[] args)

        { 

        byte zahl1;
        byte zahl2;
        byte summe;
        string inputString1;
        string inputString2;

        
            Console.WriteLine("Bitte erste Zahl eingaben: ");
            inputString1 = Console.ReadLine();
            Console.WriteLine("Bitte zweite Zahl eingaben: ");
            inputString2 = Console.ReadLine();
            //     zahl1 = Byte.Parse(inputString1);
            //     zahl2 = Byte.Parse(inputString2);
            zahl1 = Convert.ToByte(inputString1);
            zahl2 = Convert.ToByte(inputString2);
            checked
            {
                summe = (byte) (zahl1 + zahl2);
            }
            Console.WriteLine("Summe = {0}", summe);
            Console.WriteLine($"Summe = {summe}");
        }
    }
}
