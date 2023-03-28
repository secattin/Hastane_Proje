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
    public partial class frmDoktorBilgiDüzenleme : Form
    {
        public frmDoktorBilgiDüzenleme()
        {
            InitializeComponent();
        }
        sqlBaglantı sql = new sqlBaglantı();
        public string TCNO;

        private void frmDoktorBilgiDüzenleme_Load(object sender, EventArgs e)
        {
            maskhasttc.Text = TCNO;

            SqlCommand kmt = new SqlCommand("select * from tbl_Doktorlar where DoktorTC=@p1",sql.baglantı());
            kmt.Parameters.AddWithValue("@p1",maskhasttc.Text);
            SqlDataReader dt = kmt.ExecuteReader();

            while (dt.Read())
            {
                txthastaad.Text= dt[1].ToString();
                txthastasoyad.Text= dt[2].ToString();
                cmbBrans.Text= dt[3].ToString();
                txthastasifre.Text= dt[5].ToString();   

            }
            sql.baglantı().Close();
              
           
        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand kmt1 = new SqlCommand("update tbl_Doktorlar set DoktorAd=@p1,DoktorSoyad=@p2,DoktorBrans=@p3,DoktorSifre=@p4 where DoktorTC=@p5", sql.baglantı());
            kmt1.Parameters.AddWithValue("@p1", txthastaad.Text);
            kmt1.Parameters.AddWithValue("@p2",txthastasoyad.Text);
            kmt1.Parameters.AddWithValue("@p3",cmbBrans.Text);
            kmt1.Parameters.AddWithValue("@p4", txthastasifre.Text);
            kmt1.Parameters.AddWithValue("@P5", maskhasttc.Text);
            kmt1.ExecuteNonQuery();
            sql.baglantı().Close();
            MessageBox.Show("Kayıt Güncellendi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
    
}
