using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DateTime_Uebung_2._6
{


    class Program
    {

        static void Main(string[] args)
        {

            DateTime enddate = DateTime.Now;
            DateTime starterde = new DateTime(1969, 7, 16, 13, 32, 00);
            DateTime landungmond = new DateTime(1969, 7, 20, 20, 17, 00);
            DateTime startmond = new DateTime(1969, 7, 21, 17, 54, 00);
            DateTime landungerde = new DateTime(1969, 7, 24, 16, 50, 35);

            TimeSpan diff1 = enddate.Subtract(starterde);
            double days = diff1.TotalDays;
            Int32 year = (int) days / 365;
            Console.WriteLine("Jahre-Differenz: {0}", year);
            int month = (int)days / 30;
            Console.WriteLine("Monate-Differenz: {0}", month);
            Console.WriteLine("Tage-Differenz: {0}", days);
            double hours = diff1.TotalHours;
            Console.WriteLine("Stunden-Differenz: {0}", hours);
            double minutes = diff1.TotalMinutes;
            Console.WriteLine("Minuten-Differenz: {0}", minutes);
            double seconds = diff1.TotalSeconds;
            Console.WriteLine("Sekunden-Differenz: {0}\n", seconds);

            TimeSpan flugzeiterde_mond = landungmond.Subtract(starterde);
            double hours2 = flugzeiterde_mond.TotalHours;
            Console.WriteLine("Flugzeit Erde - Mond: {0} Stunden \n", hours2);

            TimeSpan flugzeitmond_erde = landungerde.Subtract(startmond);
            double hours3 = flugzeitmond_erde.TotalHours;
            Console.WriteLine("Flugzeit Mond - Erde: {0} Stunden \n", hours3);

            TimeSpan mondzeit = startmond.Subtract(landungmond);
            double hours4 = mondzeit.TotalHours;
            Console.WriteLine("Aufenthaltsdauer Mond: {0} Stunden", hours4);

        }
    }
}

