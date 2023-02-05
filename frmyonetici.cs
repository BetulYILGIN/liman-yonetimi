using LIMAN_YONETIM;
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
    public partial class frmyonetici : Form
    {
        public frmyonetici()
        {
            InitializeComponent();
        }

        private void btnyntc_Click(object sender, EventArgs e)
        {
            frmyoneticidogrulama ac = new frmyoneticidogrulama();
            ac.Show();
            this.Hide();
        }


        private void btnpersonelbilgileri_Click(object sender, EventArgs e)
        {
            
        }

        private void btngeri_Click(object sender, EventArgs e)
        {
            frmgiris ac = new frmgiris();
            ac.Show();
            this.Hide();
        }

        private void btnpersonelekle_Click(object sender, EventArgs e)
        {
            frmPersonelEkle ac = new frmPersonelEkle();
            ac.Show();
            this.Hide();
        }
    }
  }

