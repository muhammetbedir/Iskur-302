using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsMetrobus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Interval = 200;
            timer1.Start();
        }
        int counter = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if (pictureBox1.Left >= 170 && pictureBox1.Left <=185)
            {
                Random random = new Random();
                pictureBox1.Left = pictureBox1.Left;
                label1.BackColor = Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255));
                counter++;
                if (counter == 6)
                {
                    label1.BackColor = Color.Transparent;
                    counter = 0;
                    pictureBox1.Left = pictureBox1.Left + 15;

                }
            }
            else if (pictureBox1.Left >= 330 && pictureBox1.Left <= 345)
            {
                Random random = new Random();
                pictureBox1.Left = pictureBox1.Left;
                label2.BackColor = Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255));
                counter++;
                if (counter == 6)
                {
                    label2.BackColor = Color.Transparent;
                    counter = 0;
                    pictureBox1.Left = pictureBox1.Left + 15;

                }

            }
            else if (pictureBox1.Left >= 510 && pictureBox1.Left <= 525)
            {
                Random random = new Random();
                pictureBox1.Left = pictureBox1.Left;
                label3.BackColor = Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255));
                counter++;
                if (counter == 6)
                {
                    label3.BackColor = Color.Transparent;
                    counter = 0;
                    pictureBox1.Left = pictureBox1.Left + 15;

                }

            }
            else if (pictureBox1.Left >= 700 && pictureBox1.Left <= 715)
            {
                Random random = new Random();
                pictureBox1.Left = pictureBox1.Left;
                label4.BackColor = Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255));
                counter++;
                if (counter == 6)
                {
                    label4.BackColor = Color.Transparent;
                    counter = 0;
                    pictureBox1.Left = pictureBox1.Left + 15;

                }

            }
            else if (pictureBox1.Left >= 850 && pictureBox1.Left <= 865)
            {
                timer1.Stop();

            }
            else
            {
                pictureBox1.Left = pictureBox1.Left + 15;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = true;
            timer2.Interval = 200;
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            if (pictureBox2.Left >= 170 && pictureBox2.Left <= 185)
            {
                Random random = new Random();
                pictureBox2.Left = pictureBox2.Left;
                label1.BackColor = Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255));
                counter++;
                if (counter == 6)
                {
                    label1.BackColor = Color.Transparent;
                    counter = 0;
                    pictureBox2.Left = pictureBox2.Left - 15;

                }
            }
            else if (pictureBox2.Left >= 330 && pictureBox2.Left <= 345)
            {
                Random random = new Random();
                pictureBox2.Left = pictureBox2.Left;
                label2.BackColor = Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255));
                counter++;
                if (counter == 6)
                {
                    label2.BackColor = Color.Transparent;
                    counter = 0;
                    pictureBox2.Left = pictureBox2.Left - 15;

                }

            }
            else if (pictureBox2.Left >= 510 && pictureBox2.Left <= 525)
            {
                Random random = new Random();
                pictureBox2.Left = pictureBox2.Left;
                label3.BackColor = Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255));
                counter++;
                if (counter == 6)
                {
                    label3.BackColor = Color.Transparent;
                    counter = 0;
                    pictureBox2.Left = pictureBox2.Left - 15;

                }

            }
            else if (pictureBox2.Left >= 700 && pictureBox2.Left <= 715)
            {
                Random random = new Random();
                pictureBox2.Left = pictureBox2.Left;
                label4.BackColor = Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255));
                counter++;
                if (counter == 6)
                {
                    label4.BackColor = Color.Transparent;
                    counter = 0;
                    pictureBox2.Left = pictureBox2.Left - 15;

                }

            }
            else if (pictureBox2.Left >= 40 && pictureBox2.Left <= 55)
            {
                timer1.Stop();

            }
            else
            {
                pictureBox2.Left = pictureBox2.Left - 15;
            }
        }
    }
}
