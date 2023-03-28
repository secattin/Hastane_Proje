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
    public partial class frmRandevuLİstele : Form
    {
        public frmRandevuLİstele()
        {
            InitializeComponent();
        }
        sqlBaglantı sql = new sqlBaglantı();

        private void frmRandevuLİstele_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from tbl_Randevular",sql.baglantı());
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;

        }
    }
}
