using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormCookbook
{
    [Serializable()]
    public partial class MainForm : Form
    {
        List<Kategorie> kategorie = new List<Kategorie>();
        public MainForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormZutaten formZutaten = new FormZutaten();
            formZutaten.Show();
        }
    }
}
//https://www.youtube.com/watch?v=qY7C9fcbILg        https://www.youtube.com/watch?v=nlpBNTVs89E https://www.youtube.com/watch?v=NWDO8qveFp4