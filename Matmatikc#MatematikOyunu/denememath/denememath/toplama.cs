using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace denememath
{
    public partial class toplama : Form
    {
        public toplama()
        {
            InitializeComponent();
        }
        int Sure = 0;
        Random r = new Random();
        int dogri = 0, yanli = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            Sure++;
            label7.Text = Sure.ToString();
            if (Sure == 30)
            {
               
                button1.Enabled = false;
                timer1.Enabled = false;
                Sure = 0;
                MessageBox.Show("Süreniz Bitti" + " Doğru:" + dogri + " Yanlış:" + yanli);
            }
            return;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sonuc = 0, tahmin = 0;
            sonuc = int.Parse(label1.Text) + int.Parse(label3.Text);
            tahmin = int.Parse(textBox1.Text);

            if (sonuc == tahmin)
            {
                dogri++;
            }
            else
            {
                yanli++;
            }
            label8.Text = dogri.ToString();
            label9.Text = yanli.ToString();

            label1.Text = r.Next(20).ToString();
            label3.Text = r.Next(20).ToString();
            textBox1.Text = "";
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toplama_Load(object sender, EventArgs e)
        {
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("30 Saniyeniz Başladı");
            label7.Text = Sure.ToString();
            label1.Text = r.Next(20).ToString();
            label3.Text = r.Next(20).ToString();
            timer1.Enabled = true;
            return;
        }
    }
}
