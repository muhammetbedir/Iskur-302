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

namespace Ado.Net
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        SqlConnection baglanti2 = new SqlConnection("Data Source=DESKTOP-P87BVG5\\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=true");
        //SqlConnection baglanti2 = new SqlConnection("Data Source=302-01;Initial Catalog=NORTHWND;user=sa;password=1234");
        private void KategoriEkle()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("KategoriSec", baglanti2);
            DataTable dt = new DataTable();
            //DataSet ds = new DataSet(); birden fazla tablo olursa 
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["CategoryID"].Visible = false;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            KategoriEkle();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            SqlCommand cmd = new SqlCommand($"KategoriEkle '{textBox1.Text}','{textBox2.Text}'");  
            cmd.Connection = baglanti2;
            baglanti2.Open();
            int eklenti2 = cmd.ExecuteNonQuery();
            if (eklenti2 > 0)
            {
                MessageBox.Show("Kaategori eklendi.");
                KategoriEkle();
            }
            else
            {
                MessageBox.Show("Bir hata gerçekleşti.");
            }
            baglanti2.Close();

        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(dataGridView1.CurrentRow.Cells["CategoryID"].Value);
            SqlCommand komut2 = new SqlCommand($"KategoriSil {id}", baglanti2);
            baglanti2.Open();
            int eklenti = komut2.ExecuteNonQuery();
            if (eklenti > 0)
            {
                MessageBox.Show("Başarılı bir şekilde silinmiştir.");
                KategoriEkle();
            }
            else
            {
                MessageBox.Show("Hata oluştu.");
            }
            baglanti2.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand($"KategoriGuncelle {textBox1.Tag},{textBox1.Text},{textBox2.Text}");
            komut2.Connection = baglanti2;
            baglanti2.Open();
            int eklenti = komut2.ExecuteNonQuery();
            if (eklenti > 0)
            {
                MessageBox.Show("Başarılı bir şekilde güncellendirmişir.");
                KategoriEkle();
            }
            else
            {
                MessageBox.Show("Hata oluştu.");
            }
            baglanti2.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells["CategoryName"].Value.ToString();
            textBox1.Tag = dataGridView1.CurrentRow.Cells["CategoryID"].Value;
            textBox2.Text = dataGridView1.CurrentRow.Cells["Description"].Value.ToString();
        }
    }
}
