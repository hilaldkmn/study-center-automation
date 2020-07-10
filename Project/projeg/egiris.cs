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
    public partial class egiris : Form
    {
        public egiris()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection("Data Source=HILAL\\SQLEXPRESS;Initial Catalog=proje;Integrated Security=True");
     

        private void egiris_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("select * from ögretmen where kullanıcı_ismi ='" + textBox1.Text + "'and sifre='" + textBox2.Text + "'", baglantı);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                e_ana eana = new e_ana();
                eana.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Yanlış Girdiniz");
            }
            baglantı.Close();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }
    }
}
