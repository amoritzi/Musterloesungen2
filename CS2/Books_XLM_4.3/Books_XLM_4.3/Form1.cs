using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Books_XLM_4._3
{
    [Serializable]
    public partial class Form1 : Form
    {
        CultureInfo provider = CultureInfo.InvariantCulture;
        private BindingSource lbxBindingSource = new BindingSource();
        Book book = new Book();

       public Form1()
        {
            InitializeComponent();
        }

        private void BtnList_Click(object sender, EventArgs e)
        {
            XDocument books = XDocument.Load(@"../../data/books.xml");

            var booklist = (from book in books.Descendants("book")
                            select new Book()
                            {
                                Id = book.Attribute("id").Value,
                                Author = book.Element("author").Value,
                                Title = book.Element("title").Value,
                                Genre = book.Element("genre").Value,
                                Price = Double.Parse(book.Element("price").Value),
                                PublishDate = DateTime.Parse(book.Element("publish_date").Value),
                                Description = book.Element("description").Value
                            }).ToList();
            LbxBookList.BeginUpdate();
            foreach (var elem in booklist)
            {
                LbxBookList.Items.Add(elem);
            }
            LbxBookList.EndUpdate();
        }

        private void BtnCSV_Click(object sender, EventArgs e)
        {
            XDocument books = XDocument.Load(@"../../data/books.xml");

            var booklist = (from book in books.Descendants("book")
                            select new Book()
                            {
                                Id = book.Attribute("id").Value,
                                Author = book.Element("author").Value,
                                Title = book.Element("title").Value,
                                Genre = book.Element("genre").Value,
                                Price = Double.Parse(book.Element("price").Value),
                                PublishDate = DateTime.Parse(book.Element("publish_date").Value),
                                Description = book.Element("description").Value
                            }).ToList();

            SeralizeBinary($"Books.csv", booklist);
            MessageBox.Show("Speicherung erfolgreich! Filename: Books.csv");
        }

        public List<Book> LeseDatei(List<Book> booklist)
        {
            XDocument books = XDocument.Load(@"../../data/books.xml");

            booklist = (from book in books.Descendants("book")
                        select new Book()
                        {
                            Id = book.Attribute("id").Value,
                            Author = book.Element("author").Value,
                            Title = book.Element("title").Value,
                            Genre = book.Element("genre").Value,
                            Price = Double.Parse(book.Element("price").Value),
                            PublishDate = DateTime.Parse(book.Element("publish_date").Value),
                            Description = book.Element("description").Value
                        }).ToList();

            return booklist;
        }

        private static void SeralizeBinary(string file, object root)
        {
            Stream stm = new FileStream(file, FileMode.Create);
            IFormatter fmt = new BinaryFormatter();
            fmt.Serialize(stm, root);
            stm.Flush();
            stm.Close();
        }

        private void BtnXML_Click(object sender, EventArgs e)
        {
            XDocument books = XDocument.Load(@"../../data/books.xml");

            var booklist = (from book in books.Descendants("book")
                            select new Book()
                            {
                                Id = book.Attribute("id").Value,
                                Author = book.Element("author").Value,
                                Title = book.Element("title").Value,
                                Genre = book.Element("genre").Value,
                                Price = Double.Parse(book.Element("price").Value),
                                PublishDate = DateTime.Parse(book.Element("publish_date").Value),
                                Description = book.Element("description").Value
                            }).ToList();

            SerializeXml($"books.xml", booklist);
            MessageBox.Show("Speicherung erfolgreich! Filename: books.xml");

        }
        public static void SerializeXml(string file, List<Book> booklist)
        {
            Stream stm = new FileStream(file, FileMode.Create);
            XmlSerializer xs = new XmlSerializer(typeof(List<Book>));
            xs.Serialize(stm, booklist);
            stm.Flush();
            stm.Close();
        }

        private void BtnPriceSelect_Click(object sender, EventArgs e)
        {
            XDocument books = XDocument.Load(@"../../data/books.xml");

            var billigBuch = (from book in books.Descendants("book")
                              where (double)book.Element("price") < 20
                              select new Book()
                              {
                                  Id = book.Attribute("id").Value,
                                  Author = book.Element("author").Value,
                                  Title = book.Element("title").Value,
                                  Genre = book.Element("genre").Value,
                                  Price = Double.Parse(book.Element("price").Value),
                                  PublishDate = DateTime.Parse(book.Element("publish_date").Value),
                                  Description = book.Element("description").Value
                              }).ToList();

            SerializeXml($"teilbooks.xml", billigBuch);
            MessageBox.Show("Speicherung erfolgreich! Filename: teilbooks.xml");

        }

        private void BtnISBN_Click(object sender, EventArgs e)
        {
            XDocument books = XDocument.Load(@"../../data/books.xml");

            var mut = from book in books.Descendants("book")
                      where (string)book.Attribute("id") != null
                      select new Book();

            foreach (var elem in mut)
            {
                books.Add(new XAttribute("isbn", "new value"));
            }


            //    XAttribute title = new XAttribute("isbn", "");

        /*    XElement root = books.Root;
            root.Elements("book").Where(f => f.Attribute("id").Value == "bk101")
              .Select(f => f.Element("book")).Single().Add
                   (
                       new XAttribute
                           (
                               "book", new XAttribute("isbn", "variable")
                           )
                    );  */


           /*       XElement root = books.Root;
                  root.Elements("book").Where(f => f.Attribute("id").Value == "bk101")
                      .Select (f => f).Single().Add(new XAttribute("isbn"));  */

        }

        private void BtnStadt_Click(object sender, EventArgs e)
        {
            XDocument books = XDocument.Load(@"../../data/books.xml");

            XElement root = books.Root;
            foreach (XAttribute mutation in root.Attributes())
            {
                root.Add(new XElement("publishing_location", "new content"));
            }
            root.Elements("book").Where(g => g.Attribute("id").Value == "bk101")
                .Select(g => g.Element("publishing_location")).Single().Value = "Bern";

            books.Save(@"../../data/modbooks.xml");

  /*          var booklist = (from book in books.Descendants("book")
                            select new Book()
                            {
                                Id = book.Attribute("id").Value,
                                Author = book.Element("author").Value,
                                Title = book.Element("title").Value,
                                Genre = book.Element("genre").Value,
                                Price = Double.Parse(book.Element("price").Value),
                                PublishDate = DateTime.Parse(book.Element("publish_date").Value),
             //                   PublishLocation = book.Element("publishing_location").Value,
                                Description = book.Element("description").Value
                            }).ToList();

            LbxBookList.BeginUpdate();
            foreach (var elem in booklist)
            {
                LbxBookList.Items.Add(elem);
            }
            LbxBookList.EndUpdate();   */
        }  

    }
}

    

