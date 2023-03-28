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
    public partial class frmDuyurular : Form
    {
        public frmDuyurular()
        {
            InitializeComponent();
        }
        sqlBaglantı sql = new sqlBaglantı();

        private void frmDuyurular_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable(); 
            SqlDataAdapter sd = new SqlDataAdapter("select * from tbl_Duyurular",sql.baglantı());
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
            sql.baglantı().Close();


        }
    }
}
