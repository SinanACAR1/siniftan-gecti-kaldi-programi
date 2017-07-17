using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double ortalama, devamsızlık;
            ortalama = Convert.ToDouble(textBox1.Text);
            devamsızlık = Convert.ToDouble(textBox2.Text);

            if (ortalama < 50)
            {
                lblsonuc.Text = "kaldın";
            }
            if (ortalama < 50 && devamsızlık >= 30)
            {
                lblsonuc.Text = "kaldın";
            }
            if (devamsızlık >= 30)
            {
                lblsonuc.Text = "kaldın";
            }
            if (ortalama >= 50 && devamsızlık < 30)
            {
                lblsonuc.Text = "geçtin";
            }
            if (ortalama >= 70 && devamsızlık < 30)
            {
                lblsonuc.Text = "Teşekkür alıyorsunuz";
            }
            if (ortalama >= 85 && devamsızlık < 30)
            {
                lblsonuc.Text = "Takdir alıyorsunuz";
            }
        }
    }
}
