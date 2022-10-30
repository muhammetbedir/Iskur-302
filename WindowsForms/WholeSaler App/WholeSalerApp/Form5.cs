using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WholeSalerApp
{
    public partial class Form5 : Form
    {
        string employeeID = "", firstName = "", lastName = "", title = "", address = "", city = "", country = "", phone = "";

        private void button2_Click(object sender, EventArgs e)
        {

            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "")
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand($"Calisanguncelle {employeeID},'{textBox1.Text}','{textBox2.Text}','{textBox3.Text}','{textBox4.Text}','{textBox5.Text}','{textBox6.Text}','{textBox7.Text}'", baglanti);
                cmd.Connection = baglanti;
                cmd.ExecuteNonQuery();
                baglanti.Close();
                Calis();
                MessageBox.Show("The Employee was Successfully Updated.");
            }
            else
            {
                MessageBox.Show("All Fields Must Be Filled In...");
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand($"CalisanSil {employeeID}", baglanti);
            cmd.Connection = baglanti;
            cmd.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("The Employee was Successfully Deleted.");
            Calis();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-P87BVG5\\SQLEXPRESS;Initial Catalog=Whosaler;Integrated Security=true");
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            Calis();
        }
        public void Calis()
        {
            SqlDataAdapter SDA = new SqlDataAdapter("CalisaniGor", baglanti);
            DataTable dT = new DataTable();
            baglanti.Open();
            SDA.Fill(dT);
            dataGridView1.DataSource = dT;
            dataGridView1.Columns["EmployeeID"].Visible = false;
            dataGridView1.Columns["Birthdate"].Visible = false;
            baglanti.Close();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            employeeID = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            firstName = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            lastName = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            title = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            address = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            city = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            country = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            phone = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            textBox1.Text = firstName;
            textBox2.Text = lastName;
            textBox3.Text = title;
            textBox4.Text = address;
            textBox5.Text = city;
            textBox6.Text = country;
            textBox7.Text = phone;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "" )
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand($"CalisanEkle '{textBox1.Text}','{textBox2.Text}','{textBox3.Text}','{textBox4.Text}','{textBox5.Text}','{textBox6.Text}','{textBox7.Text}'", baglanti);
                cmd.Connection = baglanti;
                cmd.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("The Employee was Successfully Added.");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = ""; 
                textBox7.Text = "";
                Calis();
            }
            else
            {
                MessageBox.Show("All Fields Must Be Filled In...");
            }
        }
    }
}
