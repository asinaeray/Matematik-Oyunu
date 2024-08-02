using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;


namespace denememath
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

            toplama t = new toplama();
            
            t.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cıkarma r = new cıkarma();

            r.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            carpma w = new carpma();

            w.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bolme t = new bolme();

            t.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
