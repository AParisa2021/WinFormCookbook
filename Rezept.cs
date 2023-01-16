using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WinFormCookbook
{
    [Serializable()]
    public class Rezept
    {
        [XmlElement("Kategorie")]
        public List<Kategorie> kategorien { get; set; }    //später erstelle ich ein ObjektListe aus der Klasse Zutaten ?????????????
        
        [XmlElement("ID")]
        public int ID { get; set; }

        [XmlElement("Name")]
        public string Name { get; set; }   //property

       
        [XmlElement("Beschreibung")]
        public string Beschreibung { get; set; }    //property

        

        [XmlElement("Date")]
        public string Datum { get; set; }    //property
        [XmlElement("Zutaten")]
        public List<Zutat> Zutaten { get; set; }   //später erstelle ich ein ObjektListe aus der Klasse Zutaten ?????????????????????


    }
}
