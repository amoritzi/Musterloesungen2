using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using System.Windows.Forms;

namespace MLZ_Bootsverwaltung
{
    [Serializable]
    class BootController
    {
      //  Boot boot = new Boot();
               
        public BootController()
        {

        }

        // File Save bzw. Read
        public static void SerializeXml(string file, List<Boot> bootsliste)
        {
            Stream stm = new FileStream(file, FileMode.Create);
            XmlSerializer xs = new XmlSerializer(typeof(List<Boot>));
            xs.Serialize(stm, bootsliste);
            stm.Flush();
            stm.Close();
        }

        public static List<Boot> DeserializeXml(string file)
        {
            Stream stm = new FileStream(file, FileMode.Open);
            XmlSerializer xs = new XmlSerializer(typeof(List<Boot>));
            object obj = xs.Deserialize(stm);
            stm.Close();
            return obj as List<Boot>;
        }

    }
}
    

