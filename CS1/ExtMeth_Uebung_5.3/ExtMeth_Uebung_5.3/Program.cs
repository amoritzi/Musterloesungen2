using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtMeth_Uebung_5._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Double d1 = 123.12345;
            Console.WriteLine("Anzahl Nachkomma-Stellen: {0}", d1.CountDecimal());
        }
    }
}
