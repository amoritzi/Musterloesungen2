using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimzahlenSieb_Uebung_2._4
{

    class Program
    {
        List<int> ausgangszahlen = new List<int>();
        List<int> primzahlen = new List<int>();
        public int Primzahl;
        public int Eingabe;
       
        public void Zahlenabfuellen()
        {
            ausgangszahlen.Clear();
            Console.WriteLine("Bis zu welcher Zahl möchten Sie die Primzahlen berechnen?");
            Eingabe = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i < (Eingabe + 1); i++)
            {
                ausgangszahlen.Add(i);     // Zahlen ohne 1 abfüllen
                                
            }
                    }

         public void Primzahlen_uebertrag ()
        {
            Primzahl = ausgangszahlen.ElementAt(0);
            ausgangszahlen.Remove(Primzahl);
            primzahlen.Add(Primzahl);
            for (int i = 0; i < ausgangszahlen.Count; i++)
            {
                int modulo = ausgangszahlen.ElementAt(i) % Primzahl;
                Console.WriteLine("Modulo bei: {0} = {1}", i, modulo);
                if (modulo == 0)
                {
                    int streichzahl = ausgangszahlen.ElementAt(i);
                    ausgangszahlen.Remove(streichzahl);
                }
            }
         }
        
        public void PrintListe1()
        {
            Console.Write("Gesamt-Zahlenliste (ohne 1): \n");
            foreach (int item in ausgangszahlen)
                Console.WriteLine(item);
        }

        public void PrintListe2()
        {
            Console.Write("Ausgangs-Liste nach Löschung: \n");
            foreach (int item in ausgangszahlen)
                Console.WriteLine(item);
        }
        public void PrintListe3()
        {
            Console.Write("Primzahlen: \n");
            foreach (int item in primzahlen)
                Console.WriteLine(item);
        }

        static void Main(string[] args)
        {
            Program test = new Program();
            test.primzahlen.Clear();
            test.Zahlenabfuellen();
            test.PrintListe1();
            while (test.ausgangszahlen.Count != 0)  
            {
                test.Primzahlen_uebertrag();
                test.PrintListe2();
                }
             test.PrintListe3();
            
        }
    }
}

