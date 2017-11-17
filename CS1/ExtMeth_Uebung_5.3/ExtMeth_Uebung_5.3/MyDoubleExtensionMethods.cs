using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtMeth_Uebung_5._3
{
    public static class MyDoubleExtensionMethods
    {
        public static int CountDecimal(this Double doub)
        {

            String s = doub.ToString();
            s = s.Substring(s.IndexOf(".") + 1);
            return s.Length;
            
        }
    }
}
