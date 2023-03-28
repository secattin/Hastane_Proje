using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastane_Proje
{
    public partial class frmgirisler : Form
    {
        public frmgirisler()
        {
            InitializeComponent();
        }

        private void btnhasta_Click(object sender, EventArgs e)
        {

            HastaGiris fr = new HastaGiris();
            fr.Show();
            this.Hide();
        }

        private void btndoktor_Click(object sender, EventArgs e)
        {
            frmDoktorGiriş fr = new frmDoktorGiriş();
            fr.Show();
            this.Hide();

        }

        private void btnsekreter_Click(object sender, EventArgs e)
        {
            frmSsekreterGirişPanel fr = new frmSsekreterGirişPanel();
            fr.Show();
            this.Hide();
        }

        private void frmgirisler_Load(object sender, EventArgs e)
        {

        }
    }
}
