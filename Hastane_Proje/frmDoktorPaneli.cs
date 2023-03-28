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
    public partial class frmDoktorPaneli : Form
    {
        public frmDoktorPaneli()
        {
            InitializeComponent();
        }

        sqlBaglantı sql = new sqlBaglantı();

        private void frmDoktorPaneli_Load(object sender, EventArgs e)
        {
            DataTable dt3 = new DataTable();
            SqlDataAdapter dt4 = new SqlDataAdapter("Select * from tbl_Doktorlar", sql.baglantı());
            dt4.Fill(dt3);
            dataGridView1.DataSource = dt3;

            
            SqlCommand komut1 = new SqlCommand(" select BransAd  from tbl_Branslar", sql.baglantı());
            SqlDataReader dt = komut1.ExecuteReader();
            while (dt.Read())
            {
                cmbBrans.Items.Add(dt[0]);
                sql.baglantı().Close();
            }





        }






        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand(" insert into tbl_Doktorlar (DoktorAd,DoktorSoyad,DoktorBrans,DoktorTC,DoktorSifre) values (@p1,@p2,@p3,@p4,@p5)",sql.baglantı());
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2",txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", cmbBrans.Text);
            komut.Parameters.AddWithValue("@p4",mskTc.Text);    
            komut.Parameters.AddWithValue("@p5",txtSifre.Text);
            komut.ExecuteNonQuery();
            sql.baglantı().Close();
            MessageBox.Show("kayıt eklendi","bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);

           

            
        }



        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen= dataGridView1.SelectedCells[0].RowIndex;
            txtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            cmbBrans.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            mskTc.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtSifre.Text= dataGridView1.Rows[secilen].Cells[5].Value.ToString();

         
            
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand sil = new SqlCommand("delete from tbl_Doktorlar where DoktorTC=@p1",sql.baglantı());
            sil.Parameters.AddWithValue("@p1",mskTc.Text);
            sil.ExecuteNonQuery();
            sql.baglantı().Close();
            MessageBox.Show("kayıt silindi","bigi",MessageBoxButtons.OK , MessageBoxIcon.Information);
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update  tbl_Doktorlar set DoktorAd=@p1, DoktorSoyad=@p2,DoktorBrans=@p3,DoktorSifre=@p5 where DoktorTC=@p4",sql.baglantı());

            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", cmbBrans.Text);
            komut.Parameters.AddWithValue("@p4", mskTc.Text);
            komut.Parameters.AddWithValue("@p5", txtSifre.Text);
            komut.ExecuteNonQuery();
            sql.baglantı().Close();
            MessageBox.Show("kayıt Güncellendi", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        



    }
}
