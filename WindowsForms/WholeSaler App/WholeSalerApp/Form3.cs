using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WholeSalerApp
{
    public partial class Form3 : Form
    {
        Dictionary<int, int> combo1 = new Dictionary<int, int>();
        Dictionary<int, int> combo2 = new Dictionary<int, int>();
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-P87BVG5\\SQLEXPRESS;Initial Catalog=Whosaler;Integrated Security=true");
        public Form3()
        {
            InitializeComponent();
        }
        public void TedarikciBilgi()
        {
            comboBox2.Items.Clear();
            baglanti.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Tedarikci", baglanti);
            da.Fill(dt);
            int sayi = 0;
            foreach (DataRow dr in dt.Rows)
            {
                comboBox2.Items.Add(dr["CompanyName"].ToString());
                //comboBox2.SelectedValue = dr["CustomerID"].ToString();
                combo1.Add(sayi, Convert.ToInt32(dr["SupplierID"]));
                sayi++;
            }
            baglanti.Close();
        }
        public void KategoriBilgisi()
        {
            comboBox3.Items.Clear();
            baglanti.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("KategoriGor", baglanti);
            da.Fill(dt);
            int sayi = 0;
            foreach (DataRow dr in dt.Rows)
            {
                comboBox3.Items.Add(dr["CategoriName"].ToString());
                //comboBox2.SelectedValue = dr["CustomerID"].ToString();
                combo2.Add(sayi, Convert.ToInt32(dr["CategoryID"]));
                sayi++;
            }
            baglanti.Close();
        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && comboBox2.SelectedIndex >= 0 && comboBox3.SelectedIndex >= 0)
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand($"UrunEkle '{textBox1.Text}',{combo1[comboBox2.SelectedIndex]},{combo2[comboBox3.SelectedIndex]},{textBox2.Text},{textBox3.Text}", baglanti);
                cmd.Connection = baglanti;
                cmd.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("The Product was Successfully Added.");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                comboBox2.SelectedIndex = 0;
                comboBox3.SelectedIndex = 0;
                Calis();
            }
            else
            {
                MessageBox.Show("All Fields Must Be Filled In...");
            }
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            TedarikciBilgi();
            KategoriBilgisi();
            Calis();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand($"UrunSil {urunID}", baglanti);
            cmd.Connection = baglanti;
            cmd.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("The Product was Successfully Deleted.");
            Calis();
        }
        public void Calis()
        {
            SqlDataAdapter SDA = new SqlDataAdapter("UrunGoster", baglanti);
            DataTable dT = new DataTable();
            baglanti.Open();
            SDA.Fill(dT);
            dataGridView1.DataSource = dT;
            dataGridView1.Columns["SupplierID"].Visible = false;
            dataGridView1.Columns["ProductID"].Visible = false;
            dataGridView1.Columns["CategoryID"].Visible = false;
            baglanti.Close();
        }
        string urunID = "", urunAdi = "", tedarikci = "",tedarikciID = "",fiyat ="",stok = "",kategoriID = "",kategoriAdi = "";

        private void button2_Click(object sender, EventArgs e)
        {

            if (textBox1.Text != "" && textBox2.Text!="" && textBox3.Text != "" && comboBox2.SelectedIndex >= 0 && comboBox3.SelectedIndex >= 0)
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand($"UrunGuncelle  {urunID},'{textBox1.Text}',{tedarikciID},{kategoriID},{textBox2.Text},{textBox3.Text}", baglanti);
                cmd.Connection = baglanti;
                cmd.ExecuteNonQuery();
                baglanti.Close();
                Calis();
                MessageBox.Show("The Product has been Successfully Updated.");
            }
            else
            {
                MessageBox.Show("All Fields Must Be Filled In...");
            }
        }
       
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            urunID = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            urunAdi = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            tedarikci = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            tedarikciID = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            fiyat = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            stok = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            kategoriID = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            kategoriAdi = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            int key1 = 0;
            int key2 = 0;
            for (int i = 0; i < combo1.Count; i++)
            {
                if (combo1[i] == Convert.ToInt32(tedarikciID))
                {
                    key1 = i;
                }
            }
            for (int i = 0; i < combo2.Count; i++)
            {
                if (combo2[i] == Convert.ToInt32(kategoriID))
                {
                    key2 = i;
                }
            }
            textBox1.Text = urunAdi;
            comboBox2.SelectedIndex = key1;
            comboBox3.SelectedIndex = key2;
            textBox2.Text = fiyat;
            textBox3.Text = stok;


        }

    }
}
