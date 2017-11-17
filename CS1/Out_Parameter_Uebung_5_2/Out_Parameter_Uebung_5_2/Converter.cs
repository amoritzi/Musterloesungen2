using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Out_Parameter_Uebung_5_2
{
    class Converter
    {
        public static void PolarToKarthAsOutParam(double radius, double winkel, out double x, out double y)
        {
            x = radius * Math.Cos(winkel);
            y = radius * Math.Sin(winkel);
        }

        public static void PolarToKarthAsRefParam(double radius, double winkel, ref double x, ref double y)
        {
            x = radius * Math.Cos(winkel);
            y = radius * Math.Sin(winkel);
        }

       
    }
}
