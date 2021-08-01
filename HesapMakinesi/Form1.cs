using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesi
{
    public partial class Form1 : Form
    {
        double x, y;
        string z;
        public static double sayi = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void b1_Click(object sender, EventArgs e)
        {
            txt.Text = txt.Text + "1";
        }

        private void b2_Click(object sender, EventArgs e)
        {
            txt.Text = txt.Text + "2";
        }

        private void b3_Click(object sender, EventArgs e)
        {
            txt.Text = txt.Text + "3";
        }

        private void b4_Click(object sender, EventArgs e)
        {
            txt.Text = txt.Text + "4";
        }

        private void b5_Click(object sender, EventArgs e)
        {
            txt.Text = txt.Text + "5";
        }

        private void b6_Click(object sender, EventArgs e)
        {
            txt.Text = txt.Text + "6";
        }

        private void b7_Click(object sender, EventArgs e)
        {
            txt.Text = txt.Text + "7";
        }

        private void b8_Click(object sender, EventArgs e)
        {
            txt.Text = txt.Text + "8";
        }

        private void b9_Click(object sender, EventArgs e)
        {
            txt.Text = txt.Text + "9";
        }

        private void b0_Click(object sender, EventArgs e)
        {
            txt.Text = txt.Text + "0";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (z == "+")
            {
                y = Convert.ToInt32(txt.Text);
                txt.ResetText();
                txt.Text = Convert.ToString(x + y);
            }
            if (z == "-")
            {
                y = Convert.ToInt32(txt.Text);
                txt.ResetText();
                txt.Text = Convert.ToString(x - y);
            }
            if (z == "*")
            {
                y = Convert.ToInt32(txt.Text);
                txt.ResetText();
                txt.Text = Convert.ToString(x * y);
            }
            if (z == "/")
            {
                y = Convert.ToInt32(txt.Text);
                txt.ResetText();
                txt.Text = Convert.ToString(x / y);
            }
            if (z == "usth")
            {
                y = Convert.ToInt32(txt.Text);
                txt.ResetText();
                txt.Text = Convert.ToString(Math.Pow(x, y));
            }
        }

        private void bÇıkar_Click(object sender, EventArgs e)
        {
            x = Convert.ToInt32(txt.Text);
            txt.ResetText();
            z = "-";
        }

        private void bÇarp_Click(object sender, EventArgs e)
        {
            x = Convert.ToInt32(txt.Text);
            txt.ResetText();
            z = "*";
        }

        private void bBöl_Click(object sender, EventArgs e)
        {
            x = Convert.ToInt32(txt.Text);
            txt.ResetText();
            z = "/";
        }

        private void bÜs_Click(object sender, EventArgs e)
        {
            x = Convert.ToInt32(txt.Text);
            txt.ResetText();
            z = "usth";
        }

        private void bTopla_Click(object sender, EventArgs e)
        {
            x = Convert.ToInt32(txt.Text);
            txt.ResetText();
            z = "+";
        }

        private void bMod_Click(object sender, EventArgs e)
        {
            x = Convert.ToInt32(txt.Text);
            txt.Text = Convert.ToString(Math.Sqrt(x));
        }

        private void bGeriSil_Click(object sender, EventArgs e)
        {
            if (txt.Text.Length > 0)

            {

                txt.Text = txt.Text.Substring(0, txt.Text.Length - 1);

            }
        }

        private void bSil_Click(object sender, EventArgs e)
        {
            txt.ResetText();
        }
    }
}
