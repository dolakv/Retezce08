using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P02
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
            string veta = textBox1.Text;
            string veta2 = string.Empty;
            int posun = Convert.ToInt32(textBox2.Text);
            char pismeno2;

            int i;
            foreach(char pismeno in veta)
            {
                if (pismeno >= 'A' && pismeno <= 'Z')
                {
                    pismeno2 = pismeno;
                    i = (int)pismeno2;
                    if(pismeno2 == 'z' || pismeno2 == 'Z')
                    {
                        i += posun - 26;
                    }
                    else
                    {
                        i += posun;
                    }
                    pismeno2 = (char)i;
                    veta2 += pismeno2;
                }
                
            }
            textBox3.Text = veta2;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string veta = textBox1.Text;
            string veta2 = string.Empty;
            int posun = 0;
            char pismeno2;

            int i;
            foreach (char pismeno in veta)
            {
                if (pismeno >= 'A' && pismeno <= 'z')
                {
                    pismeno2 = pismeno;
                    i = (int)pismeno2;
                    if (pismeno2 == 'z' || pismeno2 == 'Z')
                    {
                        i += posun - 26;
                    }
                    else
                    {
                        i += posun;
                    }
                    pismeno2 = (char)i;
                    veta2 += pismeno2;
                }

            }
            textBox3.Text = veta2;
        }
    }
}
