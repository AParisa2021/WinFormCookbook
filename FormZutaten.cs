using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace WinFormCookbook
{
    [Serializable()]
    public partial class FormZutaten : Form
    {
        List<Zutat> zutaten = new List<Zutat>();
        public TextBox[] txtZutat = new TextBox[18];

        //initialize main object
        Rezepte rezepte = new Rezepte();
       
        public FormZutaten()
        {
            InitializeComponent();
            loadRecipes();
        }

        private void FormZutaten_Load(object sender, EventArgs e)
        {

        }

        private void loadRecipes()
        {
            using (FileStream file = new FileStream("Rezepte.xml", FileMode.Open, FileAccess.Read))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Rezepte));
                this.rezepte = (Rezepte) serializer.Deserialize(file);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
          

            //add new recipe
            Rezept neuRezept = new Rezept();
            neuRezept.Name = txtName.Text;
            rezepte.rezepte.Add(neuRezept);     



            //write to xml
            using (FileStream file = new FileStream("Rezepte.xml", FileMode.Open, FileAccess.Write))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Rezepte));
                serializer.Serialize(file, rezepte);
            }

        }
    }    
}
