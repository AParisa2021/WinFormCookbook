using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WinFormCookbook
{
    [Serializable()]
    public class Zutat
    {
        [XmlElement("Name")]
        public string Name { get; set; }   //property

        [XmlElement("Menge")]
        public double Menge { get; set; }   //property

        [XmlElement("Mengeneinheit")]
        public string Mengeneinheit { get; set; }   //property
     

        public string getMenge()

        {
            return "";
        }
    }
}
