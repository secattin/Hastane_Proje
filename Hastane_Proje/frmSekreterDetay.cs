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
    public partial class frmSekreterDetay : Form
    {
        public frmSekreterDetay()
        {
            InitializeComponent();
        }
        public string tcno;
        sqlBaglantı sql = new sqlBaglantı();
        private void frmSekreterDetay_Load(object sender, EventArgs e)
        {
            lbltc.Text = tcno;
            //ad soyad
            SqlCommand kmt = new SqlCommand("select SekreterAdsoyad from tbl_Sekreterler where SekreterTC=@P1",sql.baglantı());
            kmt.Parameters.AddWithValue("@p1",lbltc.Text);
            SqlDataReader dr = kmt.ExecuteReader();
            while (dr.Read())
            {
                lblAdsoyad.Text= dr[0].ToString();
            }
            sql.baglantı().Close();

            // data  branşlar

            DataTable dt2 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From tbl_Branslar", sql.baglantı());
            da.Fill(dt2);
            dataGridBrans.DataSource = dt2;


            // doktorları getirme

            DataTable dt3 = new DataTable();
            SqlDataAdapter dt4 = new SqlDataAdapter("Select (DoktorAd + ' '+ DoktorSoyad) as ' Doktorlar' , DoktorBrans from tbl_Doktorlar",sql.baglantı());
            dt4.Fill(dt3);  
            dataGrdDoktor.DataSource = dt3; 
          // bransı combabax çekme

           SqlCommand kmt3 = new SqlCommand("select BransAd from tbl_Branslar",sql.baglantı());
           SqlDataReader dr3 = kmt3.ExecuteReader();
            while (dr3.Read())
            {
                cmbBrans.Items.Add(dr3[0]); 
            }


        }


        private void btnkaydet_Click(object sender, EventArgs e)
        {
            SqlCommand kyd = new SqlCommand("insert into tbl_Randevular (RandevuTarih,RandevuSaat,RandevuBrans,RandevuDoktor) Values (@r1,@r2,@r3,@r4)",sql.baglantı());
            kyd.Parameters.AddWithValue("@r1",msktarih.Text);
            kyd.Parameters.AddWithValue("@r2",msksaat.Text);
            kyd.Parameters.AddWithValue("@r3",cmbBrans.Text);
            kyd.Parameters.AddWithValue("@r4",cmbDoktor.Text);
            kyd.ExecuteNonQuery();
            sql.baglantı().Close();
            MessageBox.Show("kayıt başarılı şekilde oluşturuldu","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void cmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {

            // doktor cekme
            cmbDoktor.Items.Clear();
            SqlCommand kmt4 = new SqlCommand("Select DoktorAd, DoktorSoyad from tbl_Doktorlar where DoktorBrans=@p1", sql.baglantı());
            kmt4.Parameters.AddWithValue("@p1", cmbBrans.Text);
            SqlDataReader dr4 = kmt4.ExecuteReader();
            while (dr4.Read())
            {
                cmbDoktor.Items.Add(dr4[0]+ " "+ dr4[1]);
            }
            sql.baglantı().Close();

        }

        private void btnolustur_Click(object sender, EventArgs e)
        {
            SqlCommand duyuru = new SqlCommand("insert into tbl_Duyurular  (duyuru) values (@d1)", sql.baglantı());
            duyuru.Parameters.AddWithValue("@d1",richduyuru.Text);
            duyuru.ExecuteNonQuery();
            sql.baglantı().Close();
            MessageBox.Show("kayıt oluşturuldu","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btndoktorpnl_Click(object sender, EventArgs e)
        {
            frmDoktorPaneli frd = new frmDoktorPaneli();
            frd.Show();
            this.Hide();

        }

        private void btnbranspnl_Click(object sender, EventArgs e)
        {
            frmBransPaneli frb = new frmBransPaneli();
            frb.Show();
            this.Hide();
        }

        private void btnranevu_Click(object sender, EventArgs e)
        {
            frmRandevuLİstele fra = new frmRandevuLİstele();
            fra.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmDuyurular fd = new frmDuyurular();
            fd.Show();
            this.Hide();
        }
    }
}
