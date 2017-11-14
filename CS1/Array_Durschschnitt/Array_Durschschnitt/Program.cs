using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Durschschnitt
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rechner = new int[10];
            string intputString;
            int zahl = 0;
            int summe = 0;
            double durchschnitt = 0;

            for (int a = 0; a < rechner.Length; a++) {
                zahl = 0;
                Console.WriteLine("Bitte Zahl eingeben:");
                intputString = Console.ReadLine();
                zahl = Convert.ToByte(intputString);
                rechner[a] = zahl;
            }
            foreach (int i in rechner)
            {
                System.Console.Write("Eingabe: {0} ", i);
            }

                foreach (int k in rechner)
                {
                    summe = summe + k;
                durchschnitt = (double) (summe / rechner.Length);
                    
                };
                Console.WriteLine("Durchschnitt = {0}", durchschnitt);

                }
        }
    }

