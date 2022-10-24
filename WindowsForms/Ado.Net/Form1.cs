using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Ado.Net
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*
         SqlConnection baglanti = new SqlConnection("Data Source=(bilgisayar adı(server name));Initial Catalog=NORTHWND;Integrate Security=True"); kendi bilgisayarında kullanmak için
         */
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-P87BVG5\\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=true");
        //SqlConnection baglanti = new SqlConnection("Data Source=302-01;Initial Catalog=NORTHWND;user=sa;password=1234");
        private void UrunEkle()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("select *from Products", baglanti);
            DataTable dt = new DataTable();
            //DataSet ds = new DataSet(); birden fazla tablo olursa 
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["ProductID"].Visible = false;
            dataGridView1.Columns["SupplierID"].Visible = false;
            dataGridView1.Columns["CategoryID"].Visible = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
          UrunEkle();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string adi = textBox1.Text;
            decimal fiyat = numericUpDown2.Value;
            decimal stok = numericUpDown1.Value;
            SqlCommand komut = new SqlCommand($"insert into Products (ProductName,UnitPrice,UnitsInStock) values ('{adi}',{fiyat},{stok})");
            //komut.CommandText = String.Format($"insert into Products (ProductName,UnitPrice,UnitsInStock) values ('{adi}',{fiyat},{stok})");
            komut.Connection = baglanti;
            baglanti.Open();
            int eklenti = komut.ExecuteNonQuery();
            if (eklenti > 0)
            {
                MessageBox.Show("Başarılı bir şekilde eklenmiştir.");
                UrunEkle();
            }
            else
            {
                MessageBox.Show("Hata oluştu.");
            }
            baglanti.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells["ProductName"].Value.ToString();
            textBox1.Tag = dataGridView1.CurrentRow.Cells["ProductID"].Value;
            numericUpDown2.Value = Convert.ToDecimal(dataGridView1.CurrentRow.Cells["UnitPrice"].Value);
            numericUpDown1.Value = Convert.ToDecimal(dataGridView1.CurrentRow.Cells["UnitsInStock"].Value);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string adi = textBox1.Text;
            decimal fiyat = numericUpDown2.Value;
            decimal stok = numericUpDown1.Value;
            SqlCommand komut2 = new SqlCommand($"update Products set ProductName = '{adi}' , UnitPrice = {fiyat} ,UnitsInStock = {stok} where ProductID = {textBox1.Tag}");
            //komut.CommandText = String.Format($"insert into Products (ProductName,UnitPrice,UnitsInStock) values ('{adi}',{fiyat},{stok})");
            komut2.Connection = baglanti;
            baglanti.Open();
            int eklenti = komut2.ExecuteNonQuery();
            if (eklenti > 0)
            {
                MessageBox.Show("Başarılı bir şekilde güncellendirmişir.");
                UrunEkle();
            }
            else
            {
                MessageBox.Show("Hata oluştu.");
            }
            baglanti.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (dataGridView1.CurrentRow != null)
            {
                string adi = textBox1.Text;
                decimal fiyat = numericUpDown2.Value;
                decimal stok = numericUpDown1.Value;
                SqlCommand komut2 = new SqlCommand($"delete from Products where ProductID = {textBox1.Tag}");
                //komut.CommandText = String.Format($"insert into Products (ProductName,UnitPrice,UnitsInStock) values ('{adi}',{fiyat},{stok})");
                komut2.Connection = baglanti;
                baglanti.Open();
                int eklenti = komut2.ExecuteNonQuery();
                if (eklenti > 0)
                {
                    MessageBox.Show("Başarılı bir şekilde silinmiştir.");
                    UrunEkle();
                }
                else
                {
                    MessageBox.Show("Hata oluştu.");
                }
                baglanti.Close();
            }
        }


        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {

                int id = Convert.ToInt16(dataGridView1.CurrentRow.Cells["ProductID"].Value);
                SqlCommand komut2 = new SqlCommand($"delete from Products where ProductID = {id}", baglanti);
                baglanti.Open();
                int eklenti = komut2.ExecuteNonQuery();
                if (eklenti > 0)
                {
                    MessageBox.Show("Başarılı bir şekilde silinmiştir.");
                    UrunEkle();
                }
                else
                {
                    MessageBox.Show("Hata oluştu.");
                }
                baglanti.Close();
            }
        }
    }
}
