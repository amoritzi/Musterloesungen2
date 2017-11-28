using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions_Uebung_4_1
{
    class Person : IComparable
    {
        public string Name { get; set; }
        public string Vorname { get; set; }
        public string Stadt { get; set; }

        public int CompareTo(object p)
        {
            if (p == null) return 1;

            Person pers = p as Person;
            if (p is Person p1)
            {
                return this.CompareTo(p);
            }
            else
            {
                throw new ArgumentException("Object ist keine Person!");
            }

        }
    }
}
