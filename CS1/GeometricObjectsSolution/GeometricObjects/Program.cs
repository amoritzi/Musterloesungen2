using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            //Circle kreis = new Circle();
            //kreis.Radius = 12;

            //// Kreisfläche abrufen

            //double area = kreis.GetArea();
            //Console.WriteLine("Fläche = {0}", area);

            //// Kreisumfang abrufen

            //Console.WriteLine("Umfang = {0}", kreis.GetCircumference());
            //Console.ReadLine();


            //Circle kreis = new Circle();
            //kreis.XCoordinate = -100;
            //kreis.YCoordinate = 90;
            //kreis.Move(120, -200);
            //Console.WriteLine("X = {0} und Y = {1}", kreis.XCoordinate, kreis.YCoordinate);
            //Console.ReadLine();

            //Circle kreis1 = new Circle();
            //kreis1.Radius = 12;
            //Circle kreis2 = new Circle();
            //kreis2.Radius = 23;

            //if (kreis1.Bigger(kreis2) == -1)
            //    Console.WriteLine("Objekt 'kreis1' ist kleiner als Objekt 'kreis2'");
            //Console.ReadLine();

            GraphicCircle gc = new GraphicCircle();
            Console.WriteLine("Anzahl der Kreise = {0}", GraphicCircle.CountCircles);
            Console.ReadLine();
        }
    }
}
