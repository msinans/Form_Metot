using System;
using System.Windows.Forms;

namespace Form_Metot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Islem islem = new Islem();
        private void button1_Click(object sender, EventArgs e)
        {
            int s1 = Convert.ToInt32(textBox1.Text);
            int s2 = Convert.ToInt32(textBox2.Text);
            int s3 = islem.Topla(s1, s2);
            label2.Text = s3.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int s1 = Convert.ToInt32(textBox1.Text);
            int s2 = Convert.ToInt32(textBox2.Text);
            int s3 = islem.Cikar(s1, s2);
            label2.Text = s3.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double s1 = Convert.ToDouble(textBox1.Text);
            double s2 = Convert.ToDouble(textBox2.Text);
            double s3 = islem.Bol(s1, s2);
            label2.Text = s3.ToString(("0.00"));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int s1 = Convert.ToInt32(textBox1.Text);
            int s2 = Convert.ToInt32(textBox2.Text);
            int s3 = islem.Carp(s1, s2);
            label2.Text = s3.ToString();
        }
    }
}
