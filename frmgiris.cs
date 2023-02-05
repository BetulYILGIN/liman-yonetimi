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
    public partial class frmgiris : Form
    {
        public frmgiris()
        {
            InitializeComponent();
        }

        private void btnyntc_Click(object sender, EventArgs e)
        {
            frmyoneticidogrulama ac = new frmyoneticidogrulama();
            ac.Show();
            this.Hide();
        }

private void btnprsnl_Click(object sender, EventArgs e)
        {
            frmcalisan ac = new frmcalisan();
            ac.Show();
            this.Hide();

        }
    }
}
