using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace WinFormCookbook
{
    [Serializable()]
    class XMLMethods
    {
        //private FileStream readFileStream = new FileStream("XMLFile1.xml", FileMode.Open, FileAccess.Read);
        //private FileStream writeFileStream;


      
        //public void SerializeXMLFile(string fileName)
        //{
        //    //FileStream fs = new FileStream("XMLFile1.xml", FileMode.Create, FileAccess.Write);
        //    writeFileStream = new FileStream("XMLFile1.xml", FileMode.Create, FileAccess.Write);
        //    XmlSerializer serializer = new XmlSerializer(typeof(Kategorie), typeof(Zutaten));
          
        ////Lesen des XML-Dokuments
        //public void ReadXMLFile()
        //{
        //    XmlSerializer serial = new XmlSerializer(typeof(List<ListeClass>));

        //    using (FileStream fs = new FileStream("XMLFile1.xml", FileMode.Open, FileAccess.Read))
        //    {
        //        list = serial.Deserialize(fs) as List<ListeClass>;
        //    }
        //    dataGridView1.DataSource = list;
        //}
        ////Löschen eines Datensatzes
        //public void Remove()
        //{
        //    XmlSerializer serial = new XmlSerializer(typeof(List<ListeClass>));
        //    using (FileStream fs = new FileStream("XMLFile1.xml", FileMode.Open, FileAccess.Read))
        //    {
        //        list = serial.Deserialize(fs) as List<ListeClass>;
        //        fs.Close();
        //    }

        //    foreach (DataGridViewRow row in dataGridView1.SelectedRows)
        //    {
        //        list.RemoveAt(row.Index);
        //    }

        //    using (FileStream fs2 = new FileStream("XMLFile1.xml", FileMode.Create, FileAccess.Write))
        //    {
        //        XmlSerializer xs = new XmlSerializer(typeof(List<ListeClass>));
        //        xs.Serialize(fs2, list);
        //        fs2.Close();
        //    }
        //    dataGridView1.DataSource = list;
        //}
    }
}

