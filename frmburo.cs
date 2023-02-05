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
    public partial class frmburo : Form
    {
        public frmburo()
        {
            InitializeComponent();
        }

        private void btngeri_Click(object sender, EventArgs e)
        {
            frmcalisan ac = new frmcalisan();
            ac.Show();
            this.Hide();
        }
    }
}
