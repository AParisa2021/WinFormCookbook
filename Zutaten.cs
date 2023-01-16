using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WinFormCookbook
{
    [Serializable()]

    public class Zutaten
    {
        [XmlElement("Zutat")]
        public List<Zutat> zutaten;
    }
}
