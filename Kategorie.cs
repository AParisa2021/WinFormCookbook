using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace WinFormCookbook
{
    [Serializable()]
    public class Kategorie
    {
        [XmlElement("Kategorie")]
        public string Name { get; set; }   //property
      
    }
}
