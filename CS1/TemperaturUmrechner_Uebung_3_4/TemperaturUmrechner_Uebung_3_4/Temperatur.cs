using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperaturUmrechner_Uebung_3_4
{
    class Temperatur : IComparable
    {
        protected double temperaturC;

        public Temperatur()
        {
        }

        public Temperatur(double tC)
        {
            temperaturC = tC;
        }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            Temperatur andereTemperatur = obj as Temperatur;
            if (andereTemperatur != null)
                return this.temperaturC.CompareTo(andereTemperatur.temperaturC);
            else
                throw new ArgumentException("Object ist keine Temperatur!!");

        }

        public double Celsius
        {
            get
            {
                return temperaturC;
            }
            set
            {
                 temperaturC = value + 273.15;   // value = der übergebene Wert!! (im Konstruktor oder mit t1 = xx)
            }
        }
        public double Kelvin
        {
            get
            {
                return temperaturC + 273.15;
            }
            set => temperaturC = value + 273.15;

        }
        public double Fahrenheit
        {
            get
            {
                return (temperaturC * 1.8) + 32;
            }
            set => temperaturC = value * 1.8 + 32;
        }
        public void GradeAbfuellen()
        {
            int[] temp = new int[10];
            Random rnd = new Random();

            for (int i = 0; i < 10; i++)
            {
                int grad = rnd.Next(0, 100);
                temp[i] = grad;
            }
                //foreach (int element in temp)
                //{
                //    Console.WriteLine("Unsortierte Grade: {0}", element);
                //}
            Array.Sort(temp);
            Console.WriteLine();
                foreach (int element in temp)
                {
                    Console.WriteLine("Sortierte Grade: {0}", element);
                }
            Console.ReadLine();
        }
        }
    }

