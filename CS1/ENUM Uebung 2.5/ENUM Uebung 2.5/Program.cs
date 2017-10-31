using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENUM_Uebung_2._5
{
    public enum Wochentage
    {
        Montag,
        Dienstag,
        Mittwoch,
        Donnerstag,
        Freitag,
        Samstag,
        Sonntag
    }
    class Program
    {
             
       
        static void Main(string[] args)
        {
            foreach (int en1 in Enum.GetValues(typeof(Wochentage)))
            {
                Console.WriteLine("Wochentage: {0}\n {1}", en1, Enum.GetName(typeof(Wochentage), en1));
            } 
            Console.WriteLine("Bitte einen Wochentag eingeben: ");
            string input = Console.ReadLine();
            int inputnumber = Int32.Parse(input);                                       // Fehlermeldung Formatfehler??
            Wochentage tag = (Wochentage) Enum.Parse(typeof(Wochentage), input);
            Console.WriteLine("Der Wochentag hat folgende Nummer: {0}", inputnumber);

            switch (tag)
            {
                case Wochentage.Montag:
                    Console.WriteLine("Wochentag = Monday");
                    break;
                case Wochentage.Dienstag:
                    Console.WriteLine("Wochentag = Tuesday");
                    break;
                case Wochentage.Mittwoch:
                    Console.WriteLine("Wochentag = Wedensday");
                    break;
                case Wochentage.Donnerstag:
                    Console.WriteLine("Wochentag = Tuesday");
                    break;
                case Wochentage.Freitag:
                    Console.WriteLine("Wochentag = Friday");
                    break;
                case Wochentage.Samstag:
                    Console.WriteLine("Wochentag = Saturday");
                    break;
                case Wochentage.Sonntag:
                    Console.WriteLine("Wochentag = Sunday");
                    break;
            }

        }
    }
}
