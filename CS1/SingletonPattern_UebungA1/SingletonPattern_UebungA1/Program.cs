using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern_UebungA1
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton testinstanz = Singleton.Instance;
            Type test = testinstanz.GetType();
            Console.WriteLine("Typ: {0}", test);
        }
    }
}
