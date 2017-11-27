using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FahrzeugVerwaltung;

namespace FahrzeugVerwaltung
{
    class Program
    {
        public static int Index = 0;
        static Fahrzeug[] fahrzeuge = new Fahrzeug[100];
        public static int FahrzeugeZaehlen;
        public static String Eingabe;
        public static int FahrzID = 1;

        public static void AbfrageArt()
        {
            Console.WriteLine("Was möchten Sie erfassen? (Auto = A, Motorrad = M, Lieferwagen = L):\noder Programm beenden = E:\n" +
                "oder Fahrzeugliste drucken = F");
            Eingabe = Console.ReadLine();
            Console.WriteLine("Eingabe: {0}", Eingabe);


            switch (Eingabe)
            {
                case "A":

                    fahrzeuge[Index] = AutoDatenErfassen();  // Damit wird das Objekt "Auto" in den Array geschrieben!
                    Index++;                                 // Auch möglich wäre ganz am Schluss der Methode
                    Console.WriteLine("Index: {0}", Index);  // fahrzeuge[] = auto;
                    FahrzeugeZaehlen++;
                    AbfrageArt();
                    break;

                case "F":

                    Console.WriteLine("Anzahl erfasster Fahrzeuge: {0}", FahrzeugeZaehlen);
                    FahrzeugListe(fahrzeuge);
                    AbfrageArt();
                    break;

                case "M":

                    fahrzeuge[Index] = MotorradDatenErfassen();
                    Index++;
                    FahrzeugeZaehlen++;
                    AbfrageArt();
                    break;

                case "L":

                    fahrzeuge[Index] = LieferwagenDatenErfassen();
                    Index++;
                    FahrzeugeZaehlen++;
                    AbfrageArt();
                    break;

                case "E":

                    Environment.Exit(0);
                    break;

                default:

                    Console.WriteLine("Falsche Eingabe!");
                    break;
            }
        }

        static void Main(string[] args)
        {
            AbfrageArt();
        }
        static Fahrzeug Datenerfassung(Fahrzeug fz)    // Hier wird der allgemeine Teil der Variablen erfasst.
        {

            fz.FahrzeugID = FahrzID++;
            fahrzeuge[Index] = new Auto();


            Console.WriteLine("Bitte geben Sie die Marke ein:");
            fz.Marke = Console.ReadLine();
            fahrzeuge[Index].Marke = fz.Marke;

            //Console.WriteLine("Bitte geben Sie den Typ ein:");
            //fz.Typ = Console.ReadLine();
            //fahrzeuge[Index].Typ = fz.Typ;

            //Console.WriteLine("Bitte geben Sie die Hubraum ein:");
            //fz.Hubraum = Convert.ToInt32(Console.ReadLine());
            //fahrzeuge[Index].Hubraum = fz.Hubraum;

            //Console.WriteLine("Bitte geben Sie die Preis ein:");
            //fz.Preis = Convert.ToInt32(Console.ReadLine());
            //fahrzeuge[Index].Preis = fz.Preis;

            //Console.WriteLine("Bitte geben Sie die Jahrgang ein:");
            //fz.Jahrgang = Convert.ToInt32(Console.ReadLine());
            //fahrzeuge[Index].Jahrgang = fz.Jahrgang;

            //Console.WriteLine("Bitte geben Sie die Treibstoff-Art ein:");
            //fz.Treibstoff = Console.ReadLine();
            //fahrzeuge[Index].Treibstoff = fz.Treibstoff;

            return fz;

        }
        static Auto AutoDatenErfassen()
        {
            Auto auto = new Auto();
            Datenerfassung(auto);       // In dieser Methode werden die zusätzlichen Variablen miterfasst.

            Console.WriteLine("Bitte geben Sie die Anzahl Airbags ein:");
            auto.Airbags = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Bitte geben Sie den Innenfarbe ein:");
            //auto.Innenfarbe = Console.ReadLine();

            //Console.WriteLine("Bitte geben Sie ein, ob das eine Klima-Anlage vorhanden ist ( J/N :");
            //auto.KlimaAnlage = Console.ReadLine();
            
            return auto;

        }

        static Motorrad MotorradDatenErfassen()
        {
            Motorrad motorrad = new Motorrad();
            Datenerfassung(motorrad);

            Console.WriteLine("Bitte geben Sie die Extras ein:");
            motorrad.Extras = Console.ReadLine();

            //Console.WriteLine("Bitte geben Sie das Tankvolumen ein:");
            //motorrad.Tankvolumen = Convert.ToInt32(Console.ReadLine());

            return motorrad;

        }

        static Lieferwagen LieferwagenDatenErfassen()
        {
            Lieferwagen lieferwagen = new Lieferwagen();
            Datenerfassung(lieferwagen);

            Console.WriteLine("Bitte geben Sie die Sitzplätze ein:");
            lieferwagen.Sitzplaetze = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Bitte geben Sie die Extras ein:");
            //lieferwagen.Ladegewicht = Convert.ToInt32(Console.ReadLine());

            return lieferwagen;

        }
        static void FahrzeugListe(Fahrzeug[] fahrzeuge)
        {



            foreach (Fahrzeug fz in fahrzeuge)
            {
                if (fz != null)
                {
                    if (fz is Auto)
                    {
                        Auto car = fz as Auto;
                        Console.WriteLine("Id:{0} Marke:{1} Airbags:{2} ", car.FahrzeugID, car.Marke, car.Airbags);
                    }
                    else if (fz is Motorrad)
                    {
                        Motorrad moto = fz as Motorrad;
                        Console.WriteLine("Id:{0}, Marke:{1} , Typ:{2}, Extras:{3}", moto.FahrzeugID, moto.Marke, moto.Typ, moto.Extras);
                    }
                    else if (fz is Lieferwagen)
                    {
                        Lieferwagen lkw = fz as Lieferwagen;
                        Console.WriteLine("Id:{0} Marke:{1} Sitzplätze:{2} ", lkw.FahrzeugID, lkw.Marke, lkw.Typ, lkw.Sitzplaetze);
                    }
                }
               
            }
        }
    }
}


         
    
    




