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

namespace Hastane_Proje
{
    public partial class frmBransPaneli : Form
    {
        public frmBransPaneli()
        {
            InitializeComponent();
        }
        sqlBaglantı sql = new sqlBaglantı();

        private void frmBransPaneli_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(" select * from tbl_Branslar",sql.baglantı());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand kmt = new SqlCommand("insert into tbl_Branslar (BransAd) values (@b1)",sql.baglantı());
            kmt.Parameters.AddWithValue("@b1",txtBranşAd.Text);
            kmt.ExecuteNonQuery();
            sql.baglantı().Close();
            MessageBox.Show("Kayıt Oluşturuldu", "Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen= dataGridView1.SelectedCells[0].RowIndex;
            txtBranşid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtBranşAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand kmt1 = new SqlCommand(" delete from tbl_Branslar where Bransid=@b1",sql.baglantı());
            kmt1.Parameters.AddWithValue("@b1", txtBranşid.Text);
            kmt1.ExecuteNonQuery();
            sql.baglantı().Close();
            MessageBox.Show("Kayıt Silindi","bilgi",MessageBoxButtons.OK , MessageBoxIcon.Information);
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand kmt2 = new SqlCommand("update tbl_Branslar set BransAd= @p1 where Bransid=@p2",sql.baglantı());
           kmt2.Parameters.AddWithValue("@p1",txtBranşAd.Text);
            kmt2.Parameters.AddWithValue("@p2", txtBranşid.Text);
            kmt2.ExecuteNonQuery();
            sql.baglantı().Close();
            MessageBox.Show("Kayıt Güncellendi","Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
    
}
