using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsHesapMakinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text += "1";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text += "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text += "8";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text += "2";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text += "3";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text += "4";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text += "5";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text += "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text += "9";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text += "0";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += ".";
        }
        string islem = "";
        private void button13_Click(object sender, EventArgs e)
        {
            if (islem == "-")
            {
                depo -= double.Parse(textBox1.Text);
            }
            else if (islem == "*")
            {
                depo *= double.Parse(textBox1.Text);

            }
            else if (islem == "/")
            {
                depo /= double.Parse(textBox1.Text);

            }
            else
            {
                depo += double.Parse(textBox1.Text);
            }

            label1.Text = Convert.ToString(depo);
            textBox1.Text = null;
            islem = "+";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            if (islem == "+")
            {
                depo += double.Parse(textBox1.Text);
                textBox1.Text = Convert.ToString(depo);

            }
            if (islem == "-")
            {
                depo -= double.Parse(textBox1.Text);
                textBox1.Text = Convert.ToString(depo);
            }
            if (islem == "*")
            {
                depo *= double.Parse(textBox1.Text);
                textBox1.Text = Convert.ToString(depo);
            }
            if (islem == "/")
            {
                depo /= double.Parse(textBox1.Text);
                textBox1.Text = Convert.ToString(depo);
            }
            label1.Text = null;
            depo = 0;
        }
        double depo = 0;
        private void button14_Click(object sender, EventArgs e)
        {
            if (islem == "-")
            {
                depo -= double.Parse(textBox1.Text);
            }
            else if (islem == "*")
            {
                depo *= double.Parse(textBox1.Text);

            }
            else if (islem == "/")
            {
                depo /= double.Parse(textBox1.Text);

            }
            else
            {
                depo += double.Parse(textBox1.Text);
            }

            label1.Text = Convert.ToString(depo);
            textBox1.Text = null;
            islem = "-";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (islem == "-")
            {
                depo -= double.Parse(textBox1.Text);
            }
            else if (islem == "*")
            {
                depo *= double.Parse(textBox1.Text);

            }
            else if (islem == "/")
            {
                depo /= double.Parse(textBox1.Text);

            }
            else
            {
                depo += double.Parse(textBox1.Text);
            }

            label1.Text = Convert.ToString(depo);
            textBox1.Text = null;
            islem = "/";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (islem == "-")
            {
                depo -= double.Parse(textBox1.Text);
            }
            else if (islem == "*")
            {
                depo *= double.Parse(textBox1.Text);

            }
            else if (islem == "/")
            {
                depo /= double.Parse(textBox1.Text);

            }
            else
            {
                depo += double.Parse(textBox1.Text);
            }

            label1.Text = Convert.ToString(depo);
            textBox1.Text = null;
            islem = "*";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            label1.Text = null;
            textBox1.Text = null;
            depo = 0;
            islem = "";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1,1);
            if (textBox1.Text.Length ==0 )
            {
                textBox1.Text = "0";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D1 || e.KeyCode == Keys.NumPad1)
            {
                button6.PerformClick();
            }
            if (e.KeyCode == Keys.D2 || e.KeyCode == Keys.NumPad2)
            {
                button5.PerformClick();
            }
            if (e.KeyCode == Keys.D3 || e.KeyCode == Keys.NumPad3)
            {
                button4.PerformClick();
            }
            if (e.KeyCode == Keys.D4 || e.KeyCode == Keys.NumPad4)
            {
                button12.PerformClick();
            }
            if (e.KeyCode == Keys.D5 || e.KeyCode == Keys.NumPad5)
            {
                button11.PerformClick();
            }
            if (e.KeyCode == Keys.D6 || e.KeyCode == Keys.NumPad6)
            {
                button10.PerformClick();
            }
            if (e.KeyCode == Keys.D7 || e.KeyCode == Keys.NumPad7)
            {
                button9.PerformClick();
            }
            if (e.KeyCode == Keys.D8 || e.KeyCode == Keys.NumPad8)
            {
                button8.PerformClick();
            }
            if (e.KeyCode == Keys.D9 || e.KeyCode == Keys.NumPad9)
            {
                button7.PerformClick();
            }
            if (e.KeyCode == Keys.D0 || e.KeyCode == Keys.NumPad0)
            {
                button1.PerformClick();
            }
            if (e.KeyCode == Keys.Add || e.KeyCode == Keys.Oemplus )
            {
                button13.PerformClick();
            }
            if (e.KeyCode == Keys.Subtract || e.KeyCode == Keys.OemMinus)
            {
                button14.PerformClick();
            }
            if (e.KeyCode == Keys.Divide )
            {
                button16.PerformClick();
            }
            if (e.KeyCode == Keys.Multiply )
            {
                button15.PerformClick();
            }
            if (e.KeyCode == Keys.Enter)
            {
                button3.PerformClick();
            }
            if (e.KeyCode == Keys.Back)
            {
                button17.PerformClick();
            }
            if (e.KeyCode == Keys.Oemcomma || e.KeyCode == Keys.Decimal) 
            {
                button2.PerformClick();
            }

        }
    }
}
