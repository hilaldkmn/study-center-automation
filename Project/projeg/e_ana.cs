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
    public partial class e_ana : Form
    {
        public e_ana()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection("Data Source=HILAL\\SQLEXPRESS;Initial Catalog=proje;Integrated Security=True");

        private void verilerigörüntüle()
        {
            listView1.Items.Clear();
            baglantı.Open();
            SqlCommand komut = new SqlCommand("select numara,ad,soyad,ders,töplam_devamsizlik,yorum from ogrenci", baglantı);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["numara"].ToString();
                ekle.SubItems.Add(oku["ad"].ToString());
                ekle.SubItems.Add(oku["soyad"].ToString());
                ekle.SubItems.Add(oku["ders"].ToString());
                ekle.SubItems.Add(oku["töplam_devamsizlik"].ToString());
                ekle.SubItems.Add(oku["yorum"].ToString());

                listView1.Items.Add(ekle);

            }

            baglantı.Close();
        }

        private void e_ana_Load(object sender, EventArgs e)
        {

        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1sec = new Form1();
            form1sec.Show();
            this.Hide();
        }

        int id = 0;

        private void button1_Click(object sender, EventArgs e)
        {
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
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("Update ogrenci set töplam_devamsizlik='"+textBox5.Text.ToString()+"' ,yorum='"+textBox6.Text.ToString()+"' where numara="+textBox1.Text+"", baglantı);
            komut.ExecuteNonQuery();
            baglantı.Close();
            verilerigörüntüle();
        }

        private void anasayfaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            e_ana eanasec = new e_ana();
            eanasec.Show();
            this.Hide();
        }
    }
}
