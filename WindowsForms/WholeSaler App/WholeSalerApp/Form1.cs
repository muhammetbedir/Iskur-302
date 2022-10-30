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

namespace WholeSalerApp
{
    
    public partial class Form1 : Form
    {

        Dictionary<int, int> combo1 = new Dictionary<int, int>();
        Dictionary<int, int> combo2 = new Dictionary<int, int>();
        Dictionary<int, int> combo3 = new Dictionary<int, int>();
        Dictionary<int, int> combo4 = new Dictionary<int, int>();


        //SqlConnection baglanti = new SqlConnection("server=.;database=Whosaler;UID=sa;password=1234");
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-P87BVG5\\SQLEXPRESS;Initial Catalog=Whosaler;Integrated Security=true");
        public Form1()
        {
            InitializeComponent();
        }
        int toplam = 0;
        public void Calis()
        {
            SqlDataAdapter SDA = new SqlDataAdapter("Orderproc", baglanti);
            DataTable dT = new DataTable();
            baglanti.Open();
            SDA.Fill(dT);
            dataGridView1.DataSource = dT;
            dataGridView1.Columns["OrderID"].Visible = false;
            baglanti.Close();

            SqlDataAdapter para = new SqlDataAdapter("ToplamKazanc", baglanti);
            DataTable earn = new DataTable();
            para.Fill(earn);
            baglanti.Open();
            
            foreach (DataRow dr in earn.Rows)
            {
                toplam += Convert.ToInt32((dr["UnitPrice"]));
            }
            label11.Text = Convert.ToString(toplam);
            baglanti.Close();

        }
        string orderID = "";
        string emlooye = "";
        string customer = "";
        string product = "";
        string quantity = "";
        string discount = "";
        string fright = "";
        string adres = "";
        string city = "";
        string shippers = "";
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }
        public void CalisanBilgi()
        {
           
            comboBox1.Items.Clear();
            baglanti.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Calisan", baglanti);
            da.Fill(dt);
            int sayi = 0;
            foreach (DataRow dr in dt.Rows)
            {
                comboBox1.Items.Add(dr["EmplyeeName"].ToString());
                //comboBox1.SelectedValue = dr["EmployeeID"].ToString();
                combo1.Add(sayi, Convert.ToInt32(dr["EmployeeID"]));
                sayi++;
            }
            baglanti.Close();
        }
        public void MusteriBilgi()
        {
            comboBox3.Items.Clear();
            baglanti.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Musteri", baglanti);
            da.Fill(dt);
            int sayi = 0;
            foreach (DataRow dr in dt.Rows)
            {
                comboBox3.Items.Add(dr["CustomerName"].ToString());
                //comboBox2.SelectedValue = dr["CustomerID"].ToString();
                combo3.Add(sayi, Convert.ToInt32(dr["CustomerID"]));
                sayi++;
            }
            baglanti.Close();
        }
        public void UrunBilgi()
        {
            comboBox2.Items.Clear();
            baglanti.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Urun", baglanti);
            da.Fill(dt);
            int sayi = 0;
            foreach (DataRow dr in dt.Rows)
            {
                comboBox2.Items.Add(dr["ProductName"].ToString());
                //comboBox2.SelectedValue = dr["ProductID"].ToString();
                combo2.Add(sayi, Convert.ToInt32(dr["ProductID"]));
                sayi++;
            }
            baglanti.Close();
        }
        public void KargocuBilgi()
        {
            comboBox4.Items.Clear();
            baglanti.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("KargoFirma", baglanti);
            da.Fill(dt);
            int sayi = 0;
            foreach (DataRow dr in dt.Rows)
            {
                comboBox4.Items.Add(dr["CompanyName"].ToString());
                //comboBox4.SelectedValue = dr["ShipperID"].ToString();
                combo4.Add(sayi, Convert.ToInt32(dr["ShipperID"]));
                sayi++;
            }
            baglanti.Close();
        }  
        private void Form1_Load(object sender, EventArgs e)
        {
            Calis();
            CalisanBilgi();
            MusteriBilgi();
            UrunBilgi();
            KargocuBilgi();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Urun", baglanti);
            da.Fill(dt);
            int stok = 0;
            foreach (DataRow dr in dt.Rows)
            {
                if (Convert.ToInt32(dr["ProductID"]) == combo2[comboBox2.SelectedIndex])
                {
                    stok =Convert.ToInt32(dr["UnitsInStock"]);
                }
            }
            baglanti.Close();
            if (stok >= Convert.ToInt32(textBox9.Text))
            {
                if (stok == 0)
                {
                    SqlCommand cmd = new SqlCommand($"UrunDevam {combo2[comboBox2.SelectedIndex]}", baglanti);
                }
                if (textBox10.Text != "" && textBox11.Text != "" && textBox12.Text != "" && textBox13.Text != "" && textBox9.Text != "" && comboBox1.SelectedIndex >= 0 && comboBox2.SelectedIndex >= 0 && comboBox3.SelectedIndex >= 0 && comboBox4.SelectedIndex >= 0)
                {
                    baglanti.Open();
                    SqlCommand cmd = new SqlCommand($" SiparisEkle {combo3[comboBox3.SelectedIndex]},{combo1[comboBox1.SelectedIndex]},{combo4[comboBox4.SelectedIndex]},{textBox11.Text}, '{textBox12.Text}', '{textBox13.Text}',{combo2[comboBox2.SelectedIndex]},{textBox9.Text},{textBox10.Text} ", baglanti);
                    cmd.Connection = baglanti;
                    cmd.ExecuteNonQuery();
                    baglanti.Close();
                    Calis();
                }
                else
                {
                    MessageBox.Show("All Fields Must Be Filled In...");
                }
                comboBox1.Text = null;
                comboBox2.Text = null;
                comboBox3.Text = null;
                comboBox4.Text = null;
                textBox10.Text = "";
                textBox9.Text = "";
                textBox11.Text = "";
                textBox12.Text = "";
                textBox13.Text = "";
            }
            else
            {
                MessageBox.Show("Insufficient Product...");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            orderID = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            SqlDataAdapter sqlCommand = new SqlDataAdapter($"EmployeeIDBul {orderID}",baglanti);
            DataTable dt = new DataTable();
            sqlCommand.Fill(dt);
            int eID = 0;
            foreach (DataRow dr in dt.Rows)
            {
                eID = Convert.ToInt32(dr["Employee"]);
            }
            emlooye = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            customer = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            SqlDataAdapter sqlCommand1= new SqlDataAdapter($"MusteriIDBul {orderID}", baglanti);
            DataTable dt1 = new DataTable();
            sqlCommand1.Fill(dt1);
            int cID = 0;
            foreach (DataRow dr in dt1.Rows)
            {
                cID = Convert.ToInt32(dr["CustomerID"]);
            }
            product = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            SqlDataAdapter sqlCommand2 = new SqlDataAdapter($"UrunBul {orderID}", baglanti);
            DataTable dt2= new DataTable();
            sqlCommand2.Fill(dt1);
            int pID = 0;
            foreach (DataRow dr in dt2.Rows)
            {
                pID = Convert.ToInt32(dr["ProductID"]);
            }
            quantity = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            discount = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            fright = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            adres = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            city = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
            shippers = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
            SqlDataAdapter sqlCommand3 = new SqlDataAdapter($"KargocuBul {orderID}", baglanti);
            DataTable dt3 = new DataTable();
            sqlCommand3.Fill(dt1);
            int sID = 0;
            foreach (DataRow dr in dt3.Rows)
            {
                sID = Convert.ToInt32(dr["ShipVia"]);
            }
            //comboBox1.Text = emlooye;
            int key1 = 0;
            for (int i = 0; i < combo1.Count; i++)
            {
                if (combo1[i] == eID)
                {
                    key1 = i;
                }
            }
            int key2 = 0;
            for (int i = 0; i < combo3.Count; i++)
            {
                if (combo3[i] == cID)
                {
                    key2 = i;
                }
            }
            int key3 = 0;
            for (int i = 0; i < combo2.Count; i++)
            {
                if (combo2[i] == cID)
                {
                    key3 = i;
                }
            }
            int key4 = 0;
            for (int i = 0; i < combo4.Count; i++)
            {
                if (combo4[i] == sID)
                {
                    key4 = i;
                }
            }
            comboBox1.SelectedIndex = key1;
            comboBox3.SelectedIndex = key2;
            comboBox2.SelectedIndex = key3;
            comboBox4.SelectedIndex = key4;
            textBox9.Text = quantity;
            textBox10.Text = discount;
            textBox11.Text = fright;
            textBox12.Text = adres;
            textBox13.Text = city;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox10.Text != "" && textBox11.Text != "" && textBox12.Text != "" && textBox13.Text != "" && textBox9.Text != "" && comboBox1.SelectedIndex >= 0 && comboBox2.SelectedIndex >= 0 && comboBox3.SelectedIndex >= 0 && comboBox4.SelectedIndex >= 0)
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand($" SiparisGuncelle  {orderID} , {combo3[comboBox3.SelectedIndex]},{combo1[comboBox1.SelectedIndex]},{combo4[comboBox4.SelectedIndex]},{textBox11.Text}, '{textBox12.Text}', '{textBox13.Text}',{combo2[comboBox2.SelectedIndex]},{textBox9.Text},{textBox10.Text} ", baglanti);
                cmd.ExecuteNonQuery();
                baglanti.Close();
                Calis();
            }
            else
            {
                MessageBox.Show("All Fields Must Be Filled In...");
            }
            comboBox1.Text = null;
            comboBox2.Text = null;
            comboBox3.Text = null;
            comboBox4.Text = null;
            textBox10.Text = "";
            textBox9.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";
            textBox13.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand($"SiparisSil {orderID}",baglanti);
            cmd.ExecuteNonQuery();
            baglanti.Close();
            Calis();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(dataGridView1.CurrentRow.Cells["OrderID"].Value);
            SqlCommand komut2 = new SqlCommand($"SiparisSil {id}", baglanti);
            baglanti.Open();
            komut2.ExecuteNonQuery();
            baglanti.Close();
            Calis();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form5 form = new Form5();
            form.Show();
            this.Hide();
        }
    }
}
