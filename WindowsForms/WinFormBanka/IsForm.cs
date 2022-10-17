using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormBanka
{
    public partial class IsForm : Form
    {
        int HangiBanka = 0;
        public IsForm(int hangiBanka)
        {
            InitializeComponent();
            HangiBanka = hangiBanka;
        }

        private void IsForm_Load(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            button1.Visible = false;
            Form1 form1 = new Form1();
            if (HangiBanka == 1)
            {
               this.BackColor = Color.Coral;
            }
            if (HangiBanka == 2)
            {
                this.BackColor = Color.Green;
            }
        }
        double faiz = 0;
        double anaPara = 0;
        double vade = 0;
        double toplamBorc = 0;
        double toplamFaiz = 0;
        double aylikBorc = 0;
        double aylikFaiz = 0;
        double aylikAnaPara = 0;

        private void BireyselLabel_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            BireyselLabel.Visible = false;
            KurumsalLabel.Visible = false;
            button1.Visible = true;
            isKurumsal = false;
            if (HangiBanka == 1)
            {
                faiz = 2.2;
            }
            if (HangiBanka == 2)
            {
                faiz = 2;
            }
            if (HangiBanka == 3)
            {
                faiz = 1.8;
            }
        }
        int counter = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (counter == 0)
                {
                    anaPara = double.Parse(textBox1.Text);
                    vade = double.Parse(textBox2.Text);
                    toplamFaiz = ((anaPara / 100) * faiz) * vade;
                    toplamBorc = (((anaPara / 100) * faiz) * vade) + anaPara;
                    aylikBorc = toplamBorc / vade;
                }
                if ((button1.Text == "Ödemeye Başla" || button1.Text == "Bir Sonraki Ay") && counter < vade && button1.Visible)
                {
                    button1.Text = "Bir Sonraki Ay";
                    button2.Visible = true;
                    aylikFaiz = ((anaPara / 100) * (faiz / 12)) * vade;
                    aylikAnaPara = aylikBorc - aylikFaiz;
                    anaPara -= aylikAnaPara;
                    toplamFaiz -= aylikFaiz;
                    label3.Text = $"{counter + 1}.Ay Borcu: {aylikBorc}TL Eğer borcunuzu şimdi kapatırsanız ödemeniz gereken tutar {anaPara}TL Kazancınız: {toplamFaiz}TL";
                    counter++;
                }

                else
                {

                    label3.Text = $"Toplam Borcunuz: {toplamBorc}TL  Toplam Faiz: {toplamFaiz}TL";
                    label1.Visible = false;
                    label2.Visible = false;
                    textBox1.Visible = false;
                    textBox2.Visible = false;
                    button1.Text = "Ödemeye Başla";
                }
                if (counter == vade)
                {
                    label3.Text = "Borcunuz bitti.";
                    button1.Visible = false;
                    button2.Visible = false;
                }
            }
            catch (Exception)
            {
                if (counter == 0 && isKurumsal == true)
                {
                    MessageBox.Show("Giriş yapıldı");
                }
                else
                {
                    MessageBox.Show("Lütfen bir tam sayı giriniz...");
                }
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            label3.Text = $"Borcunuz kapatılmıştır. Karınız:{toplamFaiz}";

        }
        bool isKurumsal = false;
        
        private void KurumsalLabel_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox1.Text = "Kullanıcı Adı";
            textBox2.Text = "Şifre";
            textBox2.UseSystemPasswordChar = true;
            BireyselLabel.Visible = false;
            KurumsalLabel.Visible = false;
            //button1.Visible = true;
            button3.Visible = true;
            if (HangiBanka == 1)
            {
                faiz = 1.9;
            }
            if (HangiBanka == 2)
            {
                faiz = 1.7;
            }
            if (HangiBanka == 3)
            {
                faiz = 1.6;
            }
            isKurumsal = true;
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            

            if (textBox1.Text == "admin" && textBox2.Text == "1234")
            {
                button1.Visible = true;
                button3.Visible = false;
                label1.Visible = true;
                label2.Visible = true;
                button1_Click(sender, e);
                textBox2.UseSystemPasswordChar = false;

            }
            else
            {
                MessageBox.Show("Yanlış kullanıcı adı ya da şifre");
            }
            textBox1.Clear();
            textBox2.Clear();
        }
    }
}
