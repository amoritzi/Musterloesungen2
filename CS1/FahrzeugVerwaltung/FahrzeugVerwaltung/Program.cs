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
                    FahrzeugListe();
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

                    return;

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

            Console.WriteLine("Bitte geben Sie das Sitzplätze ein:");
            lieferwagen.Sitzplaetze = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Bitte geben Sie die Extras ein:");
            //lieferwagen.Ladegewicht = Convert.ToInt32(Console.ReadLine());

            return lieferwagen;

        }
        static void FahrzeugListe()
        {
         //   Fahrzeug[] sorted = fahrzeuge.OrderBy(c => c.FahrzeugID).ToArray();

            //foreach (Fahrzeug element in fahrzeuge)
            //{
            //    foreach (Auto element1 in fahrzeuge)     // Auto anstelle von Object, dadurch können die Airbags auch angesprochen werden.
            //    {
            //        if (element1 != null)
            //        {
                        
            //                Console.WriteLine("Erfasste Fahrzeuge:\n {0} {1} {2} ", element1.FahrzeugID, element1.Marke, element1.Airbags);
            //                
                        
            //        }




                    foreach (Motorrad element2 in fahrzeuge)     // Motorrad anstelle von Object, dadurch können die Airbags auch angesprochen werden.
                    {
                        if (element2 != null)
                        {
                           
                                Console.WriteLine("Erfasste Fahrzeuge:\n {0} {1} {2} {3}", element2.FahrzeugID, element2.Marke, element2.Extras, element2.Tankvolumen);
                                
                            
                        }

                    }

                    foreach (Lieferwagen element3 in fahrzeuge)     // Lieferwagen anstelle von Object, dadurch können die Airbags auch angesprochen werden.
                    {
                        if (element3 != null)
                        {
                           
                                Console.WriteLine("Erfasste Fahrzeuge:\n {0} {1} {2} {3}", element3.FahrzeugID, element3.Marke, element3.Sitzplaetze, element3.Ladegewicht);
                               
                            
                        }
                    }
                
                AbfrageArt();
            }
        }

        
    }


         
    
    




