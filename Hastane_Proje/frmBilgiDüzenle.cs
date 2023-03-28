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
    public partial class frmBilgiDüzenle : Form
    {
        public frmBilgiDüzenle()
        {
            InitializeComponent();
        }
        public string TCNo;
        sqlBaglantı sql = new sqlBaglantı();
        private void frmBilgiDüzenle_Load(object sender, EventArgs e)
        {
            maskhasttc.Text = TCNo;

            SqlCommand kmt = new SqlCommand("select * from tbl_Hastalar where HastaTC=@p1",sql.baglantı());
            kmt.Parameters.AddWithValue("@p1",TCNo);

            SqlDataReader dr = kmt.ExecuteReader();
            while (dr.Read())
            {
                txthastaad.Text= dr[1].ToString();
                txthastasoyad.Text= dr[2].ToString();
                maskhastatel.Text = dr[4].ToString();
                txthastasifre.Text = dr[5].ToString();
                cmbhastacinsiyet.Text = dr[6].ToString();
            }
            sql.baglantı().Close();
        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand kmt = new SqlCommand(" update tbl_Hastalar set HastaAd =@p1, HastaSoyad=@p2 ,HastaTelefon=@p3,HastaSifre=@p4, HastaCinsiet=@p5 where HastaTC=@p6" , sql.baglantı());
            kmt.Parameters.AddWithValue("@p1",txthastaad.Text);
            kmt.Parameters.AddWithValue("@p2", txthastasoyad.Text);
            kmt.Parameters.AddWithValue("@p3",maskhastatel.Text);
            kmt.Parameters.AddWithValue("@p4", txthastasifre.Text);
            kmt.Parameters.AddWithValue("@p5",cmbhastacinsiyet.Text);
            kmt.Parameters.AddWithValue("@p6",maskhasttc.Text);
            kmt.ExecuteNonQuery();
            sql.baglantı().Close();
            MessageBox.Show("Bilgileriniz güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);


        }
    }
}
