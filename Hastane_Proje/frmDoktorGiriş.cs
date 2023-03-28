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
    public partial class frmDoktorGiriş : Form
    {
        public frmDoktorGiriş()
        {
            InitializeComponent();
        }
        sqlBaglantı sql = new sqlBaglantı();

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand kmt = new SqlCommand(" select * from tbl_Doktorlar where DoktorTC=@p1 and DoktorSifre=@p2",sql.baglantı());
            kmt.Parameters.AddWithValue("@p1",msktc.Text);
            kmt.Parameters.AddWithValue("@p2", txtsifre.Text);
            SqlDataReader dr = kmt.ExecuteReader();
            if (dr.Read())
            {
                DoktorDetay frd = new DoktorDetay();
                frd.TC=msktc.Text;
                frd.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("hatalı girdiniz","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            sql.baglantı().Close();

        }
    }
}
