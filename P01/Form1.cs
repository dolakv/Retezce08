using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string samohlasky = "aeiouyáéěíóúůý";
            string souhlasky = "bcčdďfghjklmnpqrřsštťvwxzž";
            int pocetsamo = 0;
            int pocetsou = 0;
            int pocetostatni = 0;
            string veta = textBox1.Text;
            veta = veta.ToLower();
            foreach (char pismeno in textBox1.Text)
            {
                if (samohlasky.Contains(pismeno))
                {
                    pocetsamo++;
                }
                else if (souhlasky.Contains(pismeno))
                {
                    pocetsou++;
                }
                

            }
            pocetostatni = veta.Length - (pocetsamo + pocetsou);
            MessageBox.Show("pocet samohlasek je " + pocetsamo + ", pocet souhlasek je " + pocetsou + " a pocet ostatnich znaku je " + pocetostatni);
        }
    }
}
