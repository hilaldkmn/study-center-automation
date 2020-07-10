using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeg
{
    public partial class y_ana : Form
    {
        public y_ana()
        {
            InitializeComponent();
        }

        private void y_ana_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'projeDataSet.ogrenci' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.ogrenciTableAdapter.Fill(this.projeDataSet.ogrenci);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1sec = new Form1();
            form1sec.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            y_anaa yanaasec = new y_anaa();
            yanaasec.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            y_anaa2 yanaa2sec = new y_anaa2();
            yanaa2sec.Show();
            this.Hide();
        }

        private void anasayfaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            y_ana yanasec = new y_ana();
            yanasec.Show();
            this.Hide();
        }
    }
}
