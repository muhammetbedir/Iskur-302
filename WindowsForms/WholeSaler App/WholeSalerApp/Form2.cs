using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WholeSalerApp
{
    public partial class Form2 : Form
    {
        string cID = "", firstName = "", lastName = "", phone = "", mail = "", age = "", adres = "";

        private void Form2_Load(object sender, EventArgs e)
        {
            Calis();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" )
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand($"MusteriGuncelle  {cID},'{textBox1.Text}','{textBox2.Text}','{textBox3.Text}','{textBox4.Text}', '{textBox6.Text}'", baglanti);
                cmd.Connection = baglanti;
                cmd.ExecuteNonQuery();
                baglanti.Close();
                Calis();
                MessageBox.Show("The Client has been Successfully Updated.");
            }
            else
            {
                MessageBox.Show("All Fields Must Be Filled In...");
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand($"MusteriSil {cID}", baglanti);
            cmd.Connection = baglanti;
            cmd.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("The Client was Successfully Deleted.");
            Calis();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-P87BVG5\\SQLEXPRESS;Initial Catalog=Whosaler;Integrated Security=true");
        public void Calis()
        {
            SqlDataAdapter SDA = new SqlDataAdapter("MusteriGoster", baglanti);
            DataTable dT = new DataTable();
            baglanti.Open();
            SDA.Fill(dT);
            dataGridView1.DataSource = dT;
            dataGridView1.Columns["CustomerID"].Visible = false;
            baglanti.Close();
        }
        public Form2()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "")
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand($"MusteriEkle '{textBox1.Text}','{textBox2.Text}','{textBox3.Text}', '{textBox4.Text}',{textBox5.Text},'{textBox6.Text}'", baglanti);
                cmd.Connection = baglanti;
                cmd.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("The Client was Successfully Added.");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
            }
            else
            {
                MessageBox.Show("All Fields Must Be Filled In...");
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cID = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            firstName = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            lastName = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            phone = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            mail = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            age = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            adres = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            textBox1.Text = firstName;
            textBox2.Text = lastName;
            textBox3.Text = phone;
            textBox4.Text = mail;
            textBox5.Text = age;
            textBox6.Text = adres;
        }
    }
}
