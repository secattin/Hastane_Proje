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
    public partial class HastaGiris : Form
    {
        public HastaGiris()
        {
            InitializeComponent();
        }

        sqlBaglantı sql = new sqlBaglantı();
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           hasta_ekle fr = new hasta_ekle();
            fr.Show();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand kmd = new SqlCommand(" Select * From tbl_Hastalar where HastaTC=@p1 and HastaSifre=@p2 ",sql.baglantı());
            kmd.Parameters.AddWithValue("@p1",msktc.Text);
            kmd.Parameters.AddWithValue("@p2",txtsifre.Text);
            SqlDataReader dr = kmd.ExecuteReader();
            if (dr.Read())
            {
                frmHastaDetay fr = new frmHastaDetay();
                fr.tc= msktc.Text;
                fr.Show();
                this.Hide();
                
            }
            else
            {
                MessageBox.Show("tc kimlik numaranız yada şifre hatalı girildi");
            }
            sql.baglantı().Close();



        }
    }
}
