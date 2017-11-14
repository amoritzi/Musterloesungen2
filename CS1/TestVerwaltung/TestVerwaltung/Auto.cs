using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestVerwaltung
{
    class Auto
    {
        public int FahrzeugID;
        public string Marke;
        public String Typ;
        Auto[] AutoDaten = new Auto[100];
        Auto[] fahrzeug = new Auto[100];
        static int Index;
       

        public void ErfasseAuto()
        {
            Console.WriteLine("Bitte geben Sie die FahrzeugID ein:");
            FahrzeugID = Convert.ToInt32(Console.ReadLine());
            fahrzeug[Index++] = new Auto();
            fahrzeug[Index++].FahrzeugID = FahrzeugID;

            Console.WriteLine("Bitte geben Sie die Marke ein:");
            Marke = Console.ReadLine();
            AutoDaten[Index++].Marke = Marke;

            Console.WriteLine("Bitte geben Sie den Typ ein:");
            Typ = Console.ReadLine();
            AutoDaten[Index++].Typ = Typ;

            Console.WriteLine(" \nSie haben erfasst:\n FahrzeugID = {0}\n Marke = {1}\n Typ = {2}", FahrzeugID, Marke, Typ);

           foreach (Object element in AutoDaten)
            {
                Console.WriteLine(element);
                Console.ReadLine();
            }
            
        }
    }
}
