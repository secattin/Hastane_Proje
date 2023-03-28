﻿using System;
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
    public partial class frmSsekreterGirişPanel : Form
    {
        public frmSsekreterGirişPanel()
        {
            InitializeComponent();
        }
        sqlBaglantı sql = new sqlBaglantı();

        private void girisyap_Click(object sender, EventArgs e)
        {
            SqlCommand kmt = new SqlCommand("select * from tbl_Sekreterler where SekreterTC=@p1 and SekreterSifre=@p2",sql.baglantı());
            kmt.Parameters.AddWithValue("@p1", msktc.Text);
            kmt.Parameters.AddWithValue("@p2",txtsifre.Text);
            SqlDataReader dr = kmt.ExecuteReader();
            if (dr.Read())
            {
                frmSekreterDetay frs = new frmSekreterDetay();
                frs.tcno=msktc.Text;
                frs.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("TC kimilik numarası yada şifre hatalı girildi tekrar deneyiniz");
            }
            sql.baglantı();

        }
    }
}
