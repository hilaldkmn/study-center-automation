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
    public partial class y_anaa2 : Form
    {
        public y_anaa2()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection("Data Source=HILAL\\SQLEXPRESS;Initial Catalog=proje;Integrated Security=True");

        private void verilerigörüntüle()
        {
            listView1.Items.Clear();
            baglantı.Open();
            SqlCommand komut = new SqlCommand("select numara,ad,soyad,ders,ücreti,ögretmen,gün,saat from ogrenci", baglantı);
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
        private void y_anaa2_Load(object sender, EventArgs e)
        {

        }

        private void anToolStripMenuItem_Click(object sender, EventArgs e)
        {
            y_ana yanasec = new y_ana();
            yanasec.Show();
            this.Hide();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1sec = new Form1();
            form1sec.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            verilerigörüntüle();
        }

        int id = 0;

        private void button2_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("Delete from ogrenci where numara =("+id+")",baglantı);
            komut.ExecuteNonQuery();
            baglantı.Close();
            verilerigörüntüle();
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            textBox1.Text = listView1.SelectedItems[0].SubItems[0].Text;
            textBox2.Text = listView1.SelectedItems[0].SubItems[1].Text;
            textBox3.Text = listView1.SelectedItems[0].SubItems[2].Text;
            textBox4.Text = listView1.SelectedItems[0].SubItems[3].Text;
            textBox5.Text = listView1.SelectedItems[0].SubItems[4].Text;
            textBox6.Text = listView1.SelectedItems[0].SubItems[5].Text;
            textBox7.Text = listView1.SelectedItems[0].SubItems[6].Text;
            textBox8.Text = listView1.SelectedItems[0].SubItems[7].Text;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }


    }
}
