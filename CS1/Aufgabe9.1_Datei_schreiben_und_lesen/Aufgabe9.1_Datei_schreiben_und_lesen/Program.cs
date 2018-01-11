using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe9._1_Datei_schreiben_und_lesen
{
    class Program
    {
        public static double GesamtTotal { get; set; }
        public static String Eingabe;

        public static void Einlesen()
        { 
            Bestellung bs = new Bestellung();

            Console.WriteLine("Bitte geben Sie die Produkt ID ein.");
            Eingabe = Console.ReadLine();
            bs.Prod_ID = Convert.ToInt32(Eingabe);

            Console.WriteLine("Bitte geben Sie den Namen ein.");
            Eingabe = Console.ReadLine();
            bs.Prod_Name = Eingabe;
                       
            Console.WriteLine("Bitte geben Sie die Menge ein.");
            Eingabe = Console.ReadLine();
            bs.Menge = Convert.ToInt32(Eingabe);
           
            Console.WriteLine("Bitte geben Sie den Preis ein.");
            Eingabe = Console.ReadLine();
            bs.Einzelpreis = Convert.ToDouble(Eingabe);
            bs.Total = bs.Menge * bs.Einzelpreis;
            GesamtTotal += bs.Total;
            

            if (!File.Exists("Bestellung.txt"))
            {
                FileStream fs = new FileStream("Bestellung.txt", FileMode.Create);
                TextWriter tw = new StreamWriter(fs, Encoding.UTF8);
                tw.WriteLine(bs.Prod_ID + ";" + bs.Prod_Name + ";" + bs.Menge + ";" + bs.Einzelpreis + ";" + bs.Total);
                tw.Close();
            }
            else
            {
                FileStream fs = new FileStream("Bestellung.txt", FileMode.Append);
                TextWriter tw = new StreamWriter(fs, Encoding.UTF8);
                tw.WriteLine(bs.Prod_ID + ";" + bs.Prod_Name + ";" + bs.Menge + ";" + bs.Einzelpreis + ";" + bs.Total);
                tw.Close();
            }
            
            Console.WriteLine("Wollen Sie eine weitere Bestellung erfassen? (J/N)");
            Eingabe = Console.ReadLine();
                if (Eingabe == "J")
                {
                    Console.WriteLine("Neue Bestellung:");
                    Einlesen();
                }
                if (Eingabe == "N")
                {
                // File auslesen und anzeigen
                TextReader tr = new StreamReader("Bestellung.txt");
                    string line;
                    while ((line = tr.ReadLine()) != null)
                    {
                    Console.WriteLine(line);
                    }
                tr.Close();
                Console.WriteLine("Gesamttotal = {0}", GesamtTotal);
            }
                 else
                {
                Console.WriteLine("Falsche Eingabe!");
                Console.WriteLine("Wollen Sie eine weitere Bestellung erfassen? (J/N)");
                Eingabe = Console.ReadLine();
                if (Eingabe == "J")
                {
                    Console.WriteLine("Neue Bestellung:");
                    Einlesen();
                }
                if (Eingabe == "N")
                {
                    // File auslesen und anzeigen
                    TextReader tr = new StreamReader("Bestellung.txt");
                    string line;
                    while ((line = tr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                    tr.Close();
                }
                else
                {
                    Console.WriteLine("Falsche Eingabe!");
                }
            }
            
          

            
        }
        static void Main(string[] args)
        {
            Einlesen();

        }
    }
}
