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
        public FormZutaten()
        {
            InitializeComponent();
            
        }

        private void FormZutaten_Load(object sender, EventArgs e)
        {
            //TextBox[] txtZutat = new TextBox[] {textBox1, textBox6, textBox10, textBox13, textBox16, textBox19, textBox22, textBox25, textBox28,
            //textBox55, textBox52, textBox49, textBox46, textBox43, textBox40, textBox37, textBox34, textBox31};

            //string zutaten = "";
            //for(int i = 0; i < zutaten.Length; i++)
            //{
            //    txtZutat[i].Text = zutaten[i].ToString();
            //}


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Rezepte rezepte = new Rezepte();

            //add new recipe
            Rezept neuRezept = new Rezept();
            neuRezept.Name = txtName.Text; //todo: create methods to fill object, you cannot use Parameters
            rezepte.rezepte.Add(neuRezept);     //KLasse Rezepte.Liste aus Klasse rezepte


            //Rezept Suppe
            //Rezept suppe = new Rezept();
            //suppe.Name = "Suppe";
            //suppe.ID = 100;
            //rezepte.rezepte.Add(suppe);
            //write and serialize
            using (FileStream file = new FileStream("Rezepte.xml", FileMode.Open, FileAccess.Write))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Rezepte));
                serializer.Serialize(file, rezepte);
            }

        }
    }    
}
