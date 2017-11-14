using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperaturUmrechner_Uebung_3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Temperatur t0 = new Temperatur(0);
            Temperatur t1 = new Temperatur() { Kelvin = 280.0 };
            Temperatur t2 = new Temperatur(7);
            Temperatur t3 = new Temperatur(t0.Kelvin);

            //Console.WriteLine("Kelvin: {0}", t0.Kelvin);
            //Console.ReadLine();

            t1.Celsius = 20.5;
            

           
                        
            if (t1.CompareTo(t2) < 0)
            {
                Console.WriteLine("Die erste Temperatur ist kleiner als die zweite.");
            }
            if (t1.CompareTo(t2) == 0)
            {
                Console.WriteLine("Die beiden Temperaturen sind gleich.");
            }
            if (t1.CompareTo(t2) > 0)
            {
                Console.WriteLine("Die erste Temperatur ist grösser, als die zweite.");
            }
            Temperatur t5 = new Temperatur();
            t5.GradeAbfuellen();
        }
        
        

       
    }
}
