using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIMAN_YONETIM
{
    public partial class frmcalisan : Form

    {
        public frmcalisan()
        {
            InitializeComponent();
        }

        private void btnbislem_Click(object sender, EventArgs e)
        {
            frmbilgiislem ac = new frmbilgiislem();
            ac.Show();
            this.Hide();
        }

        private void btnmuhasebe_Click(object sender, EventArgs e)
        {
            frmmuhasebe ac = new frmmuhasebe();
            ac.Show();
            this.Hide();
        }

        private void btnburo_Click(object sender, EventArgs e)
        {
            frmburo ac = new frmburo();
            ac.Show();
            this.Hide();
        }

        private void btnguvenlik_Click(object sender, EventArgs e)
        {
            frmguvenlik ac = new frmguvenlik();
            ac.Show();
            this.Hide();
        }

        private void btngeri_Click(object sender, EventArgs e)
        {
            frmgiris ac = new frmgiris();
            ac.Show();
            this.Hide();
        }
    }
}
