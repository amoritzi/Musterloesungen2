using System;

namespace ref_Methode
{
    class Program
    {
        
        public static void PolarToKarthsaRefParam(double radius, double winkel, ref double x, ref double y)
        {
            x = radius * Math.Cos(winkel);
            y = radius * Math.Sin(winkel);
        }

        static void TextMultiParamAsRefParam()
        {
            double radius = 21.2;
            double winkel = 1.23;
            double x = 0, y = 0;
            PolarToKarthsaRefParam(radius, winkel, ref x, ref y);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("X = {0} Y = {1}",ref x, ref y);
        }
    }
}
