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

namespace PersonelEkle
{
    public partial class frmpersonelekle : Form
    {
        public frmpersonelekle()
        {
            InitializeComponent();
        }

        private void frmpersonelekle_Load(object sender, EventArgs e)
        {
            string[] iller = { "Adana","Adıyaman","Afyonkarahisar","Ağrı","Aksaray","Amasya","Ankara","Antalya","Ardahan","Artvin","Aydın","Balıkesir","Bartın",
                "Batman","Bayburt","Bilecik","Bingöl","Bitlis","Bolu","Burdur","Bursa","Çanakkale","Çankırı","Çorum","Denizli","Diyarbakır","Düzce","Edirne","Elazığ",
                "Erzincan","Erzurum","Eskişehir","Gaziantep","Giresun","Gümüşhane","Hakkâri","Hatay","Iğdır","Isparta","İstanbul","İzmir","Kahramanmaraş","Karabük",
                "Karaman","Kars","Kastamonu","Kayseri","Kırıkkale","Kırklareli","Kırşehir","Kilis","Kocaeli","Konya","Kütahya","Malatya","Manisa","Mardin","Mersin",
                "Muğla","Muş","Nevşehir","Niğde","Ordu","Osmaniye","Rize","Sakarya","Samsun","Siirt","Sinop","Sivas","Şanlıurfa","Şırnak","Tekirdağ","Tokat","Trabzon",
                "Tunceli","Uşak","Van","Yalova","Yozgat","Zonguldak"};
            cmbboxil.Items.AddRange(iller);


        }

        private void btngeri_Click(object sender, EventArgs e)
        {
            frmyonetici ac = new frmyonetici();
            ac.Show();
            this.Hide();
        }
    }
}
