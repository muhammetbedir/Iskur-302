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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-P87BVG5\\SQLEXPRESS;Initial Catalog=Whosaler;Integrated Security=true");
        private void button4_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
        string kategoriID = "", kategoriAdi = "", aciklama = "";
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            kategoriID = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            kategoriAdi = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            aciklama = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox1.Text = kategoriAdi;
            textBox3.Text = aciklama;
            
        }
        public void Calis()
        {
            SqlDataAdapter SDA = new SqlDataAdapter("KategoriGoster", baglanti);
            DataTable dT = new DataTable();
            baglanti.Open();
            SDA.Fill(dT);
            dataGridView1.DataSource = dT;
            dataGridView1.Columns["CategoryID"].Visible = false;
            baglanti.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox3.Text != "")
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand($"KategoriGuncelle  {kategoriID},'{textBox1.Text}','{textBox3.Text}'", baglanti);
                cmd.Connection = baglanti;
                cmd.ExecuteNonQuery();
                baglanti.Close();
                Calis();
                MessageBox.Show("The Category has been Successfully Updated.");
            }
            else
            {
                MessageBox.Show("All Fields Must Be Filled In...");
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand($"KategoriSil {kategoriID}", baglanti);
            cmd.Connection = baglanti;
            cmd.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("The Category was Successfully Deleted.");
            Calis();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            Calis();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (  textBox3.Text != "" && textBox1.Text != "")
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand($"KategoriEkle '{textBox1.Text}','{textBox3.Text}'", baglanti);
                cmd.Connection = baglanti;
                cmd.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("The Category was Successfully Added.");
                textBox3.Text = "";
                textBox1.Text = "";              
                Calis();
            }
            else
            {
                MessageBox.Show("All Fields Must Be Filled In...");
            }
        }
    }
}
