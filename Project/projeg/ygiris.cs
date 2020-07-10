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
    public partial class ygiris : Form
    {
        public ygiris()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection("Data Source=HILAL\\SQLEXPRESS;Initial Catalog=proje;Integrated Security=True");



 

        private void button2_Click(object sender, EventArgs e)
        {
            
            baglantı.Open();
            SqlCommand komut = new SqlCommand("select * from adminn where kullanıcı ='" + textBox1.Text + "'and sifre='" + textBox2.Text + "'", baglantı);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                y_ana yana = new y_ana();
                yana.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Yanlış Girdiniz");
            }
            baglantı.Close();

        }

        private void ygiris_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }
    }
}
