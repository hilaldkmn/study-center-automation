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

namespace projeg
{
    public partial class y_anaa : Form
    {
        public y_anaa()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection("Data Source=HILAL\\SQLEXPRESS;Initial Catalog=proje;Integrated Security=True");

        private void verilerigörüntüle()
        {
            listView1.Items.Clear();
            baglantı.Open();
            SqlCommand komut = new SqlCommand("select numara,ad,soyad,ders,ücreti,ögretmen,gün,saat from ogrenci",baglantı);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["numara"].ToString();
                ekle.SubItems.Add(oku["ad"].ToString());
                ekle.SubItems.Add(oku["soyad"].ToString());
                ekle.SubItems.Add(oku["ders"].ToString());
                ekle.SubItems.Add(oku["ücreti"].ToString());
                ekle.SubItems.Add(oku["ögretmen"].ToString());
                ekle.SubItems.Add(oku["gün"].ToString());
                ekle.SubItems.Add(oku["saat"].ToString());

                listView1.Items.Add(ekle);

            }

            baglantı.Close();
        }

        private void y_anaa_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'projeDataSet.ogrenci' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.ogrenciTableAdapter.Fill(this.projeDataSet.ogrenci);

        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1sec = new Form1();
            form1sec.Show();
            this.Hide();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("insert into ogrenci (ad,soyad,ders,ücreti,ögretmen,gün,saat) values ('"+textBox1.Text.ToString()+"','" + textBox2.Text.ToString()+"','" + textBox3.Text.ToString()+"','" + textBox4.Text.ToString()+"','" + textBox5.Text.ToString()+"','" + textBox6.Text.ToString()+"','" + textBox7.Text.ToString()+"')",baglantı);
            komut.ExecuteNonQuery();
            baglantı.Close();
            verilerigörüntüle();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            verilerigörüntüle();

        }

        private void anasayfaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            y_ana yanasec = new y_ana();
            yanasec.Show();
            this.Hide();
        }

       
    }
}
