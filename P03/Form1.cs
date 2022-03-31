using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P03
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
            string text = textBox1.Text;
            int k=0;
            bool x = false;
            foreach(char q in text)
            {
                if(q >= '0' && q <= '9')
                {
                    k = Convert.ToInt32(q-48);
                    x = true;
                    break;
                }
            }
            label1.Text = k.ToString();

            if(x)
            {
                if (k < text.Length)
                {
                    text = text.Remove(text.Length - k);
                }
                else text = string.Empty;
            }
            textBox2.Text = text;
            
        }
    }
}
