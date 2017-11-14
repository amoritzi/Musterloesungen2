using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace HexadezimalerRechner
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int result;
            string inputString1;
            string inputString2;
            string oper;

            Console.WriteLine("Eingabe erste Zahl:");
            inputString1 = Console.ReadLine();
            Console.WriteLine("Eingabe zweite Zahl:");
            inputString2 = Console.ReadLine();
            Console.WriteLine("Eingabe Operator:");
            oper = Console.ReadLine();

            if (Int32.TryParse(inputString1, NumberStyles.HexNumber,CultureInfo.InvariantCulture, out a))
            { }
            else
                Console.WriteLine("Fehler: Falsches Format!");
            if (Int32.TryParse(inputString2, NumberStyles.HexNumber, CultureInfo.InvariantCulture, out b))
            { }
            else
                Console.WriteLine("Fehler: Falsches Format!");

            switch(oper)
            {
                case "+":
                    result = a + b;
                    Console.WriteLine("Resultat: {0:X}", result);
                    break;

                case "-":
                    result = a - b;
                    Console.WriteLine("Resultat: {0:X}", result);
                    break;
                    
                case "*":
                    result = a * b;
                    Console.WriteLine("Resultat: {0:X}", result);
                    break;
                case "/":
                    result = a / b;
                    Console.WriteLine("Resultat: {0:X}", result);
                    break;
            }
            
     
                
            }

       




        }
    }

