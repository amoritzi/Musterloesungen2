using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Out_Parameter_Uebung_5_2
{
    class Program
    {
        static void TextMultiParameterAsOutParam()
        {

            double radius = 21.2;
            double winkel = 1.23;
            double x, y;
            Converter.PolarToKarthAsOutParam(radius, winkel, out x, out y);
            Console.WriteLine($"X(out) = {x.ToString()}"+" "+ $"Y = {y.ToString()}");

        }

        static void TextMultiParameterAsRefParam()
        {

            double radius = 21.2;
            double winkel = 1.23;
            double x = 0, y = 0;
            Converter.PolarToKarthAsRefParam(radius, winkel, ref x, ref y);
            Console.WriteLine($"X(ref) = {x.ToString()}" + " " + $"Y = {y.ToString()}");

        }
        static void Main(string[] args)
        {
            TextMultiParameterAsOutParam();
            TextMultiParameterAsRefParam();


        }
    }
}
