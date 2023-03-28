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
    public partial class DoktorDetay : Form
    {
        public DoktorDetay()
        {
            InitializeComponent();
        }
        sqlBaglantı sql = new sqlBaglantı();
        public string TC ;

        private void DoktorDetay_Load(object sender, EventArgs e)
        {
            lbltc.Text = TC;

            // doktor ad soyad çekme
            SqlCommand kmt = new SqlCommand("select DoktorAd,DoktorSoyad from tbl_Doktorlar where DoktorTC=@p1",sql.baglantı());
            kmt.Parameters.AddWithValue("@p1",lbltc.Text);  
            SqlDataReader dt = kmt.ExecuteReader();
            while (dt.Read())
            {
                lbladsoyad.Text = dt[0]+ " " + dt[1];
            }


            // bransları cekme
            DataTable da = new DataTable();
            SqlDataAdapter sd = new SqlDataAdapter("select * from tbl_Randevular where RandevuDoktor='" + lbladsoyad.Text+"'", sql.baglantı());
            sd.Fill(da);
            dataGridView1.DataSource = da;

        }

        private void btnbildüzen_Click(object sender, EventArgs e)
        {
            frmDoktorBilgiDüzenleme fdb = new frmDoktorBilgiDüzenleme();
            fdb.TCNO = lbltc.Text;
            fdb.Show();
        }

        private void btnduyuru_Click(object sender, EventArgs e)
        {
            frmDuyurular fr = new frmDuyurular();
            fr.Show();
            this.Hide();
        }

        private void btnçıkış_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            richsikayet.Text=dataGridView1.Rows[secilen].Cells[7].Value.ToString();
        }
    }
}
