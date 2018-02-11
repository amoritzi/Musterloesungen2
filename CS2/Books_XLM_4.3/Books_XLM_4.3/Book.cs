using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Books_XLM_4._3
{
    [Serializable]
    public class Book
    {
        public string Id { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public double Price { get; set; }
        public DateTime PublishDate { get; set; }
        public string PublishLocation { get; set; }
        public string Description { get; set; }

           public override string ToString()
        {
            return $"Id:{ Id}, Autor:{ Author}, Location:{PublishLocation}, Titel:{ Title}," +
                $" Genre;{Genre}, Preis:{Price}," +
                $"Publikations-Datum:{PublishDate},  " +
                $"Beschreibung: {Description}";  
        } 
    /*    public override string ToString()
        {
            return $"{ Id}, { Author}, { Title}, {Genre}, {Price}, {PublishDate},{Description}";
        }*/
     }

    }
