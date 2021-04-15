using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT02_Y1_Klassen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        List<IGerätModel> Shop = new List<IGerätModel>();
        int aktuellesGerät = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            Shop.Add(new Gerät(Int32.Parse(textBox1.Text), textBox2.Text));

            textBox1.Text = "";
            textBox2.Text = "";

            gerätAnzahlLabel.Text = Shop[0].getAnzahl().ToString();
        }


        private void button2_Click(object sender, EventArgs e)
        {

            gerätLabel.Text = Shop[aktuellesGerät].getGeraetedaten();

            if (aktuellesGerät < Shop.Count-1)
            {
                aktuellesGerät++;
            }
            else
            {
                aktuellesGerät = 0;
            }
        }
    }
}
