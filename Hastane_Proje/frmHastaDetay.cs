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
    public partial class frmHastaDetay : Form
    {
        public frmHastaDetay()
        {
            InitializeComponent();
        }
        public string tc ;
        sqlBaglantı sql = new sqlBaglantı();
        private void frmHastaDetay_Load(object sender, EventArgs e)
        {
            lbltc.Text = tc;    

            SqlCommand kmd = new SqlCommand("Select HastaAd,HastaSoyad  from tbl_Hastalar where HastaTC=@P1 ",sql.baglantı());
            kmd.Parameters.AddWithValue("@p1",lbltc.Text);
            SqlDataReader dr = kmd.ExecuteReader();
            while(dr.Read())
            {
                lbladsoyad.Text= dr[0]+ " " + dr[1];
            }
            sql.baglantı().Close();

            // randevu geçmişini çekme

            DataTable dt = new DataTable();
            SqlDataAdapter ss = new SqlDataAdapter("Select * From tbl_Randevular  where HastaTC=" + tc, sql.baglantı());
            ss.Fill(dt);
            dataGridView1.DataSource = dt;


            // bransları çekme
            SqlCommand kmt2 = new SqlCommand("select BransAd from tbl_Branslar", sql.baglantı());
            SqlDataReader dr2 = kmt2.ExecuteReader();
            while(dr2.Read())
            {
                cmbrans.Items.Add(dr2[0]);
            }

            sql.baglantı().Close();



           


        }
            // doktor çekme

        private void cmbrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbdiktor.Items.Clear();
            SqlCommand kmd = new SqlCommand("select DoktorAd,DoktorSoyad from tbl_Doktorlar where DoktorBrans=@p1", sql.baglantı());
            kmd.Parameters.AddWithValue("@p1",cmbrans.Text);
            SqlDataReader dr = kmd.ExecuteReader();
            while (dr.Read())
            {
                cmbdiktor.Items.Add(dr[0]+ " " + dr[1]);
            
            }
            sql.baglantı().Close();


        }

        private void cmbdiktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter ss = new SqlDataAdapter(" Select * from tbl_Randevular where RandevuBrans ='" + cmbrans.Text +"'"+ "and RandevuDoktor='"+cmbdiktor.Text + "' and RandevuDurum=0",sql.baglantı());
            ss.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void linkbilgidüzen_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmBilgiDüzenle fr = new frmBilgiDüzenle();
            fr.TCNo = lbltc.Text;
            fr.Show();

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView2.SelectedCells[0].RowIndex;
            txtid.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();
        }

        private void btnrandevual_Click(object sender, EventArgs e)
        {
            SqlCommand kmt = new SqlCommand("update tbl_Randevular set RandevuDurum=1, HastaTC=@p1,HastaŞikayet=@p2 where Randevuid=@p3",sql.baglantı());
            kmt.Parameters.AddWithValue("@p1", lbltc.Text);
            kmt.Parameters.AddWithValue("@p2",richTexsikayet.Text);
            kmt.Parameters.AddWithValue("@p3",txtid.Text);
            kmt.ExecuteNonQuery();
            sql.baglantı().Close();
            MessageBox.Show("kayıt olusturuldu","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
