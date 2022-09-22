using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace encrypting01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string anametin = textBox1.Text;
            byte[] veridizim = ASCIIEncoding.ASCII.GetBytes(anametin);
            //textBox2.Text = veridizim[0].ToString();
            string cryed = Convert.ToBase64String(veridizim);
            textBox2.Text = cryed;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string kodlu = textBox2.Text;
            byte[] veriler = Convert.FromBase64String(kodlu);
            /*
            string ekran = "";

            foreach (var item in veriler)
            {
                ekran = ekran + item;
            }
            textBox1.Text = ekran;
            */
            textBox1.Text = ASCIIEncoding.ASCII.GetString(veriler);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox4.Text = "";
            string anametin = textBox3.Text;
            string kodlu = "";
            char[] charlar = anametin.ToCharArray();
            foreach (var item in charlar)
            {
                kodlu += Convert.ToChar(item+5);
            }
            textBox4.Text = kodlu;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            string anametin = textBox4.Text;
            string kodlu = "";
            char[] charlar = anametin.ToCharArray();
            foreach (var item in charlar)
            {
                kodlu += Convert.ToChar(item-5);
            }
            textBox3.Text = kodlu;
        }
        public void ultimate()
        {
            string anametin = textBox1.Text;
            byte[] veridizim = ASCIIEncoding.ASCII.GetBytes(anametin);
            string cryed = Convert.ToBase64String(veridizim);
            char[] cchar = cryed.ToCharArray();
            string koddlu = "";
            foreach (var item in cchar)
            {
                koddlu += Convert.ToChar(item - 5);
            }
            textBox2.Text = koddlu;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Console.WriteLine(Convert.ToString('a', 2));
        }
    }
}
