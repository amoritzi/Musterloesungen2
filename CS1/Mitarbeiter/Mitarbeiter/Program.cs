using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mitarbeiter
{
    class Progamm
    {
        


        public static Mitarbeiter eingabe()
        {
            string feld1;
           
            Mitarbeiter neuerMitarbeiter = new Mitarbeiter();

            Console.WriteLine("Bitte Vorname eingeben: ");
            neuerMitarbeiter.Vorname = Console.ReadLine();
            Console.WriteLine("Bitte Nachname eingeben: ");
            neuerMitarbeiter.Nachname = Console.ReadLine();
            Console.WriteLine("Bitte Personalnummer eingeben: ");
            feld1 = Console.ReadLine();
            neuerMitarbeiter.Personalnummer = Int32.Parse(feld1);
            Console.WriteLine("Bitte Eintrittsdatum (DD.MM.YY) eingeben: ");
            feld1 = Console.ReadLine();
            neuerMitarbeiter.Eintrittsdatum = DateTime.Parse(feld1);
            Console.WriteLine("Bitte Geburtsdatum (DD.MM.YY) eingeben: ");
            feld1 = Console.ReadLine();
            neuerMitarbeiter.Geburtsdatum = DateTime.Parse(feld1);
            Console.WriteLine("Bitte Salär eingeben: ");
            feld1 = Console.ReadLine();
            neuerMitarbeiter.Salaer = Decimal.Parse(feld1);
            Console.WriteLine("Bitte Private Adresse eingeben: ");
            neuerMitarbeiter.Private_Adresse = Console.ReadLine();
            Console.WriteLine("Bitte Telefonnummer eingeben: ");
            neuerMitarbeiter.Telefonnummer = Console.ReadLine();

            return neuerMitarbeiter;
        }

        public static void ausgabe(Mitarbeiter mitarbeiter)
        { 
            
        
            Console.WriteLine("Vorname = {0}" , mitarbeiter.Vorname);
            Console.WriteLine("Nachname = {0}", mitarbeiter.Nachname);
            Console.WriteLine("Personalnummer = {0}", mitarbeiter.Personalnummer);
            Console.WriteLine("Eintrittsdatum = {0}", mitarbeiter.Eintrittsdatum);
            Console.WriteLine("Geburtsdatum = {0}", mitarbeiter.Geburtsdatum);
            Console.WriteLine("Salär = {0}", mitarbeiter.Salaer);
            Console.WriteLine("Private Adresse = {0}", mitarbeiter.Private_Adresse);
            Console.WriteLine("Telefonnummer = {0}", mitarbeiter.Telefonnummer);


        }

       

        static void Main(string[] args)
        {
            Mitarbeiter m = eingabe();
            ausgabe(m);



        }
    }
}
