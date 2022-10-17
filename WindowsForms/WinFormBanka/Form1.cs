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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static int HangiBanka = 0;
        private void ziraatLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            HangiBanka = 1;
            IsForm isForm = new IsForm(HangiBanka);
            isForm.Show();
            

        }

        private void garantiLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            HangiBanka = 2;
            IsForm isForm = new IsForm(HangiBanka);
            isForm.Show();
           
        }

        private void isLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            HangiBanka = 3;
            IsForm isForm = new IsForm(HangiBanka);
            isForm.Show();
        }
    }
}
