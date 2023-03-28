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
    public partial class hasta_ekle : Form
    {
        public hasta_ekle()
        {
            InitializeComponent();
        }

        sqlBaglantı sql = new sqlBaglantı();
        private void btnkayıt_Click(object sender, EventArgs e)
        {

            SqlCommand kmd = new SqlCommand("insert into tbl_Hastalar (HastaAd,HastaSoyad,HastaTC,HastaTelefon,HastaSifre,HastaCinsiet) Values (@p1,@p2,@p3,@p4,@p5,@p6)",sql.baglantı());
            kmd.Parameters.AddWithValue("@p1", txtad.Text);
            kmd.Parameters.AddWithValue("@P2", textsoyad.Text);
            kmd.Parameters.AddWithValue("@p3",masktc.Text);
            kmd.Parameters.AddWithValue("@p4",masktel.Text);
            kmd.Parameters.AddWithValue("@p5",txtsifre.Text);
            kmd.Parameters.AddWithValue("@p6",cmbcinsiyet.Text);
            kmd.ExecuteNonQuery();
            sql.baglantı().Close();
            MessageBox.Show("Kaydınız gerçekleşmiştir şifreniz " + txtsifre.Text, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);




        }
    }
}
