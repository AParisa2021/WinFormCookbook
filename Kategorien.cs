using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WinFormCookbook
{
    [Serializable()]

    public class Kategorien
    {
        [XmlElement("Kategorie")]
        List<Kategorie> kategorien;
    }
}
