using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books_XLM_4._3
{
    [Serializable]
    class Buchliste
    {
        Book book = new Book();
        public static List<Book> buchListe = new List<Book>();
    }
}
